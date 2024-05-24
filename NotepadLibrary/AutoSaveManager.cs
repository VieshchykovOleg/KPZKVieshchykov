using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace NotepadLibrary
{
    public class AutoSaveManager
    {
        private static AutoSaveManager _instance;
        private System.Timers.Timer _autoSaveTimer;
        private RichTextBox _richTextBox;
        private string _autoSavePath;

        private AutoSaveManager() { }

        public static AutoSaveManager Instance => _instance ??= new AutoSaveManager();

        public void Initialize(RichTextBox richTextBox, int interval = 300000) // 5 minutes
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
            _autoSavePath = Path.Combine(Path.GetTempPath(), "autosave.txt");
            _autoSaveTimer = new System.Timers.Timer(interval);
            _autoSaveTimer.Elapsed += AutoSave;
            _autoSaveTimer.Start();
        }

        private void AutoSave(object sender, ElapsedEventArgs e)
        {
            File.WriteAllText(_autoSavePath, _richTextBox.Text);
        }

        public void StopAutoSave()
        {
            _autoSaveTimer.Stop();
        }

        public string AutoSavePath => _autoSavePath;
    }
}
