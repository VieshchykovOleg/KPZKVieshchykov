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
        private CommandManager _commandManager;
        private AutoSaveManager _autoSaveManager;

        private string _previousText;

        public Form1()
        {
            InitializeComponent();
            InitializeManagers();
            _autoSaveManager = AutoSaveManager.Instance;
            _autoSaveManager.Initialize(richTextBox1); 
        }

        private void InitializeManagers()
        {
            if (richTextBox1 != null && menuStrip1 != null)
            {
                _fileManager = new FileManager(richTextBox1);
                _textEditor = new TextEditor(richTextBox1);
                _textFormatter = new TextFormatter(richTextBox1, menuStrip1);
                _appearanceManager = new AppearanceManager(richTextBox1);
                _commandManager = new CommandManager(richTextBox1);

                AutoSaveManager.Instance.Initialize(richTextBox1);
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

            _commandManager.ExecuteCommand(new TextChangeCommand(richTextBox1, _previousText, text));
            _previousText = text;
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
            _commandManager.Undo();
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
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("   :", "");
            string replaceText = Microsoft.VisualBasic.Interaction.InputBox("  :", "");

            if (!string.IsNullOrEmpty(searchText))
            {
                _textEditor.ReplaceText(searchText, replaceText);
            }

        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст для пошуку:", "Пошук");
            if (!string.IsNullOrEmpty(searchText))
            {
                _textEditor?.Search(searchText);
            }
        }

        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст для пошуку наступного збігу:", "Пошук наступного");
            if (!string.IsNullOrEmpty(searchText))
            {
                _textEditor?.SearchNext(searchText);
            }
        }

        private void FindPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст для пошуку попереднього збігу:", "Пошук попереднього");
            if (!string.IsNullOrEmpty(searchText))
            {
                _textEditor?.SearchPrevious(searchText);
            }
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textEditor.InsertDateTime();
        }
        // Використання класу Format

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
        //використання класу Certificate
        Certificate certificate = new Certificate();
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certificate.OpenHelpUrl();
        }

        private void SendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certificate.OpenResponse();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForProgram newForm = new ForProgram();
            newForm.Show();
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoSaveManager != null)
            {
                _autoSaveManager.Initialize(richTextBox1);
            }
            else
            {
                MessageBox.Show("AutoSaveManager is not initialized.");
            }
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoSaveManager != null)
            {
                _autoSaveManager.StopAutoSave();
            }
            else
            {
                MessageBox.Show("AutoSaveManager is not initialized.");
            }
        }

        private void RecoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoSaveManager != null && File.Exists(_autoSaveManager.AutoSavePath))
            {
                richTextBox1.Text = File.ReadAllText(_autoSaveManager.AutoSavePath);
            }
            else if (_autoSaveManager == null)
            {
                MessageBox.Show("AutoSaveManager is not initialized.");
            }
            else
            {
                MessageBox.Show("No autosave file found.");
            }
        }
    }
}