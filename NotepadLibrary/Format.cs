using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadLibrary
{
    public class TextFormatter
    {
        private RichTextBox _richTextBox;
        private MenuStrip _menuStrip;

        public TextFormatter(RichTextBox richTextBox, MenuStrip menuStrip)
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
            _menuStrip = menuStrip ?? throw new ArgumentNullException(nameof(menuStrip));
        }

        public void SetFont()
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    _richTextBox.Font = fontDialog.Font;
                }
            }
        }

        public void SetTheme(Color foreColor, Color backColor, Color menuBackColor)
        {
            _richTextBox.ForeColor = foreColor;
            _richTextBox.BackColor = backColor;
            _menuStrip.BackColor = menuBackColor;
        }

        public void SetLightTheme()
        {
            SetTheme(Color.Green, Color.White, Color.SeaShell);
        }

        public void SetDarkTheme()
        {
            SetTheme(Color.White, Color.DimGray, Color.DarkGray);
        }

        public void EnableWordWrap()
        {
            SetWordWrap(true);
        }

        public void DisableWordWrap()
        {
            SetWordWrap(false);
        }

        private void SetWordWrap(bool enable)
        {
            _richTextBox.WordWrap = enable;
        }
    }
}
