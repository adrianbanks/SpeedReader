using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace SpeedReader
{
    public partial class ReaderForm : Form
    {
        private readonly BackgroundWorker worker;

        public string TextToRead
        {
            set => textBox.Text = value;
        }
        public int WordsPerMinute
        {
            set => speedBar.Value = value;
        }

        public ReaderForm()
        {
            InitializeComponent();
            wordTextBox.Text = string.Empty;

            Application.Idle += (sender, args) =>
            {
                wpmLabel.Text = speedBar.Value.ToString() + " wpm";
            };

            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };

            worker.DoWork += (s, args) =>
            {
                textBox.Enabled = false;
                readButton.Text = "Cancel";
                ReadWords(textBox.Text);
            };

            worker.ProgressChanged += (s, args) =>
            {
                wordTextBox.Text = (string) args.UserState;
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                wordTextBox.Text = string.Empty;
                textBox.Enabled = true;
                readButton.Text = "Read";
            };
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync();
            }
            else
            {
                worker.RunWorkerAsync(textBox.Text);
            }
        }

        private void ReadWords(string text)
        {
            var words = text.Split(new[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (worker.CancellationPending)
                {
                    return;
                }

                var sleep = GetSleepInterval();
                Thread.Sleep(sleep);
                worker.ReportProgress(0, word);
            }
        }

        private int GetSleepInterval()
        {
            return Convert.ToInt32(1000 * (60.0f / speedBar.Value));
        }
    }
}
