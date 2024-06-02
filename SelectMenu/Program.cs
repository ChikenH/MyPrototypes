using System;
using System.Windows.Forms;

namespace MyPrototype.SelectMenu
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new SelectMenuForm());
#else
            Application.Run(new MyPrototype.CountdownTimer.view.CountdownTimerForm());
#endif
        }
    }
}
