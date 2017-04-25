using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class mobileCommunicate_form : Form
    {
        terminalMain_form terminal;
        public string mobileOperator = "Life:)";

        public bool canWriteNumPad = true;



        public mobileCommunicate_form()
        {
            InitializeComponent();
        }

        private void MobileLife_CheckedChanged(object sender, EventArgs e)
        {
            operatorCode_comboBox.Items.Clear();
            RadioButton Operator = sender as RadioButton;
            switch (Operator.Name)
            {
                case "MobileLife":
                    {
                        mobileOperator = "Life:)";
                        operatorCode_comboBox.Items.Add("25");
                        break;
                    }
                case "MobileVelcom":
                    {
                        mobileOperator = "Velcom";
                        operatorCode_comboBox.Items.Add("29");
                        operatorCode_comboBox.Items.Add("44");
                        break;
                    }
                case "MobileMts":
                    {
                        mobileOperator = "MTC";
                        operatorCode_comboBox.Items.Add("29");
                        operatorCode_comboBox.Items.Add("33");
                        break;
                    }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_MouseMove(object sender, MouseEventArgs e)
        {
            Back.Image = Properties.Resources.back1;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.Image = Properties.Resources.back0;
        }

        private void np1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                MobileNumber_textbox.BackColor = Color.GreenYellow;
                PictureBox numpadkeyPress = sender as PictureBox;
                MobileNumber_textbox.Text += numpadkeyPress.Name[2];
            }

            if (MobileNumber_textbox.Text.Length == 7)
            {
                MobileNumber_textbox.BackColor = Color.White;
                canWriteNumPad = false;
            }
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
            if (MobileNumber_textbox.Text.Length >= 1)
            {
                MobileNumber_textbox.Text = MobileNumber_textbox.Text.Substring(0, MobileNumber_textbox.Text.Length - 1);
                MobileNumber_textbox.BackColor = Color.GreenYellow;
                canWriteNumPad = true;
            }
        }

        private void NumPadOK_Click(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if (terminal.wayToPay == "cash")
            {
                if ((payerFIO_textbox.Text != "") && (payerFIO_textbox.Text.Length >= 5) && (MobileNumber_textbox.Text.Length == 7) && (operatorCode_comboBox.Text != ""))
                {
                    terminal.cashPay = new cashPay_form();
                    terminal.cashPay.Owner = terminal;

                    terminal.cashPay.payerFIO = this.payerFIO_textbox.Text;
                    terminal.cashPay.mobileNumber = "+375(" + operatorCode_comboBox.Text + ")" + MobileNumber_textbox.Text;
                    terminal.cashPay.mobileOperator = mobileOperator;

                    terminal.cashPay.option1.Text = "Номер телефона: " + terminal.cashPay.mobileNumber;
                    terminal.cashPay.option2.Text = "Плательщик: " + terminal.cashPay.payerFIO;

                    this.Close();
                    terminal.cashPay.Show();
                }
                else
                {
                    if ((payerFIO_textbox.Text == "") || (payerFIO_textbox.Text.Length < 5))
                        MessageBox.Show(@"Поле ""Плательщик"" должно содержать не менее пяти символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Выберите код оператора и введите семизначный номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if ((MobileNumber_textbox.Text.Length == 7) && (operatorCode_comboBox.Text != ""))
                {
                    terminal.cardPay = new cardPay_form();
                    terminal.cardPay.Owner = terminal;
                    terminal.cardPay.option1.Text = "Оператор связи: " + mobileOperator;
                    terminal.cardPay.option2.Text = "Номер телефона: " + "+375(" + operatorCode_comboBox.Text + ")" + MobileNumber_textbox.Text;

                    terminal.cardPay.payerFIO = terminal.currentUser.cardOwnerName;
                    terminal.cardPay.mobileOperator = mobileOperator;
                    terminal.cardPay.mobileNumber = "+375(" + operatorCode_comboBox.Text + ")" + MobileNumber_textbox.Text;

                    this.Close();
                    terminal.cardPay.Show();
                }
                else
                    MessageBox.Show("Выберите код оператора и введите семизначный номер телефона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void keyboard_ico_Click(object sender, EventArgs e)
        {
            payerFIO_textbox.BackColor = Color.GreenYellow;
            terminal = this.Owner as terminalMain_form;
            terminal.keyboard = new keyBoard_form();
            terminal.keyboard.Owner = terminal;
            terminal.keyboard.ShowDialog();
        }

        private void mobileCommunicate_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if (terminal.wayToPay == "card")
            {
                workPanel_mobileCommunicate.Visible = false;
                labelInsertPayerFIO.Visible = false;
                payerFIO_textbox.Visible = false;
                keyboard_ico.Visible = false;
                
                if ((terminal.currentUser.lastMobileNumber != "") && (terminal.currentUser.lastMobileOperator != "") && (terminal.currentUser.lastMobileNumber != null) && (terminal.currentUser.lastMobileOperator != null))
                {
                    if (MessageBox.Show("Желаете использовать последний сохранённый вами номер телефона?\nНомер: "
                    + terminal.currentUser.lastMobileNumber
                    + ", " + terminal.currentUser.lastMobileOperator,
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        terminal.cardPay = new cardPay_form();
                        terminal.cardPay.Owner = terminal;
                        terminal.cardPay.option1.Text = "Оператор связи: " + terminal.currentUser.lastMobileOperator;
                        terminal.cardPay.option2.Text = "Номер телефона: " + terminal.currentUser.lastMobileNumber;

                        terminal.cardPay.payerFIO = terminal.currentUser.cardOwnerName;
                        terminal.cardPay.mobileOperator = terminal.currentUser.lastMobileOperator;
                        terminal.cardPay.mobileNumber = terminal.currentUser.lastMobileNumber;

                        this.Close();
                        terminal.cardPay.Show();
                    }
                }
            }
            operatorCode_comboBox.Items.Add("25");
            payerFIO_textbox.ReadOnly = true;
            MobileNumber_textbox.ReadOnly = true;
        }

        private void mobileCommunicate_form_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
