using System;
using System.Windows.Forms;

namespace SpeedReader
{
    internal static class Program
    {
        [STAThread]
        internal static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var parameters = ParseParameters(args);

            var form = new ReaderForm
            {
                TextToRead = parameters.text,
                WordsPerMinute = parameters.wordsPerMinute
            };


            Application.Run(form);
        }

        private static (string text, int wordsPerMinute) ParseParameters(string[] args)
        {
            const int defaultWordsPerMinute = 200;

            if (args != null && args.Length > 0)
            {
                if (args.Length == 1)
                {
                    return (args[0], defaultWordsPerMinute);
                }

                if (args.Length == 2)
                {
                    return (args[0], Convert.ToInt32(args[1]));
                }
            }

            return (string.Empty, defaultWordsPerMinute);
        }
    }
}
