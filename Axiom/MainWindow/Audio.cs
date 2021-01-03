using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using ViewModel;
using System.IO;

#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Axiom
{
    public partial class MainWindow : Window
    {

        private void cboAudio_Codec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string audio_Codec_SelectedItem = (sender as ComboBox).SelectedItem as string;




            Controls.Format.Controls.MediaTypeControls();


            // -------------------------
            Controls.Format.Controls.AudioStreamControls();

            ConvertButtonText();

        }

        /// <summary>
        /// Audio Stream - ComboBox
        /// </summary>
        private void cboAudio_Stream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // Mux
            // -------------------------
            if (VM.AudioView.Audio_Stream_SelectedItem == "mux")
            {
                // Enable Audio Mux ListView and Buttons
                VM.AudioView.Audio_ListView_IsEnabled = true;

                VM.AudioView.Audio_ListView_Opacity = 1;
            }
            else
            {
                // Disable Audio Mux ListView and Buttons
                VM.AudioView.Audio_ListView_IsEnabled = false;

                VM.AudioView.Audio_ListView_Opacity = 0.15;
            }
        }


        /// <summary>
        /// Audio Channel - ComboBox
        /// </summary>
        private void cboAudio_Channel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        /// <summary>
        /// Audio Quality - ComboBox
        /// </summary>
        private void cboAudio_Quality_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Audio VBR - TextBox
        /// </summary>
        private void tbxAudio_BitRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            // -------------------------
            // Output Path Update Display
            // -------------------------
            //OutputPath_UpdateDisplay();
        }

        /// <summary>
        /// Audio VBR - Toggle
        /// </summary>
        // Checked
        private void tglAudio_VBR_Checked(object sender, RoutedEventArgs e)
        {

        }
        // Unchecked
        private void tglAudio_VBR_Unchecked(object sender, RoutedEventArgs e)
        {


            // -------------------------
            // Compression Level
            // -------------------------
            if (VM.AudioView.Audio_Codec_SelectedItem == "Opus")
            {
                VM.AudioView.Audio_CompressionLevel_IsEnabled = false;
            }
        }


        /// <summary>
        /// Audio Custom BitRate kbps - Textbox
        /// </summary>
        private void tbxAudio_BitRate_KeyDown(object sender, KeyEventArgs e)
        {
            // Only allow Numbers and Backspace
            Allow_Only_Number_Keys(e);
        }
        // Got Focus
        private void tbxAudio_BitRate_GotFocus(object sender, RoutedEventArgs e)
        {
            // Clear Textbox on first use
            if (VM.AudioView.Audio_BitRate_Text == string.Empty)
            {
                TextBox tbac = (TextBox)sender;
                tbac.Text = string.Empty;
                tbac.GotFocus += tbxAudio_BitRate_GotFocus; //used to be -=
            }
        }
        // Lost Focus
        private void tbxAudio_BitRate_LostFocus(object sender, RoutedEventArgs e)
        {
            // Change Textbox back to kbps
            TextBox tbac = sender as TextBox;
            if (tbac.Text.Trim().Equals(string.Empty))
            {
                tbac.Text = string.Empty;
                tbac.GotFocus -= tbxAudio_BitRate_GotFocus; //used to be +=
            }
        }

        private void cboAudio_SampleRate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cboAudio_BitDepth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbxAudio_Volume_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void tbxAudio_Volume_KeyDown(object sender, KeyEventArgs e)
        {
            // Only allow Numbers and Backspace
            Allow_Only_Number_Keys(e);
        }

        /// <summary>
        /// Volume Buttons
        /// </summary>
        // -------------------------
        // Up
        // -------------------------
        // Volume Up Button Click
        private void btnAudio_VolumeUp_Click(object sender, RoutedEventArgs e)
        {
            int value;
            int.TryParse(VM.AudioView.Audio_Volume_Text, out value);

            value += 1;
            VM.AudioView.Audio_Volume_Text = value.ToString();
        }
        // Up Button Each Timer Tick
        private void dispatcherTimerUp_Tick(object sender, EventArgs e)
        {
            int value;
            int.TryParse(VM.AudioView.Audio_Volume_Text, out value);

            value += 1;
            VM.AudioView.Audio_Volume_Text = value.ToString();
        }
        // Hold Up Button
        private void btnAudio_VolumeUp_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Timer      
            dispatcherTimerUp.Interval = new TimeSpan(0, 0, 0, 0, 100); //100ms
            dispatcherTimerUp.Start();
        }
        // Up Button Released
        private void btnAudio_VolumeUp_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            // Disable Timer
            dispatcherTimerUp.Stop();
        }
        // -------------------------
        // Down
        // -------------------------
        // Volume Down Button Click
        private void btnAudio_VolumeDown_Click(object sender, RoutedEventArgs e)
        {
            int value;
            int.TryParse(VM.AudioView.Audio_Volume_Text, out value);

            value -= 1;
            VM.AudioView.Audio_Volume_Text = value.ToString();
        }
        // Down Button Each Timer Tick
        private void dispatcherTimerDown_Tick(object sender, EventArgs e)
        {
            int value;
            int.TryParse(VM.AudioView.Audio_Volume_Text, out value);

            value -= 1;
            VM.AudioView.Audio_Volume_Text = value.ToString();
        }
        // Hold Down Button
        private void btnAudio_VolumeDown_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Timer      
            dispatcherTimerDown.Interval = new TimeSpan(0, 0, 0, 0, 100); //100ms
            dispatcherTimerDown.Start();
        }
        // Down Button Released
        private void btnAudio_VolumeDown_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            // Disable Timer
            dispatcherTimerDown.Stop();
        }


        /// <summary>
        /// Audio Hard Limiter - Slider
        /// </summary>
        private void slAudio_HardLimiter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Reset to default
            VM.AudioView.Audio_HardLimiter_Value = 0.0;

            //Controls.Audio.Controls.AutoCopyAudioCodec("control");
        }

        private void slAudio_HardLimiter_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            //Controls.Audio.Controls.AutoCopyAudioCodec("control");
        }

        private void tbxAudio_HardLimiter_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            //Controls.Audio.Controls.AutoCopyAudioCodec("control");
        }


        /// <summary>
        /// Audio Mux - ListView
        /// </summary>
        private void lstvAudio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // ListView
            // -------------------------
            // Clear before adding new selected items
            if (VM.AudioView.Audio_ListView_SelectedItems != null &&
                VM.AudioView.Audio_ListView_SelectedItems.Count > 0)
            {
                VM.AudioView.Audio_ListView_SelectedItems.Clear();
                VM.AudioView.Audio_ListView_SelectedItems.TrimExcess();
            }

            // Create Selected Items List for ViewModel
            VM.AudioView.Audio_ListView_SelectedItems = lstvAudio.SelectedItems
                                                                 .Cast<string>()
                                                                 .ToList();

            // -------------------------
            // Set Metadata
            // -------------------------
            int selectedIndex = VM.AudioView.Audio_ListView_SelectedIndex;

        }

        /// <summary>
        /// Audio Add - Button
        /// </summary>
        private void btnAudio_Add_Click(object sender, RoutedEventArgs e)
        {
            // Open Select File Window
            //Microsoft.Win32.OpenFileDialog selectFiles = new Microsoft.Win32.OpenFileDialog();
            Microsoft.Win32.OpenFileDialog selectFiles = new Microsoft.Win32.OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                //RestoreDirectory = true,
                //ReadOnlyChecked = true,
                //ShowReadOnly = true
            };

            // Defaults
            selectFiles.Multiselect = true;
            selectFiles.Filter = "All files (*.*)|*.*";
        }


        private void btnAudio_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (VM.AudioView.Audio_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.AudioView.Audio_ListView_SelectedIndex;

                // -------------------------
                // List View
                // -------------------------
                // ListView Items
                var itemlsvFileNames = VM.AudioView.Audio_ListView_Items[selectedIndex];
                VM.AudioView.Audio_ListView_Items.RemoveAt(selectedIndex);

            }
        }

        /// <summary>
        /// Audio Sort Up
        /// </summary>
        private void btnAudio_SortUp_Click(object sender, RoutedEventArgs e)
        {
            if (VM.AudioView.Audio_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.AudioView.Audio_ListView_SelectedIndex;

                if (selectedIndex > 0)
                {
                    // -------------------------
                    // List View
                    // -------------------------
                    // ListView Items
                    var itemlsvFileNames = VM.AudioView.Audio_ListView_Items[selectedIndex];
                    VM.AudioView.Audio_ListView_Items.RemoveAt(selectedIndex);
                    VM.AudioView.Audio_ListView_Items.Insert(selectedIndex - 1, itemlsvFileNames);

                    // -------------------------
                    // Highlight Selected Index
                    // -------------------------
                    VM.AudioView.Audio_ListView_SelectedIndex = selectedIndex - 1;
                }
            }
        }

        /// <summary>
        /// Audio Sort Down
        /// </summary>
        private void btnAudio_SortDown_Click(object sender, RoutedEventArgs e)
        {
            if (VM.AudioView.Audio_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.AudioView.Audio_ListView_SelectedIndex;

                if (selectedIndex + 1 < VM.AudioView.Audio_ListView_Items.Count)
                {
                    // -------------------------
                    // ListView
                    // -------------------------
                    // ListView Items
                    var itemlsvFileNames = VM.AudioView.Audio_ListView_Items[selectedIndex];
                    VM.AudioView.Audio_ListView_Items.RemoveAt(selectedIndex);
                    VM.AudioView.Audio_ListView_Items.Insert(selectedIndex + 1, itemlsvFileNames);



                    // -------------------------
                    // Highlight Selected Index
                    // -------------------------
                    VM.AudioView.Audio_ListView_SelectedIndex = selectedIndex + 1;
                }
            }
        }

        /// <summary>
        /// Audio Clear All
        /// </summary>
        private void btnAudio_Clear_Click(object sender, RoutedEventArgs e)
        {
            AudioClear();
        }
        /// <summary>
        /// Audio Clear - Method
        /// </summary>
        public void AudioClear()
        {
            // -------------------------
            // List View
            // -------------------------
            // Clear List View
            if (VM.AudioView.Audio_ListView_Items != null &&
                VM.AudioView.Audio_ListView_Items.Count > 0)
            {
                VM.AudioView.Audio_ListView_Items.Clear();
            }




        }

        /// <summary>
        /// Title Metadata - TextBox
        /// </summary>
        private void tbxAudio_Metadata_Title_KeyUp(object sender, KeyEventArgs e)
        {
            SaveMetadata_Audio_Title();
        }
        private void tbxAudio_Metadata_Title_LostFocus(object sender, RoutedEventArgs e)
        {
            SaveMetadata_Audio_Title();
        }
        public void SaveMetadata_Audio_Title()
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.AudioView.Audio_Stream_SelectedItem != "mux")
            {
                return;
            }
        }

        /// <summary>
        /// Audio Language Metadata - ComboBox
        /// </summary>
        private void cboAudio_Metadata_Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.AudioView.Audio_Stream_SelectedItem != "mux")
            {
                return;
            }

        }

        /// <summary>
        /// Audio Delay - TextBox
        /// </summary>
        private void tbxAudio_Delay_KeyUp(object sender, KeyEventArgs e)
        {
            SaveMetadata_Audio_Delay();
        }
        private void tbxAudio_Delay_LostFocus(object sender, RoutedEventArgs e)
        {
            SaveMetadata_Audio_Delay();
        }
        public void SaveMetadata_Audio_Delay()
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.AudioView.Audio_Stream_SelectedItem != "mux")
            {
                return;
            }

        }

    }
}
