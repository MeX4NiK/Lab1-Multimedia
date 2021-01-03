using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using ViewModel;
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Axiom
{
    public class Log
    {
        // --------------------------------------------------------------------------------------------------------
        // Variables
        // --------------------------------------------------------------------------------------------------------
        // List of Actions
        public static List<Action> LogActions = new List<Action>();
        // Action
        public static Action WriteAction { get; set; }
        // Rich Textbox Paragraph
        public static Paragraph logParagraph = new Paragraph(); //RichTextBox

        //public static string logDir = MainWindow.appDataLocalDir + @"Axiom UI\";

        // axiom.log Directories
        public readonly static string logAppRootDir = MainWindow.appRootDir;
        public readonly static string logAppDataLocalDir = MainWindow.appDataLocalDir + @"Axiom UI\";
        public readonly static string logAppDataRoamingDir = MainWindow.appDataRoamingDir + @"Axiom UI\";

        // axoim.log Full File Paths
        public readonly static string logAppRootFilePath = Path.Combine(logAppRootDir, "axiom.log");
        public readonly static string logAppDataLocalFilePath = Path.Combine(logAppDataLocalDir, "axiom.log");
        public readonly static string logAppDataRoamingFilePath = Path.Combine(logAppDataRoamingDir, "axiom.log");

        public static string axiomLogDir { get; set; } // Global directory
        public static string axiomLogFile { get; set; } // Global directory+filename

        public static Brush ConsoleDefault { get; set; } // Default
        public static Brush ConsoleTitle { get; set; } // Titles
        public static Brush ConsoleWarning { get; set; } // Warning
        public static Brush ConsoleError { get; set; } // Error
        public static Brush ConsoleAction { get; set; } // Actions


        public static void CreateOutputLog(MainWindow mainwindow)
        {
            // -------------------------
            // Background Thread Worker
            // -------------------------
            BackgroundWorker bwlog = new BackgroundWorker();

            bwlog.WorkerSupportsCancellation = true;

            // This allows the worker to report progress during work
            bwlog.WorkerReportsProgress = true;

            // What to do in the background thread
            bwlog.DoWork += new DoWorkEventHandler(delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // Dispatcher Allows Cross-Thread Communication
                mainwindow.Dispatcher.Invoke(() =>
                {
                    // Log Path
                    if (VM.ConfigureView.LogCheckBox_IsChecked == true) // Only if Log is Enabled through Configure Checkbox
                    {
                        // Start write output log file
                        //Catch Directory Access Errors
                        try
                        {
                            TextRange t = new TextRange(mainwindow.logconsole.rtbLog.Document.ContentStart,
                                                        mainwindow.logconsole.rtbLog.Document.ContentEnd);
                            FileStream file = new FileStream(VM.ConfigureView.LogPath_Text + "axiom.log", FileMode.Create);
                            t.Save(file, System.Windows.DataFormats.Text);
                            file.Close();
                        }
                        catch
                        {
                            // Log Console Message /////////
                            Log.WriteAction = () =>
                            {
                                Log.logParagraph.Inlines.Add(new LineBreak());
                                Log.logParagraph.Inlines.Add(new LineBreak());
                                Log.logParagraph.Inlines.Add(new Bold(new Run("Warning: Saving Output Log to " + "\"" + VM.ConfigureView.LogPath_Text + "\"" + " is Denied. May require Administrator Privileges.")) { Foreground = ConsoleWarning });
                            };
                            Log.LogActions.Add(Log.WriteAction);

                            // Popup Message Dialog Box
                            MessageBox.Show("Error Saving Output Log to " + "\"" + VM.ConfigureView.LogPath_Text + "\"" + ". May require Administrator Privileges.",
                                            "Error",
                                            MessageBoxButton.OK,
                                            MessageBoxImage.Warning);
                            // do not halt program
                        }
                    }

                }); //end dispatcher

            }); //end thread


            // -------------------------
            // When Background Worker Completes Task
            // -------------------------
            bwlog.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate (object o, RunWorkerCompletedEventArgs args)
            {
                // Close the Background Worker
                bwlog.CancelAsync();
                bwlog.Dispose();

            }); //end worker completed task

            bwlog.RunWorkerAsync();
        }


        /// <summary>
        /// Log Write All 
        /// </summary>
        public static void LogWriteAll(MainWindow mainwindow)
        {
            // -------------------------
            // Background Thread Worker
            // -------------------------
            BackgroundWorker bwlog = new BackgroundWorker();

            bwlog.WorkerSupportsCancellation = true;

            // This allows the worker to report progress during work
            bwlog.WorkerReportsProgress = true;

            // What to do in the background thread
            bwlog.DoWork += new DoWorkEventHandler(delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // Dispatcher Allows Cross-Thread Communication
                mainwindow.Dispatcher.Invoke(() =>
                {
                    // -------------------------
                    // Write All Log Actions to Console
                    // -------------------------  
                    mainwindow.logconsole.rtbLog.Document = new FlowDocument(logParagraph); // start
                    mainwindow.logconsole.rtbLog.BeginChange(); // begin change

                    foreach (Action Write in LogActions)
                    {
                        Write();
                    }

                    mainwindow.logconsole.rtbLog.EndChange(); // end change


                    // Clear
                    if (LogActions != null)
                    {
                        LogActions.Clear();
                        LogActions.TrimExcess();
                    }

                }); //end dispatcher
            }); //end thread


            // -------------------------
            // When Background Worker Completes Task
            // -------------------------
            bwlog.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate (object o, RunWorkerCompletedEventArgs args)
            {
                // Scroll Console to End
                mainwindow.logconsole.rtbLog.ScrollToEnd();

                // Close the Background Worker
                bwlog.CancelAsync();
                bwlog.Dispose();

            }); //end worker completed task

            bwlog.RunWorkerAsync();
        }

    }
}
