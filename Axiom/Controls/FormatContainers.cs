using System.Collections.Generic;
using System.Collections.ObjectModel;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Controls
{
    public class Containers
    {
        // --------------------------------------------------
        // Containers
        // --------------------------------------------------

        // -------------------------
        // webm
        // -------------------------
        public class WebM
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "VP8",
                "VP9",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Vorbis",
                "Opus",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "Burn",
                "None"
            };
        }



        // -------------------------
        // mp4
        // -------------------------
        public class MP4
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "x264",
                "x265",
                "Copy"
            };

            public readonly static ObservableCollection<string> video_HWAccel = new ObservableCollection<string>()
            {
                "x264",
                "H264 AMF",
                "H264 NVENC",
                "H264 QSV",
                "x265",
                "HEVC AMF",
                "HEVC NVENC",
                "HEVC QSV",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AC3",
                "AAC",
                "DTS",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "MOV Text",
                "Burn",
                "Copy",
                "None"
            };
        }



        // -------------------------
        // mkv
        // -------------------------
        public class MKV
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "x264",
                "x265",
                "VP8",
                "VP9",
                "AV1",
                "FFV1",
                "MagicYUV",
                "HuffYUV",
                "Theora",
                "Copy"
            };

            public readonly static ObservableCollection<string> video_HWAccel = new ObservableCollection<string>()
            {
                "x264",
                "H264 AMF",
                "H264 NVENC",
                "H264 QSV",
                "x265",
                "HEVC AMF",
                "HEVC NVENC",
                "HEVC QSV",
                "VP8",
                "VP9",
                "AV1",
                "FFV1",
                "MagicYUV",
                "HuffYUV",
                "Theora",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AC3",
                "AAC",
                "DTS",
                "Vorbis",
                "Opus",
                "LAME",
                "FLAC",
                "PCM",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "MOV Text",
                "SSA",
                "SRT",
                "Burn",
                "Copy",
                "None"
            };
        }



        // -------------------------
        // m2v
        // -------------------------
        public class M2V
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // mpg
        // -------------------------
        public class MPG
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "MPEG-4",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "MP2",
                "LAME",
                "AC3",
                "AAC",
                "DTS",
                "PCM",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "SRT",
                "Burn",
                "Copy",
                "None"
            };
        }



        // -------------------------
        // avi
        // -------------------------
        public class AVI
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "MPEG-2",
                "MPEG-4",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "MP2",
                "LAME",
                "AC3",
                "AAC",
                "DTS",
                "PCM",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "SRT",
                "Burn",
                "Copy",
                "None"
            };
        }



        // -------------------------
        // ogv
        // -------------------------
        public class OGV
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Video"

            };
            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "Theora",
                "Copy"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Vorbis",
                "Copy",
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "Copy",
                "None"
            };
        }



        // -------------------------
        // mp3
        // -------------------------
        public class LAME
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "LAME",
                "Copy"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // m4a
        // -------------------------
        public class M4A
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "AAC",
                "ALAC",
                "Copy"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // ogg
        // -------------------------
        public class OGG
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "Opus",
                "Vorbis",
                "Copy"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // flac
        // -------------------------
        public class FLAC
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "FLAC",
                "Copy"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // wav
        // -------------------------
        public class WAV
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Audio"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "PCM",
                "Copy"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "None"
            };
        }



        // -------------------------
        // jpg
        // -------------------------
        // Note: Container is .jpg, Codec Name is JPEG, Codec is -c:v mjpeg 
        public class JPG
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "JPEG"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "Burn",
                "None"
            };
        }



        // -------------------------
        // png
        // -------------------------
        public class PNG
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "PNG"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "Burn",
                "None"
            };
        }



        // -------------------------
        // webp
        // -------------------------
        public class WebP
        {
            // Media Type
            public readonly static ObservableCollection<string> media = new ObservableCollection<string>()
            {
                "Image",
                "Sequence"
            };

            // Codecs
            public readonly static ObservableCollection<string> video = new ObservableCollection<string>()
            {
                "WebP"
            };

            public readonly static ObservableCollection<string> audio = new ObservableCollection<string>()
            {
                "None"
            };

            public readonly static ObservableCollection<string> subtitle = new ObservableCollection<string>()
            {
                "Burn",
                "None"
            };
        }

    }
}
