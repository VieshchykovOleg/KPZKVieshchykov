using System;
using System.Windows.Forms;

namespace NotepadLibrary
{
    public class AppearanceManager
    {
        private float _zoomFactor = 1f; // Початковий масштаб 100%
        private readonly RichTextBox _richTextBox;

        public AppearanceManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        public void IncreaseZoom()
        {
            _zoomFactor += 0.5f; // Збільшуємо масштаб на 150% (0.5 = 50%)
            _richTextBox.ZoomFactor = _zoomFactor;
        }

        public void DecreaseZoom()
        {
            if (_zoomFactor > 0.5f)
            {
                _zoomFactor -= 0.5f; // Зменшуємо масштаб на 50%
                _richTextBox.ZoomFactor = _zoomFactor;
            }
        }

        public void RestoreZoom()
        {
            _zoomFactor = 1f; // Відновлюємо початковий масштаб 100%
            _richTextBox.ZoomFactor = _zoomFactor;
        }

        public void ShowStatusBar(Form form, Panel panel)
        {
            panel.Visible = true;
            if (!form.Controls.Contains(panel))
            {
                form.Controls.Add(panel);
            }
        }

        public void HideStatusBar(Panel panel)
        {
            panel.Visible = false;
        }
    }
}
