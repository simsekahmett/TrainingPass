using System;
using System.Windows.Forms;

namespace TrainingPass.Helpers
{
    public class Logger : Form1
    {
        private Form1 form;

        public Logger(Form1 _form)
        {
            form = _form;
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        public void Log(string log)
        {
            string formattedLog = FormatLogString(log) + Environment.NewLine;
            this.form.richTextBox1.Text += formattedLog;

            enAltaScroll(this.form.richTextBox1);
        }

        public void ExceptionLog(string log)
        {
            string formattedLog = FormatExceptionLogString(log) + Environment.NewLine;
            this.form.richTextBox1.Text += formattedLog;

            enAltaScroll(this.form.richTextBox1);
        }

        public string FormatLogString(string log)
        {
            string tarihSaat = "[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            return tarihSaat + "] ---- " + log;
        }

        public string FormatExceptionLogString(string log)
        {
            return "[**HATA**] ---- " + log;
        }

        private void enAltaScroll(RichTextBox richTextBox)
        {
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();
        }
    }
}
