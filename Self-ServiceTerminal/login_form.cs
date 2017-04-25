using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class login_form : Form
    {
        bool blockCard = false;
        bool access = false;
        bool canWriteNumPad = true;
        byte tryes = 0;


        public login_form()
        {
            InitializeComponent();
        }

        private void NumPad1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numpadButton = sender as PictureBox;
            numpadButton.Location = new Point(numpadButton.Location.X + 2, numpadButton.Location.Y + 2);
        }

        private void NumPad1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numpadButton = sender as PictureBox;
            numpadButton.Location = new Point(numpadButton.Location.X - 2, numpadButton.Location.Y - 2);
        }

        private void NumPad1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                if (password_textbox.Text.Length == 3)
                    canWriteNumPad = false;

                PictureBox numpadkeyPress = sender as PictureBox;
                password_textbox.Text += numpadkeyPress.Name[2];
            }
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (password_textbox.Text.Length >= 1)
            {
                password_textbox.Text = password_textbox.Text.Substring(0, password_textbox.Text.Length - 1);
                canWriteNumPad = true;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            terminalMain_form term = this.Owner as terminalMain_form;
            switch (term.currentUser.cardNumber)
            {
                case "4255000064325688":
                    {
                        if (term.currentUser.cardPassword == this.password_textbox.Text)
                            access = true;
                        else
                        {
                            tryes++;
                            if (tryes == 5)
                            {
                                MessageBox.Show("Превышено максимальное количество попыток, ваша карта заблокирована. Для возврата карты обратитесь в соответствующее отделение банка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                term.validOwners[0].cardBlocked = true;
                                blockCard = true;
                                this.Close();
                            }
                            else
                                MessageBox.Show("Пароль неверный, у вас осталось " + (5 - tryes) + " попыток", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            password_textbox.Clear();
                            canWriteNumPad = true;
                        }
                        break;
                    }
                case "9423886512128645":
                    {
                        if (term.currentUser.cardPassword == this.password_textbox.Text)
                            access = true;
                        else
                        {
                            tryes++;
                            if (tryes == 5)
                            {
                                MessageBox.Show("Превышено максимальное количество попыток, ваша карта заблокирована. Для возврата карты обратитесь в соответствующее отделение банка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                term.validOwners[1].cardBlocked = true;
                                blockCard = true;
                                this.Close();
                            }
                            else
                                MessageBox.Show("Пароль неверный, у вас осталось " + (5 - tryes) + " попыток", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            password_textbox.Clear();
                            canWriteNumPad = true;
                        }
                        break;
                    }
                case "1387653200880043":
                    {
                        if (term.currentUser.cardPassword == this.password_textbox.Text)
                            access = true;
                        else
                        {
                            tryes++;
                            if (tryes == 5)
                            {
                                MessageBox.Show("Превышено максимальное количество попыток, ваша карта заблокирована. Для возврата карты обратитесь в соответствующее отделение банка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                term.validOwners[2].cardBlocked = true;
                                blockCard = true;
                                this.Close();
                            }
                            else
                                MessageBox.Show("Пароль неверный, у вас осталось " + (5 - tryes) + " попыток", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            password_textbox.Clear();
                            canWriteNumPad = true;
                        }
                        break;
                    }
            }
            if (access)
            {
                term.card_indicator.Image = Properties.Resources.cardActive;
                term.historyButton_pictureBox.Visible = true;
                term.balanceButton_pictureBox.Visible = true;
                term.giveCardBack_button.Visible = true;
                term.wayToPay = "card";

                this.Close();
            }

            if (blockCard)
            {
                term.wayToPay = "cash";
                term.currentCard_image.Visible = true;
                term.currentCard_image.Enabled = true;
                term.NextCardButton.Visible = true;
                term.NextCardButton.Enabled = true;
                term.giveCardBack_button.Visible = false;
                term.balanceButton_pictureBox.Visible = false;
                term.historyButton_pictureBox.Visible = false;
                term.currentUser = null;

                this.Close();
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (password_textbox.Text.Length == 4)
            {
                login_button.Image = Properties.Resources.ButtonLogin1;
                login_button.Enabled = true;
            } else
            {
                login_button.Image = Properties.Resources.login_button;
                login_button.Enabled = false;
            }
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
            terminalMain_form term = this.Owner as terminalMain_form;

            term.wayToPay = "cash";
            term.currentCard_image.Visible = true;
            term.currentCard_image.Enabled = true;
            term.NextCardButton.Visible = true;
            term.NextCardButton.Enabled = true;
            term.giveCardBack_button.Visible = false;
            term.balanceButton_pictureBox.Visible = false;
            term.historyButton_pictureBox.Visible = false;
            term.currentUser = null;

            this.Close();
        }
    }
}
