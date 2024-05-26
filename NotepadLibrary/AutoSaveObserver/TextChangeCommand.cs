using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadLibrary.AutoSaveObserver
{
    public class TextChangeCommand : ICommand
    {
        private readonly RichTextBox _richTextBox;
        private readonly string _newText;
        private readonly string _oldText;

        public TextChangeCommand(RichTextBox richTextBox, string oldText, string newText)
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
            _oldText = oldText;
            _newText = newText;
        }

        public void Execute()
        {
            _richTextBox.Text = _newText;
        }

        public void Undo()
        {
            _richTextBox.Text = _oldText;
        }
    }
}
