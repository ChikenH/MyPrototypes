using System;
using System.Windows.Forms;

//namespace MyPrototype.CountdownTimer
namespace MyPrototype
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
            //Application.Run(new view.CountdownTimerForm());
            Application.Run(new CountdownTimer.view.CountdownTimerForm());
        }
    }
}
