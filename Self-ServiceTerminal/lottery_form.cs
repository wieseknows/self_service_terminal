using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class lotteryCheck_form : Form
    {
        terminalMain_form terminal;
        private bool canWriteNumPad = true;
        List<string> winningTickets = new List<string>()
        {"1387567", "1488437", "8674935", "4564568", "4682817", "9999999", "6473738", "2310996", "9784735", "5275262"
        };

        List<int> wonMoney = new List<int>()
        {
            59800000, 350000, 12000000, 14000, 250000, 2500, 7000000, 12200, 605000, 100000
        };

        string lotteryNumber;

        public lotteryCheck_form()
        {
            InitializeComponent();
        }

        private void np1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X + 3, numPadButton.Location.Y + 3);
        }

        private void np1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X - 3, numPadButton.Location.Y - 3);
        }

        private void np1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                PictureBox numpadkeyPress = sender as PictureBox;
                lotteryNumber_textBox.Text += numpadkeyPress.Name[2];
            }
        }

        private void lotteryNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            if (lotteryNumber_textBox.Text.Length == 7)
            {
                canWriteNumPad = false;
                lotteryNumber_textBox.BackColor = Color.White;
                NumPad.Visible = false;
                this.BackgroundImage = Properties.Resources.lottery_form0;
                putLotteryNumber_label.Location = new Point(782, 65);
                lotteryNumber_textBox.Location = new Point(786, 91);
                buttonAccept.Location = new Point(786, 267);
                back_button.Location = new Point(786, 354);
            }
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (lotteryNumber_textBox.Text.Length >= 1)
            {
                lotteryNumber_textBox.Text = lotteryNumber_textBox.Text.Substring(0, lotteryNumber_textBox.Text.Length - 1);
                lotteryNumber_textBox.BackColor = Color.GreenYellow;
                canWriteNumPad = true;
            }
        }

        private void lotteryNumber_textBox_Click(object sender, EventArgs e)
        {
            lotteryNumber_textBox.BackColor = Color.GreenYellow;
            NumPad.Visible = true;
            this.BackgroundImage = Properties.Resources.lottery_form1;
            putLotteryNumber_label.Location = new Point(404, 65);
            lotteryNumber_textBox.Location = new Point(408, 91);
            buttonAccept.Location = new Point(408, 267);
            back_button.Location = new Point(408, 354);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (lotteryNumber_textBox.Text.Length == 7)
            {
                travolta tr = new travolta();
                lotteryNumber = lotteryNumber_textBox.Text;
                int wonIndex = 9999;
                wonIndex = winningTickets.IndexOf(lotteryNumber);

                if (wonIndex != (-1))
                {
                    tr.win = true;
                    tr.Show();
                    MessageBox.Show("Вы выиграли " + wonMoney[wonIndex] + " рублей!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tr.Close();
                    this.Close();
                }
                else
                {
                    tr.win = false;
                    tr.Show();
                    MessageBox.Show("К сожалению, вы ничего не выиграли...", "Наши соболезнования", MessageBoxButtons.OK, MessageBoxIcon.None);
                    tr.Close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Введите семизначный номер лоттереи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if (terminal.wayToPay == "cash")
            {
                terminal.currentCard_image.Visible = true;
                terminal.currentCard_image.Enabled = true;
                terminal.NextCardButton.Visible = true;
                terminal.NextCardButton.Enabled = true;
            }
            this.Close();
        }

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void lotteryCheck_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
        }
    }
}
