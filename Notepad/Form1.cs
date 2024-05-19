using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
using Microsoft.SqlServer.Server;

namespace Notepad
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] lines = text.Split('\n');
            Tekst.Text = text.Length.ToString();
            Simvol.Text = lines.Length.ToString();
        }
    }
}