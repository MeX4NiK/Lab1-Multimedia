
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;
using ViewModel;
using Axiom;
using System.Collections;
using System.Threading.Tasks;
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Encode
{
    public partial class FFmpeg
    {
        /// <summary>
        /// FFmpeg Start
        /// </summary>
        public static async Task<int> FFmpegStartAsync(string args)
        {
            int count = 0;
            await Task.Run(() =>
            {
                FFmpegStart(args);
            });

            return count;
        }
        public static void FFmpegStart(string args)
        {

            switch (VM.ConfigureView.Shell_SelectedItem)
            {

                case "CMD":
                    System.Diagnostics.Process.Start(
                        "cmd.exe",
                        Sys.Shell.KeepWindow() +
                        // Do not use WrapWithQuotes() Method on outputDir
                        "cd " + "\"" + MainWindow.outputDir + "\"" +
                        " & " +
                        args
                    );
                    break;

                case "PowerShell":
                    System.Diagnostics.Process.Start(
                        "powershell.exe",
                        Sys.Shell.KeepWindow() +
                        // Do not use WrapWithQuotes() Method on outputDir
                        "-command \"Set-Location " + "\"" + MainWindow.outputDir.Replace("\\", "\\\\") // Format Backslashes for PowerShell \ → \\
                                                                                .Replace("\"", "\\\"") + // Format Quotes " → \"
                                                    "\"" +
                        "; " +
                        args.Replace("\"", "\\\"") // Format Quotes " → \"
                    );
                    break;
            }
        }


        /// <summary>
        /// FFmpeg Convert
        /// </summary>
        //public static async Task<int> FFmpegConvertAsync()
        //{
        //    int count = 0;
        //    await Task.Run(() =>
        //    {
        //        FFmpegConvert();
        //    });

        //    return count;
        //}
        //public async static void FFmpegConvert()
        //{
        //    Log.WriteAction = () =>
        //    {
        //        Log.logParagraph.Inlines.Add(new LineBreak());
        //        Log.logParagraph.Inlines.Add(new LineBreak());
        //        Log.logParagraph.Inlines.Add(new Bold(new Run("Converting...")) { Foreground = Log.ConsoleAction });
        //    };
        //    Log.LogActions.Add(Log.WriteAction);

        //    // -------------------------
        //    // Generate Controls Script
        //    // -------------------------
        //    // Inline
        //    // FFmpegArgs → ScriptView
        //    //Generate.FFmpeg.FFmpegGenerateScript();
        //    Task<int> script = Generate.FFmpeg.FFmpegGenerateScriptAsync();
        //    int count1 = await script;

        //    // -------------------------
        //    // Start FFmpeg
        //    // -------------------------
        //    // ScriptView → CMD/PowerShell
        //    //FFmpegStart(MainWindow.ReplaceLineBreaksWithSpaces(VM.MainView.ScriptView_Text));
        //    //Task.Run(() => FFmpegStart(MainWindow.ReplaceLineBreaksWithSpaces(VM.MainView.ScriptView_Text)));
        //    Task<int> start = FFmpegStartAsync(MainWindow.ReplaceLineBreaksWithSpaces(VM.MainView.ScriptView_Text));
        //    int count2 = await start;
        //}

    }
}
