
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using ViewModel;
using Axiom;
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Preview
{
    public class FFplay
    {
        // FFplay
        public static string ffplay { get; set; } // ffplay.exe

        /// <summary>
        /// Preview FFplay
        /// </summary>
        public static void Preview()
        {
            // -------------------------
            // Clear Variables before Run
            // -------------------------
            ffplay = string.Empty;
            MainWindow.ClearGlobalVariables();

            // Ignore if Batch
            if (VM.MainView.Batch_IsChecked == false)
            {
                // -------------------------
                // Set FFprobe Path
                // -------------------------
                MainWindow.FFplayPath();

                // -------------------------
                //  Arguments List
                // -------------------------
                List<string> FFplayArgsList = new List<string>()
                {
                    //ffplay,

                    "-i " + "\"" + MainWindow.InputPath("pass 1") + "\"",

                    //Video.VideoCodec(),
                    //Video.Speed(),
                    //Video.VideoQuality(),
                    Generate.Video.Video.FPS(VM.VideoView.Video_Codec_SelectedItem,
                                             VM.VideoView.Video_FPS_SelectedItem,
                                             VM.VideoView.Video_FPS_Text
                                            ),

                    Filters.Video.VideoFilter(),

                    Generate.Video.Video.Images(VM.FormatView.Format_MediaType_SelectedItem,
                                                VM.VideoView.Video_Codec_SelectedItem
                                               ),

                };


                // Join List with Spaces
                // Remove: Empty, Null, Standalone LineBreak
                string ffplayArgs = MainWindow.ReplaceLineBreaksWithSpaces(
                                            string.Join(" ", FFplayArgsList
                                                            .Where(s => !string.IsNullOrWhiteSpace(s))
                                                            .Where(s => !s.Equals(Environment.NewLine))
                                                            .Where(s => !s.Equals("\r\n\r\n"))
                                                            .Where(s => !s.Equals("\r\n"))
                                                            .Where(s => !s.Equals("\n"))
                                                            .Where(s => !s.Equals("\u2028"))
                                                            .Where(s => !s.Equals("\u000A"))
                                                            .Where(s => !s.Equals("\u000B"))
                                                            .Where(s => !s.Equals("\u000C"))
                                                            .Where(s => !s.Equals("\u000D"))
                                                            .Where(s => !s.Equals("\u0085"))
                                                            .Where(s => !s.Equals("\u2028"))
                                                            .Where(s => !s.Equals("\u2029"))
                                              )
                                            );
                //MessageBox.Show(ffplayArgs); //debug


                // Start FFplay
                System.Diagnostics.Process.Start(
                    ffplay,
                    //"/c " //always close cmd
                    //FFmpeg.KeepWindow(mainwindow)
                    ffplayArgs
                );
            }

            // Batch Warning
            else
            {
                MessageBox.Show("Cannot Preview Batch.",
                                "Notice",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

    }
}
