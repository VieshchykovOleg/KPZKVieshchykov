using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
using Microsoft.SqlServer.Server;
using NotepadLibrary;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private FileManager _fileManager;
        private TextEditor _textEditor;
        private TextFormatter _textFormatter;
        private AppearanceManager _appearanceManager;
        public Form1()
        {
            InitializeComponent();
            InitializeManagers();
        }

        private void InitializeManagers()
        {
            if (richTextBox1 != null && menuStrip1 != null)
            {
                _fileManager = new FileManager(richTextBox1);
                _textEditor = new TextEditor(richTextBox1);
                _textFormatter = new TextFormatter(richTextBox1, menuStrip1);
                _appearanceManager = new AppearanceManager(richTextBox1);
            }
            else
            {
                MessageBox.Show("Initialization failed: Controls are not initialized properly.");
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] lines = text.Split('\n');
            Tekst.Text = text.Length.ToString();
            Simvol.Text = lines.Length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.CreateNewFile();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.SaveFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.SaveFileAs();
        }

        private void PageSetupСторінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.PageSetup();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileManager.Print();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
        // Використання класу Editing
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.Delete();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.SelectAll();
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "old text"; 
            string replaceText = "new text"; 
            _textEditor.ReplaceText(searchText, replaceText);
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "search text"; 
            _textEditor.Search(searchText);
        }

        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "search text"; 
            _textEditor.SearchNext(searchText);
        }

        private void FindPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "search text"; 
            _textEditor.SearchPrevious(searchText);
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.InsertDateTime();
        }
        // Використання класу Format
        private void InsertDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.InsertDateTime();
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textFormatter.SetFont();
        }

        private void LightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textFormatter.SetLightTheme();
        }

        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textFormatter.SetDarkTheme();
        }

        private void EnableWordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textFormatter.EnableWordWrap();
        }

        private void DisableWordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textFormatter.DisableWordWrap();
        }
        // Використання класу Appearance
        private void ZoonInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void StatusLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Enablestatus_barToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _appearanceManager.ShowStatusBar(this, panel1);
        }

        private void Disablestatus_barToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _appearanceManager.HideStatusBar(panel1);
        }

        private void ZoomInToolStripMenuItem2_Click(object sender, EventArgs e)
        {       
            _appearanceManager.IncreaseZoom();
        }
        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _appearanceManager.DecreaseZoom();
        }

        private void RestoreZoomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _appearanceManager.RestoreZoom();
        }
    }
}