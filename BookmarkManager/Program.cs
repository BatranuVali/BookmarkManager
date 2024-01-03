using BoomarkManager;
using System;
using System.Windows.Forms;

namespace BookmarkManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Alphabetical mainForm = new Alphabetical();
            Tags tagsForm = new Tags();

            Application.Run(mainForm);

            Application.ApplicationExit += (sender, e) =>
            {
                mainForm.Close();
                tagsForm.Close();
            };
        }
    }
}