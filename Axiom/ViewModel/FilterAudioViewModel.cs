
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace ViewModel
{
    public class FilterAudio : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private void OnPropertyChanged(string prop)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(prop));
            }
        }

        // Filter Audio View Model
        //public static FilterAudioView vm = new FilterAudioView();


        /// <summary>
        /// Filter View Model
        /// </summary>
        public FilterAudio()
        {
            LoadControlsDefaults();
        }


        /// <summary>
        /// Load Controls Defaults
        /// </summary>
        public void LoadControlsDefaults()
        {
            LoadFilterAudioDefaults();
        }


        /// <summary>
        /// Load Filter Video Defaults
        /// </summary>
        public void LoadFilterAudioDefaults()
        {
            // EQ
            FilterAudio_Lowpass_IsEnabled = true;
            FilterAudio_Lowpass_SelectedItem = "disabled";
            FilterAudio_Highpass_IsEnabled = true;
            FilterAudio_Highpass_SelectedItem = "disabled";

            // Dynamics
            FilterAudio_Contrast_IsEnabled = true;
            FilterAudio_Contrast_Value = 0;
            FilterAudio_ExtraStereo_IsEnabled = true;
            FilterAudio_ExtraStereo_Value = 0;
            FilterAudio_Headphones_IsEnabled = true;
            FilterAudio_Headphones_SelectedItem = "disabled";

            // Timing
            FilterAudio_Tempo_IsEnabled = true;
            FilterAudio_Tempo_Value = 100; 
        }


        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Filter Audio
        /// </summary>
        // --------------------------------------------------------------------------------------------------------

        // -------------------------
        // Lowpass
        // -------------------------
        // Items
        public ObservableCollection<string> _FilterAudio_Lowpass_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public ObservableCollection<string> FilterAudio_Lowpass_Items
        {
            get { return _FilterAudio_Lowpass_Items; }
            set { _FilterAudio_Lowpass_Items = value; }
        }

        // Selected Item
        private string _FilterAudio_Lowpass_SelectedItem;
        public string FilterAudio_Lowpass_SelectedItem
        {
            get { return _FilterAudio_Lowpass_SelectedItem; }
            set
            {
                if (_FilterAudio_Lowpass_SelectedItem == value)
                {
                    return;
                }

                _FilterAudio_Lowpass_SelectedItem = value;
                OnPropertyChanged("FilterAudio_Lowpass_SelectedItem");
            }
        }

        // Controls Enable
        private bool _FilterAudio_Lowpass_IsEnabled;
        public bool FilterAudio_Lowpass_IsEnabled
        {
            get { return _FilterAudio_Lowpass_IsEnabled; }
            set
            {
                if (_FilterAudio_Lowpass_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_Lowpass_IsEnabled = value;
                OnPropertyChanged("FilterAudio_Lowpass_IsEnabled");
            }
        }


        // -------------------------
        // Highpass
        // -------------------------
        // Items
        public ObservableCollection<string> _FilterAudio_Highpass_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public ObservableCollection<string> FilterAudio_Highpass_Items
        {
            get { return _FilterAudio_Highpass_Items; }
            set { _FilterAudio_Highpass_Items = value; }
        }
        // Selected Item
        private string _FilterAudio_Highpass_SelectedItem;
        public string FilterAudio_Highpass_SelectedItem
        {
            get { return _FilterAudio_Highpass_SelectedItem; }
            set
            {
                if (_FilterAudio_Highpass_SelectedItem == value)
                {
                    return;
                }

                _FilterAudio_Highpass_SelectedItem = value;
                OnPropertyChanged("FilterAudio_Highpass_SelectedItem");
            }
        }
        // Controls Enable
        private bool _FilterAudio_Highpass_IsEnabled;
        public bool FilterAudio_Highpass_IsEnabled
        {
            get { return _FilterAudio_Highpass_IsEnabled; }
            set
            {
                if (_FilterAudio_Highpass_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_Highpass_IsEnabled = value;
                OnPropertyChanged("FilterAudio_Highpass_IsEnabled");
            }
        }


        // -------------------------
        // Headphones (Earwax)
        // -------------------------
        // Items
        public ObservableCollection<string> _FilterAudio_Headphones_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public ObservableCollection<string> FilterAudio_Headphones_Items
        {
            get { return _FilterAudio_Headphones_Items; }
            set { _FilterAudio_Headphones_Items = value; }
        }

        // Selected Item
        private string _FilterAudio_Headphones_SelectedItem;
        public string FilterAudio_Headphones_SelectedItem
        {
            get { return _FilterAudio_Headphones_SelectedItem; }
            set
            {
                if (_FilterAudio_Headphones_SelectedItem == value)
                {
                    return;
                }

                _FilterAudio_Headphones_SelectedItem = value;
                OnPropertyChanged("FilterAudio_Headphones_SelectedItem");
            }
        }
        // Controls Enable
        private bool _FilterAudio_Headphones_IsEnabled;
        public bool FilterAudio_Headphones_IsEnabled
        {
            get { return _FilterAudio_Headphones_IsEnabled; }
            set
            {
                if (_FilterAudio_Headphones_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_Headphones_IsEnabled = value;
                OnPropertyChanged("FilterAudio_Headphones_IsEnabled");
            }
        }


        // -------------------------
        // Contrast
        // -------------------------
        // Value
        private double _FilterAudio_Contrast_Value;
        public double FilterAudio_Contrast_Value
        {
            get { return _FilterAudio_Contrast_Value; }
            set
            {
                if (_FilterAudio_Contrast_Value == value)
                {
                    return;
                }

                _FilterAudio_Contrast_Value = value;
                OnPropertyChanged("FilterAudio_Contrast_Value");
            }
        }
        // Controls Enable
        private bool _FilterAudio_Contrast_IsEnabled;
        public bool FilterAudio_Contrast_IsEnabled
        {
            get { return _FilterAudio_Contrast_IsEnabled; }
            set
            {
                if (_FilterAudio_Contrast_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_Contrast_IsEnabled = value;
                OnPropertyChanged("FilterAudio_Contrast_IsEnabled");
            }
        }


        // -------------------------
        // Extra Stereo
        // -------------------------
        // Value
        private double _FilterAudio_ExtraStereo_Value;
        public double FilterAudio_ExtraStereo_Value
        {
            get { return _FilterAudio_ExtraStereo_Value; }
            set
            {
                if (_FilterAudio_ExtraStereo_Value == value)
                {
                    return;
                }

                _FilterAudio_ExtraStereo_Value = value;
                OnPropertyChanged("FilterAudio_ExtraStereo_Value");
            }
        }
        // Controls Enable
        private bool _FilterAudio_ExtraStereo_IsEnabled;
        public bool FilterAudio_ExtraStereo_IsEnabled
        {
            get { return _FilterAudio_ExtraStereo_IsEnabled; }
            set
            {
                if (_FilterAudio_ExtraStereo_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_ExtraStereo_IsEnabled = value;
                OnPropertyChanged("FilterAudio_ExtraStereo_IsEnabled");
            }
        }


        // -------------------------
        // Tempo
        // -------------------------
        // Value
        private double _FilterAudio_Tempo_Value;
        public double FilterAudio_Tempo_Value
        {
            get { return _FilterAudio_Tempo_Value; }
            set
            {
                if (_FilterAudio_Tempo_Value == value)
                {
                    return;
                }

                _FilterAudio_Tempo_Value = value;
                OnPropertyChanged("FilterAudio_Tempo_Value");
            }
        }
        // Controls Enable
        private bool _FilterAudio_Tempo_IsEnabled;
        public bool FilterAudio_Tempo_IsEnabled
        {
            get { return _FilterAudio_Tempo_IsEnabled; }
            set
            {
                if (_FilterAudio_Tempo_IsEnabled == value)
                {
                    return;
                }

                _FilterAudio_Tempo_IsEnabled = value;
                OnPropertyChanged("FilterAudio_Tempo_IsEnabled");
            }
        }



    }
}
