using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NotepadLibrary
{
    public class TextSearchManager
    {
        private readonly RichTextBox _richTextBox;

        public TextSearchManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
        }

        public void Replace()
        {
            string searchText = Interaction.InputBox("Enter search text:", "Replace");
            string replaceText = Interaction.InputBox("Enter replacement text:", "Replace");
            if (!string.IsNullOrEmpty(searchText))
            {
                _richTextBox.SelectedText = _richTextBox.SelectedText.Replace(searchText, replaceText);
            }
        }

        public void Find()
        {
            string searchText = Interaction.InputBox("Enter text to find:", "Search");
            if (!string.IsNullOrEmpty(searchText))
            {
                _richTextBox?.Find(searchText);
            }
        }

        public void FindNext()
        {
            string searchText = Interaction.InputBox("Enter text to find:", "Search Next");
            if (!string.IsNullOrEmpty(searchText))
            {
                _richTextBox?.Find(searchText);
            }
        }

        public void FindPrevious()
        {
            string searchText = Interaction.InputBox("Enter text to find:", "Search Previous");
            if (!string.IsNullOrEmpty(searchText))
            {
                _richTextBox?.Find(searchText, RichTextBoxFinds.Reverse);
            }
        }
    }
}
