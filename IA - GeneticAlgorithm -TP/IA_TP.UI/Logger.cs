﻿using System.Windows.Forms;

namespace IA_TP.UI
{
    public class Logger
    {
        private ListBox listBox;

        public Logger(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void Log(string text)
        {
            listBox.Items.Add(text);
        }
    }
}
