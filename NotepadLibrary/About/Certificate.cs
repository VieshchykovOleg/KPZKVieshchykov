﻿using System.Diagnostics;

namespace NotepadLibrary.About
{
    public class Certificate
    {
        public void OpenHelpUrl()
        {
            string url = "https://support.microsoft.com/uk-ua/windows/%D0%B4%D0%BE%D0%B2%D1%96%D0%B4%D0%BA%D0%B0-%D1%83-%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D1%96-%D0%B1%D0%BB%D0%BE%D0%BA%D0%BD%D0%BE%D1%82-4d68c388-2ff2-0e7f-b706-35fb2ab88a8c#:~:text=%D0%94%D0%BE%D0%B2%D1%96%D0%B4%D0%BA%D0%B0%20%D1%83%20%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D1%96%20%22%D0%91%D0%BB%D0%BE%D0%BA%D0%BD%D0%BE%D1%82%22%20-%20%D0%9F%D1%96%D0%B4%D1%82%D1%80%D0%B8%D0%BC%D0%BA%D0%B0%20%D0%B2%D1%96%D0%B4%20Microsoft,Windows%2010%20Windows%208.1%20Windows%207%20Windows%2011.";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        public void OpenResponse()
        {
            string url = "https://support.microsoft.com/uk-ua/windows/%D0%BD%D0%B0%D0%B4%D1%81%D0%B8%D0%BB%D0%B0%D0%BD%D0%BD%D1%8F-%D0%B2%D1%96%D0%B4%D0%B3%D1%83%D0%BA%D1%96%D0%B2-%D0%B4%D0%BE-%D0%BA%D0%BE%D1%80%D0%BF%D0%BE%D1%80%D0%B0%D1%86%D1%96%D1%97-%D0%BC%D0%B0%D0%B9%D0%BA%D1%80%D0%BE%D1%81%D0%BE%D1%84%D1%82-%D0%B7%D0%B0-%D0%B4%D0%BE%D0%BF%D0%BE%D0%BC%D0%BE%D0%B3%D0%BE%D1%8E-%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8-%D1%86%D0%B5%D0%BD%D1%82%D1%80-%D0%B2%D1%96%D0%B4%D0%B3%D1%83%D0%BA%D1%96%D0%B2-f59187f8-8739-22d6-ba93-f66612949332";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
