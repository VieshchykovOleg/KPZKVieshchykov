using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NotepadLibrary
{
    public class FileManager
    {
        private string _currentFilePath;
        private bool _isTextChanged = false;
        private RichTextBox _richTextBox;

        public FileManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
        }

        public void CreateNewFile()
        {
            _richTextBox.Clear();
            _currentFilePath = null;
            _isTextChanged = false;
        }

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentFilePath = openFileDialog.FileName;
                    _richTextBox.Text = File.ReadAllText(_currentFilePath);
                    _isTextChanged = false;
                }
            }
        }

        public void SaveFile()
        {
            if (string.IsNullOrEmpty(_currentFilePath))
            {
                SaveFileAs();
            }
            else
            {
                File.WriteAllText(_currentFilePath, _richTextBox.Text);
                _isTextChanged = false;
            }
        }

        public void SaveFileAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "all (*.*)|*.*" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(_currentFilePath, _richTextBox.Text);
                    _isTextChanged = false;
                }
            }
        }

        public void PageSetup()
        {
            using (PageSetupDialog pageSetupDialog = new PageSetupDialog())
            {
                pageSetupDialog.PageSettings = new PageSettings();
                pageSetupDialog.PrinterSettings = new PrinterSettings();
                pageSetupDialog.ShowDialog();
            }
        }

        public void Print()
        {
            using (PrintDialog printDialog = new PrintDialog { Document = new PrintDocument() })
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }
            }
        }
    }
}
