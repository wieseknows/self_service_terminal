using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Self_ServiceTerminal
{
    public partial class cardPay_form : Form
    {
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
        public string bankBranch = "";
        public string cardNumber = "";

        private string historyOwner = "";
        public int currency = 1;
        public string currentWM = "WMB";
        public terminalMain_form terminal;
        bool canWriteNumPad = true;

        public cardPay_form()
        {
            InitializeComponent();
        }

        private void NumPad1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                if (PaySum_textbox.Text.Length == 8)
                {
                    PaySum_textbox.ReadOnly = true;
                    canWriteNumPad = false;
                }
                PictureBox numpadkeyPress = sender as PictureBox;
                PaySum_textbox.Text += numpadkeyPress.Name[2];
            }
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            if (PaySum_textbox.Text.Length >= 1)
            {
                PaySum_textbox.Text = PaySum_textbox.Text.Substring(0, PaySum_textbox.Text.Length - 1);
                canWriteNumPad = true;
                PaySum_textbox.ReadOnly = false;
            }
        }
        
        private void cardPay_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;

            payer.Text = terminal.currentUser.cardOwnerName;
            currentBalance_label.Text = Convert.ToString(terminal.currentUser.cardCurrentBalance);
            operation_label.Text = "Наименование операции: " + terminal.currentOperation;
        }

        private void NumPad1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X + 3, numPadButton.Location.Y + 3);
        }

        private void NumPad1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X - 3, numPadButton.Location.Y - 3);
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void NumPadOK_Click(object sender, EventArgs e)
        {
            terminalFunctions tm = new terminalFunctions();
            DateTime now = DateTime.Now;
            int paySum = Convert.ToInt32(PaySum_textbox.Text);

            terminal = this.Owner as terminalMain_form;
            historyOwner = terminal.currentUser.cardNumber;
            StreamWriter historyFile = new StreamWriter(historyOwner + ".txt", true);
            
            if ((paySum >= 5000) && (paySum <= terminal.currentUser.cardCurrentBalance))
            {
                switch (terminal.currentOperation)
                {
                    case "МОБИЛЬНАЯ СВЯЗЬ":
                        {
                            terminal.currentUser.cardCurrentBalance -= paySum;
                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option2.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckMobileCommunication(paySum, payerFIO, mobileNumber, mobileOperator);

                            //Сравниваем с сохраненными данными
                            if ((mobileNumber != terminal.currentUser.lastMobileNumber) || (mobileOperator != terminal.currentUser.lastMobileOperator))
                            {
                                if (MessageBox.Show("Желаете сохранить мобильный номер " + @"""" + mobileNumber + @"""" + " для дальнейшего его использования?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    terminal.currentUser.setLastMobileCommunication(mobileNumber, mobileOperator);
                            }

                            this.Close();
                            break;
                        }
                    case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                        {
                            terminal.currentUser.cardCurrentBalance -= paySum;
                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option3.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckMoneyTransfer(paySum, UPNPayer, UPNReciever, payerFIO);

                            this.Close();
                            break;
                        }
                    case "WEBMONEY":
                        {
                            double convertedDouble = (Convert.ToDouble(PaySum_textbox.Text) / Convert.ToDouble(currency));
                            string convertedString = String.Format("{0:0.00}", convertedDouble);

                            if (MessageBox.Show("На ваш счет будет зачислено " + convertedString + " " + currentWM + ", желаете продолжить ?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                terminal.currentUser.cardCurrentBalance -= paySum;
                                historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option2.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                                historyFile.WriteLine("");

                                if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    tm.printCheckWebmoney(paySum, purseNumber);

                                if (purseNumber != terminal.currentUser.lastWebmoneyPurse)
                                {
                                    if (MessageBox.Show("Желаете сохранить номер кошелька WebMoney " + @"""" + purseNumber + @"""" + " для дальнейшего его использования?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        terminal.currentUser.setLastWebmoneyOperation(purseNumber);
                                }

                                this.Close();
                            }
                            break;
                        }
                    case "ОНЛАЙН ИГРЫ":
                        {
                            terminal.currentUser.cardCurrentBalance -= paySum;
                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option1.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckOnlineGames(paySum, gameName, accountName);

                            this.Close();
                            break;
                        }
                    case "ОПЛАТА КРЕДИТА":
                        {
                            terminal.currentUser.cardCurrentBalance -= paySum;
                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option3.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCreditOperation(paySum, contractNumber, bank);

                            if ((contractNumber != terminal.currentUser.lastCreditNumber)
                                || (bank != terminal.currentUser.lastBank)
                                || (bankBranch != terminal.currentUser.lastBankBranch))
                            {
                                if (MessageBox.Show("Желаете сохранить данные о кредите для использования их в дальнейшем ?\n" + "Банк: " + bank + "\nФилиал: " + bankBranch + "\nНомер кредитного договора: " + contractNumber, "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    terminal.currentUser.setLastCreditOperation(contractNumber, bank, bankBranch);
                            }

                            this.Close();
                            break;
                        }
                    case "ПОПОЛНЕНИЕ БАЛАНСА":
                        {
                            terminal.currentUser.cardCurrentBalance -= paySum;
                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", " + option2.Text + ", Сумма оплаты: " + PaySum_textbox.Text);
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCardOperation(paySum, cardNumber);

                            this.Close();
                            break;
                        }
                    case "БЛАГОТВОРИТЕЛЬНОСТЬ":
                        {
                            charityThanks_form charity = new charityThanks_form();
                            terminal.currentUser.cardCurrentBalance -= paySum;

                            historyFile.WriteLine(now.ToString("dd MMM yyyy, HH:mm ----- ") + terminal.currentOperation + ", Сумма оплаты: " + PaySum_textbox.Text + ", СПАСИБО ЗА ВАШУ ПОМОЩЬ!");
                            historyFile.WriteLine("");

                            if (MessageBox.Show("Операция выполнена успешно, печатать чек?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                tm.printCheckCharity(paySum);

                            this.Close();
                            charity.Show();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Неизвестая ошибка!", "Что происходит?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
                historyFile.Close();
            }
            else
            {
                if (paySum < 5000)
                    MessageBox.Show("Минимальная сумма платежа — 5000 BYR", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("На вашем балансе недостаточно средств!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PaySum_textbox.Clear();
                canWriteNumPad = true;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
