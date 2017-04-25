using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Self_ServiceTerminal
{
    public partial class moneyTransfer_form : Form
    {
        public bool FIOpayer = false;
        public bool FIOreciever = false;

        terminalMain_form terminal;
        public bool canWriteNumPadPayer = true;
        public bool canWriteNumPadReciever = true;
        public TextBox currUNP;

        public moneyTransfer_form()
        {
            InitializeComponent();
        }

        private void moneyTransfer_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;

            agreement_richtextbox.LoadFile("agreementMoneyTransfer.rtf");
            string[] lines = File.ReadAllLines("countries.txt", Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                countryReciever_combobox.Items.Add(lines[i]);
            }
        }

        private void back_button_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X + 3, numPadButton.Location.Y + 3);
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X - 3, numPadButton.Location.Y - 3);
        }

        private void iAgree_CheckedChanged(object sender, EventArgs e)
        {
            agreement_richtextbox.Visible = false;
            iAgree.Visible = false;
            workPanel.Visible = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void np1_Click(object sender, EventArgs e)
        {
            if (UPNpayer_textbox.Focused)
            {
                if (canWriteNumPadPayer)
                {
                    PictureBox numpadkeyPress = sender as PictureBox;
                    UPNpayer_textbox.Text += numpadkeyPress.Name[2];
                    UPNpayer_textbox.BackColor = Color.GreenYellow;

                    if (UPNpayer_textbox.Text.Length == 6)
                    {
                        canWriteNumPadPayer = false;
                        UPNpayer_textbox.BackColor = Color.White;
                    }
                }
            }
            if (UPNreciever_textbox.Focused)
            {
                if (canWriteNumPadReciever)
                {
                    PictureBox numpadkeyPress = sender as PictureBox;
                    UPNreciever_textbox.Text += numpadkeyPress.Name[2];
                    UPNreciever_textbox.BackColor = Color.GreenYellow;

                    if (UPNreciever_textbox.Text.Length == 6)
                    {
                        canWriteNumPadReciever = false;
                        UPNreciever_textbox.BackColor = Color.White;
                    }
                }
            }
        }

        private void FIOpayer_textbox_Click(object sender, EventArgs e)
        {
            //по клику на текстбоксы букв определяем для формы клавиатуры куда писать
            TextBox tb = sender as TextBox;
            if (tb.Name == "FIOpayer_textbox")
            {
                FIOpayer = true;
                FIOreciever = false;
                FIOpayer_textbox.BackColor = Color.GreenYellow;
            }

            if (tb.Name == "FIOreciever_textbox")
            {
                FIOpayer = false;
                FIOreciever = true;
                FIOreciever_textbox.BackColor = Color.GreenYellow;
            }

            //определяем связи
            terminal = this.Owner as terminalMain_form;
            //вызываем из терминала
            terminal.keyboard = new keyBoard_form();
            terminal.keyboard.Owner = terminal;
            terminal.keyboard.ShowDialog();
        }

        private void np1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numpadkey = sender as PictureBox;
            numpadkey.Location = new Point(numpadkey.Location.X + 2, numpadkey.Location.Y + 2);
        }

        private void np1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numpadkey = sender as PictureBox;
            numpadkey.Location = new Point(numpadkey.Location.X - 2, numpadkey.Location.Y - 2);
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if ((UPNpayer_textbox.Focused) && (UPNpayer_textbox.Text.Length >= 1))
            {
                UPNpayer_textbox.Text = UPNpayer_textbox.Text.Substring(0, UPNpayer_textbox.Text.Length - 1);
                UPNpayer_textbox.BackColor = Color.GreenYellow;
                canWriteNumPadPayer = true;
            }
            if ((UPNreciever_textbox.Focused) && (UPNreciever_textbox.Text.Length >= 1))
            {
                UPNreciever_textbox.Text = UPNreciever_textbox.Text.Substring(0, UPNreciever_textbox.Text.Length - 1);
                UPNreciever_textbox.BackColor = Color.GreenYellow;
                canWriteNumPadReciever = true;
            }
        }
        

        private void NumPadOK_Click(object sender, EventArgs e)
        {
            if ((FIOpayer_textbox.Text != "") && (FIOreciever_textbox.Text != "")
                && (UPNpayer_textbox.Text.Length == 6) && (UPNreciever_textbox.Text.Length == 6)
                && (countryReciever_combobox.Text != ""))
            {
                terminal = this.Owner as terminalMain_form;
                switch (terminal.wayToPay)
                {
                    case "cash":
                        {
                            terminal.cashPay = new cashPay_form();
                            terminal.cashPay.Owner = terminal;
                            terminal.cashPay.option1.Text = "Номер UPN отправителя: " + UPNpayer_textbox.Text;
                            terminal.cashPay.option2.Text = "Номер UPN получателя: " + UPNreciever_textbox.Text;
                            terminal.cashPay.option3.Text = "Получатель: " + FIOreciever_textbox.Text;
                            terminal.cashPay.option4.Text = "Страна: " + countryReciever_combobox.Text;

                            terminal.cashPay.UPNPayer = UPNpayer_textbox.Text;
                            terminal.cashPay.UPNReciever = UPNreciever_textbox.Text;
                            terminal.cashPay.payerFIO = FIOreciever_textbox.Text;

                            terminal.cashPay.Show();
                            this.Close();
                            break;
                        }
                    case "card":
                        {
                            terminal.cardPay = new cardPay_form();
                            terminal.cardPay.Owner = terminal;
                            terminal.cardPay.option1.Text = "Номер UPN отправителя: " + UPNpayer_textbox.Text;
                            terminal.cardPay.option2.Text = "Номер UPN получателя: " + UPNreciever_textbox.Text;
                            terminal.cardPay.option3.Text = "Получатель: " + FIOreciever_textbox.Text;
                            terminal.cardPay.option4.Text = "Страна: " + countryReciever_combobox.Text;

                            terminal.cardPay.UPNPayer = UPNpayer_textbox.Text;
                            terminal.cardPay.UPNReciever = UPNreciever_textbox.Text;
                            terminal.cardPay.payerFIO = FIOreciever_textbox.Text;

                            terminal.cardPay.Show();
                            this.Close();
                            break;
                        }
                }
            }
            else
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void moneyTransfer_form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void UPNpayer_textbox_Click(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Name == "UPNpayer_textbox")
                UPNpayer_textbox.BackColor = Color.GreenYellow;
            else
                UPNreciever_textbox.BackColor = Color.GreenYellow;
        }

        private void UPNpayer_textbox_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Name == "UPNpayer_textbox")
                UPNpayer_textbox.BackColor = Color.White;
            else
                UPNreciever_textbox.BackColor = Color.White;
        }
    }
}
