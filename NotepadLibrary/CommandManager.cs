using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NotepadLibrary
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _undoStack = new Stack<ICommand>();
        private readonly Stack<ICommand> _redoStack = new Stack<ICommand>();
        private readonly RichTextBox _richTextBox;

        public CommandManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox ?? throw new ArgumentNullException(nameof(richTextBox));
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                ICommand command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                ICommand command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
        }
    }

    public interface ICommand
    {
        void Execute();
        void Undo();
    }

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
