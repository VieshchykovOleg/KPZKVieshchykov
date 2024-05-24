using System;
using System.Windows.Forms;

namespace NotepadLibrary
{
    public class TextEditor
    {
        private TextBoxBase _textbox;

        public TextEditor(TextBoxBase textbox)
        {
            _textbox = textbox ?? throw new ArgumentNullException(nameof(textbox));
        }

        public void Undo() => _textbox.Undo();

        public void Cut() => _textbox.Cut();

        public void Copy() => _textbox.Copy();

        public void Paste() => _textbox.Paste();

        public void Delete() => _textbox.SelectedText = string.Empty;

        public void SelectAll() => _textbox.SelectAll();

        public void ReplaceText(string searchText, string replaceText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("Search text cannot be null or empty.", nameof(searchText));
            }

            int index = FindText(searchText);
            if (index != -1)
            {
                _textbox.Select(index, searchText.Length);
                _textbox.SelectedText = replaceText;
            }
            else
            {
                MessageBox.Show("Text not found.", "Replace");
            }
        }

        public void Search(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("Search text cannot be null or empty.", nameof(searchText));
            }

            int index = FindText(searchText);
            if (index != -1)
            {
                _textbox.Select(index, searchText.Length);
                _textbox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Text not found.", "Search");
            }
        }

        public void SearchNext(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("Search text cannot be null or empty.", nameof(searchText));
            }

            int currentPosition = _textbox.SelectionStart + _textbox.SelectionLength;
            int index = _textbox.Text.IndexOf(searchText, currentPosition, StringComparison.CurrentCultureIgnoreCase);

            if (index != -1)
            {
                _textbox.Select(index, searchText.Length);
                _textbox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Text not found.", "Search Next");
            }
        }

        public void SearchPrevious(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("Search text cannot be null or empty.", nameof(searchText));
            }

            int currentPosition = _textbox.SelectionStart - 1;
            int index = _textbox.Text.LastIndexOf(searchText, currentPosition, StringComparison.CurrentCultureIgnoreCase);

            if (index != -1)
            {
                _textbox.Select(index, searchText.Length);
                _textbox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Text not found.", "Search Previous");
            }
        }

        public void InsertDateTime() => _textbox.AppendText(DateTime.Now.ToString());

        private int FindText(string searchText)
        {
            return _textbox.Text.IndexOf(searchText, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
