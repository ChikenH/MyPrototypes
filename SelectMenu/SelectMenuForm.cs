using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPrototype.SelectMenu
{
    public partial class SelectMenuForm : Form
    {
        public SelectMenuForm()
        {
            InitializeComponent();
        }

        private async void RunPomodoroButton_Click(object sender, EventArgs e)
        {
            // FixMe: Correct code as exception occurs on second run.
            await Task.Run(() =>
            {
                Application.Run(new MyPrototype.CountdownTimer.view.CountdownTimerForm());
            });

        }
    }
}
