using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class operationWebmoney_form : Form
    {
        public bool canWriteNumPad = true;
        string currentWM = "WMB";
        int currency = 1;

        terminalMain_form terminal;

        public operationWebmoney_form()
        {
            InitializeComponent();
        }

        private void operationWebmoney_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;

            if ((terminal.wayToPay == "card") 
                && (terminal.currentUser.lastWebmoneyPurse != "")
                && (terminal.currentUser.lastWebmoneyPurse != null))
            {
                if (MessageBox.Show("Желаете использовать данные сохраненного вами кошелька WebMoney?\nНомер кошелька: " + terminal.currentUser.lastWebmoneyPurse, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (terminal.currentUser.lastWebmoneyPurse[0] == 'B')
                    {
                        currentWM = "WMB";
                        currency = 1;
                        WMB_radioButton.Checked = true;
                    }
                    if (terminal.currentUser.lastWebmoneyPurse[0] == 'Z')
                    {
                        currentWM = "WMZ";
                        currency = 20327;
                        WMZ_radioButton.Checked = true;
                    }
                    if (terminal.currentUser.lastWebmoneyPurse[0] == 'E')
                    {
                        currentWM = "WME";
                        currency = 23471;
                        WME_radioButton.Checked = true;
                    }

                    canWriteNumPad = false;
                    purse_textbox.Text = terminal.currentUser.lastWebmoneyPurse;
                }
            }

            purse_textbox.Focus();
        }

        private void np1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numpadButton = sender as PictureBox;
            numpadButton.Location = new Point(numpadButton.Location.X + 2, numpadButton.Location.Y + 2);
        }

        private void np1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numpadButton = sender as PictureBox;
            numpadButton.Location = new Point(numpadButton.Location.X - 2, numpadButton.Location.Y - 2);
        }

        private void np1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                PictureBox numpadkeyPress = sender as PictureBox;
                purse_textbox.Text += numpadkeyPress.Name[2];
                purse_textbox.BackColor = Color.GreenYellow;
            }

            if (purse_textbox.Text.Length == 13)
            {
                canWriteNumPad = false;
                purse_textbox.BackColor = Color.White;
                NumPad.Visible = false;
            }
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (purse_textbox.Text.Length >= 2)
            {
                purse_textbox.Text = purse_textbox.Text.Substring(0, purse_textbox.Text.Length - 1);
                purse_textbox.BackColor = Color.GreenYellow;
                canWriteNumPad = true;
            }
        }

        private void WMB_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Text)
            {
                case "WMB":
                    {
                        currentWM = "WMB";
                        currency = 1;
                        purse_textbox.Text = "B";
                        break;
                    }
                case "WMZ":
                    {
                        currentWM = "WMZ";
                        currency = 20327;
                        purse_textbox.Text = "Z";
                        break;
                    }
                case "WME":
                    {
                        currentWM = "WME";
                        currency = 23471;
                        purse_textbox.Text = "E";
                        break;
                    }
            }
            canWriteNumPad = true;
            purse_textbox.BackColor = Color.White;
        }
        

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if ((purse_textbox.Text.Length == 13))
            {
                terminal = this.Owner as terminalMain_form;
                switch (terminal.wayToPay)
                {
                    case "cash":
                        {
                            terminal.cashPay = new cashPay_form();
                            terminal.cashPay.Owner = terminal;
                            terminal.cashPay.operationName_label.Text = "Валюта перевода: " + currentWM;
                            terminal.cashPay.option1.Text = "Номер кошелька Webmoney: " + purse_textbox.Text;
                            if (description_textBox.Text != "")
                                terminal.cashPay.option2.Text = "Описание платежа: " + description_textBox.Text;
                            terminal.cashPay.currency = this.currency;
                            terminal.cashPay.currentWM = this.currentWM;

                            terminal.cashPay.purseNumber = purse_textbox.Text;

                            this.Close();
                            terminal.cashPay.Show();

                            break;
                        }
                    case "card":
                        {
                            terminal.cardPay = new cardPay_form();
                            terminal.cardPay.Owner = terminal;
                            terminal.cardPay.option1.Text = "Валюта перевода: " + currentWM;
                            terminal.cardPay.option2.Text = "Номер кошелька Webmoney: " + purse_textbox.Text;
                            if (description_textBox.Text != "")
                                terminal.cardPay.option3.Text = "Описание платежа: " + description_textBox.Text;
                            terminal.cardPay.currency = this.currency;
                            terminal.cardPay.currentWM = currentWM;

                            terminal.cardPay.purseNumber = purse_textbox.Text;

                            this.Close();
                            terminal.cardPay.Show();
                            break;
                        }

                }
            }
            else
                MessageBox.Show("Введите тринадцатизначный номер кошелька!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void description_textBox_Click(object sender, EventArgs e)
        {
            description_textBox.BackColor = Color.GreenYellow;
            NumPad.Visible = false;
            //определяем связи
            terminal = this.Owner as terminalMain_form;
            //вызываем из терминала
            terminal.keyboard = new keyBoard_form();
            terminal.keyboard.Owner = terminal;
            terminal.keyboard.ShowDialog();
        }
        

        private void purse_textbox_Click(object sender, EventArgs e)
        {
            purse_textbox.BackColor = Color.GreenYellow;
            NumPad.Visible = true;
        }

        private void operationWebmoney_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if (terminal.wayToPay == "cash")
            {
                terminal.currentCard_image.Visible = true;
                terminal.currentCard_image.Enabled = true;
                terminal.NextCardButton.Visible = true;
                terminal.NextCardButton.Enabled = true;
            }
        }

        private void purse_textbox_Leave(object sender, EventArgs e)
        {
            purse_textbox.BackColor = Color.White;
        }
    }
}
