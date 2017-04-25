using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class cardOperation_form : Form
    {
        public bool ownCard = false;
        terminalMain_form terminal;
        private bool canWriteNumPad = true;

        public cardOperation_form()
        {
            InitializeComponent();
        }

        private void np1_Click(object sender, EventArgs e)
        {
            PictureBox numpadkeyPress = sender as PictureBox;
            if (canWriteNumPad)
            {
                cardNumber_textBox.BackColor = Color.GreenYellow;
                cardNumber_textBox.Text += numpadkeyPress.Name[2];
                if (cardNumber_textBox.Text.Length == 16)
                {
                    cardNumber_textBox.ReadOnly = true;
                    canWriteNumPad = false;
                    NumPad.Visible = false;
                    cardNumber_textBox.BackColor = Color.White;
                    return;
                }
            }
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

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void cardNumber_textBox_Click(object sender, EventArgs e)
        {
            cardNumber_textBox.BackColor = Color.GreenYellow;
            NumPad.Visible = true;
        }

        private void cardOperation_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
            if (terminal.wayToPay == "card")
            {
                cardOrCash_panel.Visible = true;
                cardOrCash_panel.BringToFront();
                cash_radioButton.Visible = true;
                card_radioButton.Visible = true;
            }
        }

        private void cancel_pictureBox_Click(object sender, EventArgs e)
        {
            ownCard = true;
            cardOrCash_panel.Visible = false;
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

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (cardNumber_textBox.Text.Length >= 1)
            {
                cardNumber_textBox.Text = cardNumber_textBox.Text.Substring(0, cardNumber_textBox.Text.Length - 1);
                canWriteNumPad = true;
            }
        }

        private void ok_pictureBox_Click(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.cashPay = new cashPay_form();
            terminal.cashPay.Owner = terminal;
            ownCard = true;

            terminal.cashPay.option1.Text = "Номер карты: " + terminal.currentUser.cardNumber;
            terminal.cashPay.option2.Text = "Владелец: " + terminal.currentUser.cardOwnerName;

            terminal.cashPay.cardNumber = terminal.currentUser.cardNumber;

            this.Close();
            terminal.cashPay.Show();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //Длина номера карты 16 символов
            if (cardNumber_textBox.Text.Length == 16)
            {
                terminal.cashPay = new cashPay_form();

                //Если то что ввел пользователь будет являться ЕГО ЖЕ номером карты
                if ((terminal.currentUser != null) && (terminal.currentUser.cardNumber == cardNumber_textBox.Text))
                    ownCard = true;

                if (cash_radioButton.Checked)
                {
                    terminal.cashPay.Owner = terminal;
                    terminal.cashPay.option1.Text = "Номер карты: " + cardNumber_textBox.Text;
                    if (ownCard)
                        terminal.cashPay.option2.Text = "Плательщик: " + terminal.currentUser.cardOwnerName;

                    terminal.cashPay.cardNumber = cardNumber_textBox.Text;

                    this.Close();
                    terminal.cashPay.Show();
                }
                else
                {
                    if (terminal.currentUser.cardNumber == cardNumber_textBox.Text)
                    {
                        MessageBox.Show("Невозможно пополнить баланс своей карты с помощью её же!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    terminal.cardPay = new cardPay_form();
                    terminal.cardPay.Owner = terminal;
                    terminal.cardPay.option2.Text = "Номер карты получателя: " + cardNumber_textBox.Text;

                    terminal.cardPay.cardNumber = cardNumber_textBox.Text;

                    this.Close();
                    terminal.cardPay.Show();
                }
            }
            else
                MessageBox.Show("Введите шестнадцатизначный номер карты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}