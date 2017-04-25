using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class creditOperation_form : Form
    {
        bool canWriteNumPad = true;
        public terminalMain_form terminal;
        string currentBank = "";

        public creditOperation_form()
        {
            InitializeComponent();
        }

        private void belagroprombank_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "belarusbank":
                    {
                        currentBank = "Беларусбанк";
                        currentBank_image.Image = belarusbank.BackgroundImage;
                        break;
                    }
                case "belagroprombank":
                    {
                        currentBank = "Белагропромбанк";
                        currentBank_image.Image = belagroprombank.BackgroundImage;
                        break;
                    }
                case "vtbbank":
                    {
                        currentBank = "Банк-ВТБ";
                        currentBank_image.Image = vtbbank.BackgroundImage;
                        break;
                    }
                case "alfabank":
                    {
                        currentBank = "Альфа-Банк";
                        currentBank_image.Image = alfabank.BackgroundImage;
                        break;
                    }
                case "sberbank":
                    {
                        currentBank = "БПС-Сбербанк";
                        currentBank_image.Image = sberbank.BackgroundImage;
                        break;
                    }
            }
            currentBank_label.Text = currentBank;
            currentBank_label.Visible = true;

            currentBank_image.Visible = true;
            back_button.Location = new Point(245, 503);
            buttonAccept.Visible = true;

            belagroprombank.Dispose();
            belarusbank.Dispose();
            vtbbank.Dispose();
            alfabank.Dispose();
            sberbank.Dispose();

            branches_combobox.Visible = true;
            branches_label.Visible = true;
            numberOfCredit_label.Visible = true;
            numberOfCredit_textBox.Visible = true;

            this.BackgroundImage = Properties.Resources.credits1_2;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void back_button_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X + 3, numPadButton.Location.Y + 3);
        }

        private void back_button_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X - 3, numPadButton.Location.Y - 3);
        }

        private void creditOperation_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if ((terminal.wayToPay == "card")
                && (terminal.currentUser.lastBank != "")
                && (terminal.currentUser.lastBank != null)
                && (terminal.currentUser.lastBankBranch != "")
                && (terminal.currentUser.lastBankBranch != null)
                && (terminal.currentUser.lastCreditNumber != "")
                && (terminal.currentUser.lastCreditNumber != null))
            {
                if (MessageBox.Show("Желаете использовать сохранённые вами данные о кредите?\nНомер кредитного договора: " + terminal.currentUser.lastCreditNumber + "\nБанк: " + terminal.currentUser.lastBank + "\nФилиал: " + terminal.currentUser.lastBankBranch.Substring(3), "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    terminal.cardPay = new cardPay_form();
                    terminal.cardPay.Owner = terminal;
                    terminal.cardPay.option1.Text = "Банк: " + terminal.currentUser.lastBank;
                    terminal.cardPay.option2.Text = "Филиал банка: " + terminal.currentUser.lastBankBranch;
                    terminal.cardPay.option3.Text = "Номер кредитного договора: " + terminal.currentUser.lastCreditNumber;

                    terminal.cardPay.bank = terminal.currentUser.lastBank;
                    terminal.cardPay.contractNumber = terminal.currentUser.lastCreditNumber;
                    terminal.cardPay.bankBranch = terminal.currentUser.lastBankBranch;

                    this.Close();
                    terminal.cardPay.Show();
                }
            }

            branches_combobox.Items.Add("Ф: 139, ул. Гагарина 5");
            branches_combobox.Items.Add("Ф: 12, ул. Толбухина 14");
            branches_combobox.Items.Add("Ф: 251, ул. Ломоносова 99Б");
            branches_combobox.Items.Add("Ф: 122, ул. Пушкина 43");
            branches_combobox.Items.Add("Ф: 65, ул. Таймураза 55");
            branches_combobox.Items.Add("Ф: 42, ул. Суприм 213/3");
            branches_combobox.Items.Add("Ф: 57, ул. Милки-Вэй 7");
            branches_combobox.Items.Add("Ф: 96, ул. Петровская 93");
            branches_combobox.Items.Add("Ф: 101, ул. Женевская 44/2");
            branches_combobox.Items.Add("Ф: 20, ул. Барселоны 126");
            
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
        }

        private void creditOperation_form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void np1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                PictureBox numpadkeyPress = sender as PictureBox;
                numberOfCredit_textBox.Text += numpadkeyPress.Name[2];
                numberOfCredit_textBox.BackColor = Color.GreenYellow;
            }

            if (numberOfCredit_textBox.Text.Length == 6)
            {
                canWriteNumPad = false;
                numberOfCredit_textBox.BackColor = Color.White;
                NumPad.Visible = false;
            }
        }
        

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (numberOfCredit_textBox.Text.Length >= 1)
            {
                numberOfCredit_textBox.Text = numberOfCredit_textBox.Text.Substring(0, numberOfCredit_textBox.Text.Length - 1);
                numberOfCredit_textBox.BackColor = Color.GreenYellow;
                canWriteNumPad = true;
            }
        }

        private void numberOfCredit_textBox_Click(object sender, EventArgs e)
        {
            numberOfCredit_textBox.BackColor = Color.GreenYellow;
            NumPad.Visible = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if ((numberOfCredit_textBox.Text.Length == 6) && (branches_combobox.Text != ""))
            {
                terminal = this.Owner as terminalMain_form;
                switch (terminal.wayToPay)
                {
                    case "cash":
                        {
                            terminal.cashPay = new cashPay_form();
                            terminal.cashPay.Owner = terminal;

                            terminal.cashPay.operationName_label.Text = "Наименование операции: " + terminal.currentOperation;
                            terminal.cashPay.option1.Text = "Банк: " + currentBank;
                            terminal.cashPay.option2.Text = "Филиал банка: " + branches_combobox.Text;
                            terminal.cashPay.option3.Text = "Номер кредитного договора: " + numberOfCredit_textBox.Text;

                            terminal.cashPay.bank = currentBank;
                            terminal.cashPay.contractNumber = numberOfCredit_textBox.Text;

                            this.Close();
                            terminal.cashPay.Show();

                            break;
                        }
                    case "card":
                        {
                            terminal.cardPay = new cardPay_form();
                            terminal.cardPay.Owner = terminal;
                            terminal.cardPay.option1.Text = "Банк: " + currentBank;
                            terminal.cardPay.option2.Text = "Филиал банка: " + branches_combobox.Text;
                            terminal.cardPay.option3.Text = "Номер кредитного договора: " + numberOfCredit_textBox.Text;

                            terminal.cardPay.bank = currentBank;
                            terminal.cardPay.contractNumber = numberOfCredit_textBox.Text;
                            terminal.cardPay.bankBranch = branches_combobox.Text;

                            this.Close();
                            terminal.cardPay.Show();

                            break;
                        }
                }
            }
            else
                MessageBox.Show("Введите номер договора и выберите филиал банка!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
