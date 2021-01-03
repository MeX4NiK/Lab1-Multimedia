using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;
using Axiom;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Generate.Video
{
    public class Codec
    {
        public static string vCodec { get; set; } // Video Codec

        /// <summary>
        /// Video Codec
        /// <summary>
        public static String VideoCodec(string hwAccel_transcode_SelectedItem,
                                        string codec_SelectedItem,
                                        string codec_Command
                                        )
        {
            // Passed Command
            if (codec_SelectedItem != "None")
            {
                vCodec = codec_Command;
            }

            // Log Console Message /////////
            Log.WriteAction = () =>
            {
                Log.logParagraph.Inlines.Add(new LineBreak());
                Log.logParagraph.Inlines.Add(new Bold(new Run("Codec: ")) { Foreground = Log.ConsoleDefault });
                Log.logParagraph.Inlines.Add(new Run(codec_Command) { Foreground = Log.ConsoleDefault });
            };
            Log.LogActions.Add(Log.WriteAction);

            //MessageBox.Show(vCodec); //debug

            return vCodec;
        }
    }
}
