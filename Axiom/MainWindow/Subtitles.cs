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
        private void cboSubtitle_Codec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string subtitle_Codec_SelectedItem = (sender as ComboBox).SelectedItem as string;

            // -------------------------
            // Halt if Selected Codec is Null
            // -------------------------
            if (string.IsNullOrWhiteSpace(subtitle_Codec_SelectedItem))
            {
                return;
            }


            Controls.Format.Controls.MediaTypeControls();

            ConvertButtonText();
        }


        /// <summary>
        /// Subtitle Stream - ComboBox
        /// </summary>
        private void cboSubtitle_Stream_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // Mux
            // -------------------------
            // ListView Opacity
            if (VM.SubtitleView.Subtitle_Stream_SelectedItem == "mux" ||
                VM.SubtitleView.Subtitle_Stream_SelectedItem == "external")
            {
                // Show
                VM.SubtitleView.Subtitle_ListView_Opacity = 1;
            }
            else
            {
                // Hide
                VM.SubtitleView.Subtitle_ListView_Opacity = 0.15;
            }

            // Enable Metadata
            // Mux
            if (VM.SubtitleView.Subtitle_Stream_SelectedItem == "mux")
            {
                // Enable ListView
                VM.SubtitleView.Subtitle_ListView_IsEnabled = true;
                // Enable Metadata
                VM.SubtitleView.Subtitle_Metadata_Title_IsEnabled = true;
                VM.SubtitleView.Subtitle_Metadata_Language_IsEnabled = true;
            }
            // External (Burn)
            else if (VM.SubtitleView.Subtitle_Stream_SelectedItem == "external")
            {
                // Enable ListView
                VM.SubtitleView.Subtitle_ListView_IsEnabled = true;
                // Disable Metadata
                VM.SubtitleView.Subtitle_Metadata_Title_IsEnabled = false;
                VM.SubtitleView.Subtitle_Metadata_Language_IsEnabled = false;
            }
            // Other Streams
            else
            {
                // Disable Subtitle Mux ListView and Buttons
                VM.SubtitleView.Subtitle_ListView_IsEnabled = false;
                VM.SubtitleView.Subtitle_Metadata_Title_IsEnabled = false;
                VM.SubtitleView.Subtitle_Metadata_Language_IsEnabled = false;
            }
        }

        /// <summary>
        /// Subtitle ListView
        /// </summary>
        private void lstvSubtitles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // ListView
            // -------------------------
            // Clear before adding new selected items
            if (VM.SubtitleView.Subtitle_ListView_SelectedItems != null &&
                VM.SubtitleView.Subtitle_ListView_SelectedItems.Count > 0)
            {
                VM.SubtitleView.Subtitle_ListView_SelectedItems.Clear();
                VM.SubtitleView.Subtitle_ListView_SelectedItems.TrimExcess();
            }

            // Create Selected Items List for ViewModel
            VM.SubtitleView.Subtitle_ListView_SelectedItems = lstvSubtitles.SelectedItems
                                                                           .Cast<string>()
                                                                           .ToList();

            // -------------------------
            // Set Metadata
            // -------------------------
            int selectedIndex = VM.SubtitleView.Subtitle_ListView_SelectedIndex;
        }


        /// <summary>
        /// Subtitle Add
        /// </summary>
        private void btnSubtitle_Add_Click(object sender, RoutedEventArgs e)
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
            selectFiles.Filter = "All files (*.*)|*.*|SRT (*.srt)|*.srt|SUB (*.sub)|*.sub|SBV (*.sbv)|*.sbv|ASS (*.ass)|*.ass|SSA (*.ssa)|*.ssa|MPSUB (*.mpsub)|*.mpsub|LRC (*.lrc)|*.lrc|CAP (*.cap)|*.cap";

            // Process Dialog Box
            //Nullable<bool> result = selectFiles.ShowDialog();
            //if (result == true)
            if (selectFiles.ShowDialog() == true)
            {
                // Reset
                //SubtitlesClear();

                // Add Selected Files to List
                for (var i = 0; i < selectFiles.FileNames.Length; i++)
                {


                    // ListView Display File Names + Ext
                    VM.SubtitleView.Subtitle_ListView_Items.Add(Path.GetFileName(selectFiles.FileNames[i]));

                }
            }
        }

        /// <summary>
        /// Subtitle Remove
        /// </summary>
        private void btnSubtitle_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (VM.SubtitleView.Subtitle_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.SubtitleView.Subtitle_ListView_SelectedIndex;

                // -------------------------
                // List View
                // -------------------------
                // ListView Items
                var itemlsvFileNames = VM.SubtitleView.Subtitle_ListView_Items[selectedIndex];
                VM.SubtitleView.Subtitle_ListView_Items.RemoveAt(selectedIndex);
            }
        }

        /// <summary>
        /// Subtitle Clear All
        /// </summary>
        private void btnSubtitle_Clear_Click(object sender, RoutedEventArgs e)
        {
            SubtitlesClear();
        }

        /// <summary>
        /// Subtitle Clear - Method
        /// </summary>
        public void SubtitlesClear()
        {
            // -------------------------
            // List View
            // -------------------------
            // Clear List View
            if (VM.SubtitleView.Subtitle_ListView_Items != null &&
                VM.SubtitleView.Subtitle_ListView_Items.Count > 0)
            {
                VM.SubtitleView.Subtitle_ListView_Items.Clear();
            }

        }

        /// <summary>
        /// Subtitle Sort Up
        /// </summary>
        private void btnSubtitle_SortUp_Click(object sender, RoutedEventArgs e)
        {
            if (VM.SubtitleView.Subtitle_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.SubtitleView.Subtitle_ListView_SelectedIndex;

                if (selectedIndex > 0)
                {
                    // -------------------------
                    // List View
                    // -------------------------
                    // ListView Items
                    var itemlsvFileNames = VM.SubtitleView.Subtitle_ListView_Items[selectedIndex];
                    VM.SubtitleView.Subtitle_ListView_Items.RemoveAt(selectedIndex);
                    VM.SubtitleView.Subtitle_ListView_Items.Insert(selectedIndex - 1, itemlsvFileNames);

                    // -------------------------
                    // Highlight Selected Index
                    // -------------------------
                    VM.SubtitleView.Subtitle_ListView_SelectedIndex = selectedIndex - 1;
                }
            }
        }

        /// <summary>
        /// Subtitle Sort Down
        /// </summary>
        private void btnSubtitle_SortDown_Click(object sender, RoutedEventArgs e)
        {
            if (VM.SubtitleView.Subtitle_ListView_SelectedItems.Count > 0)
            {
                var selectedIndex = VM.SubtitleView.Subtitle_ListView_SelectedIndex;

                if (selectedIndex + 1 < VM.SubtitleView.Subtitle_ListView_Items.Count)
                {
                    // -------------------------
                    // List View
                    // -------------------------
                    // ListView Items
                    var itemlsvFileNames = VM.SubtitleView.Subtitle_ListView_Items[selectedIndex];
                    VM.SubtitleView.Subtitle_ListView_Items.RemoveAt(selectedIndex);
                    VM.SubtitleView.Subtitle_ListView_Items.Insert(selectedIndex + 1, itemlsvFileNames);

                    // -------------------------
                    // Highlight Selected Index
                    // -------------------------
                    VM.SubtitleView.Subtitle_ListView_SelectedIndex = selectedIndex + 1;
                }
            }
        }


        /// <summary>
        /// Title Metadata - TextBox
        /// </summary>
        private void tbxSubtitle_Metadata_Title_KeyUp(object sender, KeyEventArgs e)
        {
            SaveMetadata_Subtitle_Title();
        }
        private void tbxSubtitle_Metadata_Title_LostFocus(object sender, RoutedEventArgs e)
        {
            SaveMetadata_Subtitle_Title();
        }
        public void SaveMetadata_Subtitle_Title()
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.SubtitleView.Subtitle_Stream_SelectedItem != "mux")
            {
                return;
            }

        }

        /// <summary>
        /// Subtitle Language Metadata - ComboBox
        /// </summary>
        private void cboSubtitle_Metadata_Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.SubtitleView.Subtitle_Stream_SelectedItem != "mux")
            {
                return;
            }
        }

        /// <summary>
        /// Subtitle Delay - TextBox
        /// </summary>
        private void tbxSubtitle_Delay_KeyUp(object sender, KeyEventArgs e)
        {
            SaveMetadata_Subtitle_Delay();
        }
        private void tbxSubtitle_Delay_LostFocus(object sender, RoutedEventArgs e)
        {
            SaveMetadata_Subtitle_Delay();
        }
        public void SaveMetadata_Subtitle_Delay()
        {
            // -------------------------
            // Halts
            // -------------------------
            if (VM.SubtitleView.Subtitle_Stream_SelectedItem != "mux")
            {
                return;
            }

        }

    }
}
