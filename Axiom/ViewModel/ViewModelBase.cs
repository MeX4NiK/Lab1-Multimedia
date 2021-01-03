using System.Collections.Generic;
using System.ComponentModel;
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace ViewModel
{
    public class VM : INotifyPropertyChanged
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

        /// <summary>
        /// ViewModel Base
        /// </summary>
        public VM()
        {

        }

        // Main
        public static ViewModel.Main MainView { get; set; } = new Main();
        // Format
        public static ViewModel.Format FormatView { get; set; } = new Format();
        // Video
        public static ViewModel.Video VideoView { get; set; } = new Video();
        // Subtitle
        public static ViewModel.Subtitle SubtitleView { get; set; } = new Subtitle();
        // Audio
        public static ViewModel.Audio AudioView { get; set; } = new Audio();
        // Filter Video
        public static ViewModel.FilterVideo FilterVideoView { get; set; } = new FilterVideo();
        // Filter Audio
        public static ViewModel.FilterAudio FilterAudioView { get; set; } = new FilterAudio();
        // Configure
        public static ViewModel.Configure ConfigureView { get; set; } = new Configure();

    }
}
