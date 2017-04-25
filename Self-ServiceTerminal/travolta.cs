using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Self_ServiceTerminal
{
    public partial class travolta : Form
    {
        public bool win;

        public travolta()
        {
            InitializeComponent();
        }

        private void travolta_Load(object sender, EventArgs e)
        {
            if (win)
                emotion.Image = Properties.Resources.WIN;
            else
                emotion.Image = Properties.Resources.LOSE;
        }
    }
}
