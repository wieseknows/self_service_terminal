using System;
using System.Windows.Forms;
using System.Threading;

namespace Self_ServiceTerminal
{
    public partial class charityThanks_form : Form
    {
        public charityThanks_form()
        {
            InitializeComponent();
        }

        private void charityThanks_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
                Thread.Sleep(3000);
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                this.Close();
            }
        }
    }
}
