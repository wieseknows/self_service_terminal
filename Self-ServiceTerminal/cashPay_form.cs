using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class cashPay_form : Form
    {
        public string currentWM = "WMB";
        public int currency = 1;
        public bool canCloseForm = false;
        
        public string payerFIO = "";
        public string mobileNumber = "";
        public string mobileOperator = "";
        public string UPNPayer = "";
        public string UPNReciever = "";
        public string purseNumber = "";
        public string gameName = "";
        public string accountName = "";
        public string bank = "";
        public string contractNumber = "";
        public string cardNumber = "";

        public int totalMoneyForOperation = 0;
        terminalMain_form terminal;

        public cashPay_form()
        {
            InitializeComponent();
        }

        private void PutCashIn_button_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox PutCashIn = sender as PictureBox;
            PutCashIn.Location = new Point(PutCashIn.Location.X + 2, PutCashIn.Location.Y + 2);
        }

        private void PutCashIn_button_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox PutCashIn = sender as PictureBox;
            PutCashIn.Location = new Point(PutCashIn.Location.X - 2, PutCashIn.Location.Y - 2);
        }

        private void cash_In_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            operationName_label.Text = "Наименование операции: " + terminal.currentOperation;

            terminal.currentMoney_image.Visible = true;
            terminal.currentMoney_image.Enabled = true;
            terminal.NextMoneyButton.Visible = true;
            terminal.NextMoneyButton.Enabled = true;
            terminal.NextMoneyButton.BringToFront();
            terminal.currentCard_image.SendToBack();

            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
            
            terminal.selectedMoney = 20000;
            terminal.card_indicator.BringToFront();
            terminal.moneySlotDown.SendToBack();
            terminal.moneySlotUp.BringToFront();
        }

        private void cash_In_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            if (terminal.wayToPay == "cash")
            {
                terminal.currentMoney_image.Image = Properties.Resources.Cash20k;
                terminal.counterForMoney = 0;
                totalMoneyForOperation = 0;
                
                terminal.currentCard_image.Visible = true;
                terminal.currentCard_image.Enabled = true;
                terminal.NextCardButton.Visible = true;
                terminal.NextCardButton.Enabled = true;

                terminal.currentMoney_image.Visible = false;
                terminal.currentMoney_image.Enabled = false;
                terminal.NextMoneyButton.Visible = false;
                terminal.NextMoneyButton.Enabled = false;

                terminal.moneySlotDown.SendToBack();
                terminal.moneySlotUp.SendToBack();
                terminal.card_indicator.SendToBack();
                terminal.currentCard_image.Image = Properties.Resources.VisaGoldCard_image;
            } else
            {
                terminal.currentMoney_image.Image = Properties.Resources.Cash20k;
                terminal.counterForMoney = 0;
                totalMoneyForOperation = 0;

                terminal.currentMoney_image.Visible = false;
                terminal.currentMoney_image.Enabled = false;
                terminal.NextMoneyButton.Visible = false;
                terminal.NextMoneyButton.Enabled = false;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            terminalFunctions tm = new terminalFunctions();
            if (totalMoneyForOperation >= 5000)
            {
                terminal = this.Owner as terminalMain_form;
                switch (terminal.currentOperation)
                {
                    case "МОБИЛЬНАЯ СВЯЗЬ":
                        {
                            if (MessageBox.Show("Операция выполнена успешно, печетать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckMobileCommunication(totalMoneyForOperation, payerFIO, mobileNumber, mobileOperator);

                            this.Close();
                            break;
                        }
                    case "WEBMONEY":
                        {
                            double convertedDouble = (Convert.ToDouble(totalMoneyForOperation) / Convert.ToDouble(currency));
                            string convertedString = String.Format("{0:0.00}", convertedDouble);

                            if (MessageBox.Show("Вам будет начислено " + convertedString + " " + currentWM + ", желаете продолжить ?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (MessageBox.Show("Операция выполнена успешно, печетать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    tm.printCheckWebmoney(totalMoneyForOperation, purseNumber);

                            }
                            this.Close();
                            break;
                        }
                    case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                        {
                            if (MessageBox.Show("Операция выполнена успешно, печетать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckMoneyTransfer(totalMoneyForOperation, UPNPayer, UPNReciever, payerFIO);

                            this.Close();
                            break;
                        }
                    case "ОНЛАЙН ИГРЫ":
                        {
                            if (MessageBox.Show("Операция выполнена успешно, печетать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckOnlineGames(totalMoneyForOperation, gameName, accountName);

                            this.Close();
                            break;
                        }
                    case "ОПЛАТА КРЕДИТА":
                        {
                            if (MessageBox.Show("Операция выполнена успешно, печетать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCreditOperation(totalMoneyForOperation,contractNumber, bank);

                            this.Close();
                            break;
                        }
                    case "ПОПОЛНЕНИЕ БАЛАНСА":
                        {
                            if (terminal.card_form.ownCard)
                                terminal.currentUser.cardCurrentBalance += totalMoneyForOperation;

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCardOperation(totalMoneyForOperation, cardNumber);

                            this.Close();
                            break;
                        }
                    case "БЛАГОТВОРИТЕЛЬНОСТЬ":
                        {
                            charityThanks_form charity = new charityThanks_form();

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек ?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCharity(totalMoneyForOperation);

                            this.Close();
                            charity.Show();
                            break;
                        }
                }
            }
            else
                MessageBox.Show("Минимальная сумма оплаты - 5000 рублей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Accept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void Accept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void buttonBack_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_MouseMove(object sender, MouseEventArgs e)
        {
            buttonBack.Image = Properties.Resources.back1;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.Image = Properties.Resources.back0;
        }
    }
}
