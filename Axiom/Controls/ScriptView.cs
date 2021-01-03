using System;
using System.Windows.Documents;
using ViewModel;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Controls
{
    public class ScriptView
    {
        public static bool sort = false;

        /// <summary>
        /// Clear RichTextBox
        /// </summary>
        public static void ClearScriptView()
        {
            VM.MainView.ScriptView_Text = string.Empty;
        }

    }
}
