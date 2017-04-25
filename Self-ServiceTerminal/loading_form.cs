using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class loading_form : Form
    {
        public loading_form()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            this.Location = new Point(this.Location.X - 30, this.Location.Y - 30);
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + 300, this.Location.Y + 300);
        }
    }
}
