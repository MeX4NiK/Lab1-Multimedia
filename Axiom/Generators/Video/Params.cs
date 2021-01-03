
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using ViewModel;
using Axiom;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Generate.Video
{
    public class Params
    {
        public static List<string> vParamsList = new List<string>(); // multiple parameters
        public static string vParams { get; set; } // combined inline list

        public static String Color_Matrix_Filter(string colorMatrix_SelectedItem)
        {
            // Auto
            if (colorMatrix_SelectedItem == "auto")
            {
                return string.Empty;
            }

            // Options
            string colorMatrix = "colormatrix=";

            switch (colorMatrix_SelectedItem)
            {
                case "BT.709":
                    colorMatrix += "bt709";
                    break;

                case "FCC":
                    colorMatrix += "fcc";
                    break;

                //case "BT.601":
                //    colorMatrix += "bt601";
                //    break;

                //case "BT.470":
                //    colorMatrix += "bt470";
                //    break;

                case "BT.470BG":
                    colorMatrix += "bt470bg";
                    break;

                case "SMPTE-170M":
                    colorMatrix += "smpte170m";
                    break;

                case "SMPTE-240M":
                    colorMatrix += "smpte240m";
                    break;

                    //case "BT.2020":
                    //    colorMatrix += "bt2020";
                    //    break;
            }

            // Log Console Message /////////
            Log.WriteAction = () =>
            {
                Log.logParagraph.Inlines.Add(new LineBreak());
                Log.logParagraph.Inlines.Add(new Bold(new Run("Color Matrix: ")) { Foreground = Log.ConsoleDefault });
                Log.logParagraph.Inlines.Add(new Run(colorMatrix) { Foreground = Log.ConsoleDefault });
            };
            Log.LogActions.Add(Log.WriteAction);

            return colorMatrix;
        }

        /// <summary>
        /// Video Color (Method)
        /// <summary>
        public static void Video_Color()
        {
            // Color List
            List<string> vColor_Params_List = new List<string>()
            {

                Color_Matrix_Filter(VM.VideoView.Video_Color_Matrix_SelectedItem)
            };

            // Join
            string filters = string.Join("\r\n:", vColor_Params_List
                                    .Where(s => !string.IsNullOrEmpty(s)));

            // Video Filter Add
            vParamsList.Add(filters);
        }


        /// <summary>
        /// Quality Parameters Combine (Method)
        /// <summary>
        /// <remarks>
        /// For x264 and x265 only (e.g. -x265-params "crf=25").
        /// These are different than codec parameters (e.g. -c:v libx265 -strict -2).
        /// </remarks>
        public static String QualityParams(string quality_SelectedItem,
                                           string codec_SelectedItem,
                                           string format_MediaType_SelectedItem
            )
        {
            // Video BitRate None Check
            // Video Codec None Check
            // Codec Copy Check
            // Media Type Check
            if (quality_SelectedItem != "None" &&
                codec_SelectedItem != "None" &&
                codec_SelectedItem != "Copy" &&
                format_MediaType_SelectedItem != "Audio")
            {
                // Only for x264/x265/HW Accel Codecs
                if (codec_SelectedItem == "x264" ||
                    codec_SelectedItem == "H264 AMF" ||
                    codec_SelectedItem == "H264 NVENC" ||
                    codec_SelectedItem == "H264 QSV" ||
                    codec_SelectedItem == "x265" ||
                    codec_SelectedItem == "HEVC AMF" ||
                    codec_SelectedItem == "HEVC NVENC" ||
                    codec_SelectedItem == "HEVC QSV")
                {
                    // --------------------------------------------------
                    // Add Each Filter to Master Filters List
                    // --------------------------------------------------
                    //MessageBox.Show(string.Join("", VideoParams.vParamsList)); //debug
                    // -------------------------
                    // Color
                    // -------------------------
                    Video_Color();

                    // -------------------------
                    // Empty Halt
                    // -------------------------
                    if (vParamsList == null ||  // Null Check
                        vParamsList.Count == 0) // None Check
                    {
                        return string.Empty;
                    }

                    // -------------------------
                    // Remove Empty Strings
                    // -------------------------
                    vParamsList.RemoveAll(s => string.IsNullOrEmpty(s));

                    // -------------------------
                    // Codec
                    // -------------------------
                    string codec = string.Empty;
                    // x264
                    if (codec_SelectedItem == "x264" ||
                        codec_SelectedItem == "H264 AMF" ||
                        codec_SelectedItem == "H264 NVENC" ||
                        codec_SelectedItem == "H264 QSV")
                    {
                        codec = "-x264-params ";
                    }
                    // x265
                    else if (codec_SelectedItem == "x265" ||
                             codec_SelectedItem == "HEVC AMF" ||
                             codec_SelectedItem == "HEVC NVENC" ||
                             codec_SelectedItem == "HEVC QSV")
                    {
                        codec = "-x265-params ";
                    }

                    //switch (VM.VideoView.Video_Codec_SelectedItem)
                    //{
                    //    // x264
                    //    case "x264":
                    //        codec = "-x264-params ";
                    //        break;
                    //    // x265
                    //    case "x265":
                    //        codec = "-x265-params ";
                    //        break;
                    //        // All Other Codecs
                    //        //default:
                    //        //return string.Empty;
                    //}

                    // -------------------------
                    // 1 Param
                    // -------------------------
                    if (vParamsList.Count == 1)
                    {
                        // Always wrap in quotes
                        //vParams = codec + "\"" + string.Join("", vParamsList
                        //                               .Where(s => !string.IsNullOrEmpty(s)))
                        //                + "\"";
                        vParams = codec + MainWindow.WrapWithQuotes(string.Join("", vParamsList
                                                                                    .Where(s => !string.IsNullOrEmpty(s))
                                                                                )
                                                                    );
                    }

                    // -------------------------
                    // Multiple Params
                    // -------------------------
                    else if (vParamsList.Count > 1)
                    {
                        // Always wrap in quotes
                        // Linebreak beginning and end
                        //vParams = codec + "\"\r\n" + string.Join("\r\n:", vParamsList
                        //                                   .Where(s => !string.IsNullOrEmpty(s)))
                        //                + "\r\n\"";
                        vParams = codec + MainWindow.WrapWithQuotes("\r\n" +
                                                                    string.Join("\r\n:", vParamsList
                                                                                            .Where(s => !string.IsNullOrEmpty(s))
                                                                                ) +
                                                                    "\r\n"
                                                                    );
                    }

                    // -------------------------
                    // Unknown
                    // -------------------------
                    else
                    {
                        vParams = string.Empty;
                    }
                }
            }
            //MessageBox.Show(vParams); //debug

            // Return Value
            return vParams;
        }
    
    }
}
