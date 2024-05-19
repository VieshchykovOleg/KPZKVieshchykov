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

        public Form1()
        {
            InitializeComponent();
            _fileManager = new FileManager(richTextBox1);
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

        private void PageSetupÑòîð³íêèToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}