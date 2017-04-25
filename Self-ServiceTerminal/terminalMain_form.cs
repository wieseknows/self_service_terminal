using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace Self_ServiceTerminal
{
    public partial class terminalMain_form : Form
    {
        public cardOperation_form card_form;
        public creditOperation_form credit_form;
        public lotteryCheck_form lottery_form;
        public onlineGames_form games_form;
        public operationWebmoney_form webMoneyOperation_form;
        public massMediaSubscribe_form MMSubscribeForm;
        public moneyTransfer_form moneyTransferForm;
        public mobileCommunicate_form mobileOperationForm;
        public keyBoard_form keyboard;
        public login_form login;
        public cashPay_form cashPay;
        public cardPay_form cardPay;
        public CardOwner currentUser;
        private terminalFunctions tf = new terminalFunctions();
        //Обслуживающиеся карты
        public string[] validCards =
        {
            "4255000064325688",
            "9423886512128645",
            "1387653200880043"
        };
        //Для определения какую карту/купюру предоставить следующей
        public byte counterForCards = 0;
        public byte counterForMoney = 0;
        public string selectedCard = "4255000064325688";
        public int selectedMoney = 20000;
        public CardOwner[] validOwners = new CardOwner[3];
        public string currentOperation;
        public string wayToPay = "cash";

        public terminalMain_form()
        {
            InitializeComponent();
        }
        

        private void Terminal_Load(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(CardOwner[]));
                using (FileStream fs = new FileStream("Serialization.xml", FileMode.Open))
                    validOwners = (CardOwner[])formatter.Deserialize(fs);
            }
            catch 
            {
                MessageBox.Show("Не был найден файл сериализации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            this.Location = new Point(this.Location.X + 30, this.Location.Y + 30);
            SlotLeft.Refresh();
            SlotRight.Refresh();
            SlotUp.Refresh();
            SlotDown.Refresh();
            SlotUp.BringToFront();
            SlotDown.BringToFront();
            SlotLeft.Visible = false;
            SlotRight.Visible = false;
            SlotLeft.BringToFront();
            SlotRight.BringToFront();
            
            timer1.Interval = 10;
            timer1.Tick += terminalAppearance;
            timer1.Start();
        }


        private void terminalAppearance(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            this.Location = new Point(this.Location.X - 3, this.Location.Y - 3);
            if (this.Opacity == 1)
                timer1.Stop();
        }
        

        private void NextCard_Click(object sender, EventArgs e)
        {
            counterForCards++;

            if (counterForCards == 3)
                counterForCards = 0;
            switch (counterForCards)
            {
                case 0:
                    {
                        currentCard_image.Image = Properties.Resources.VisaGoldCard_image;
                        selectedCard = "4255000064325688";
                        break;
                    }
                case 1:
                    {
                        currentCard_image.Image = Properties.Resources.VisaInfiniteCard_image;
                        selectedCard = "9423886512128645";
                        break;
                    }
                case 2:
                    {
                        currentCard_image.Image = Properties.Resources.MaestroCard_image;
                        selectedCard = "1387653200880043";
                        break;
                    }
            }
        }
        

        private void CurrentCard_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(29, 467);
        }


        private void CurrentCard_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(29, 567);
        }
        

        private void CurrentCard_Click(object sender, EventArgs e)
        {
            //Убираем кнопку выбора карты
            card_indicator.SendToBack();
            moneySlotDown.SendToBack();
            moneySlotUp.SendToBack();
            NextCardButton.Visible = false;

            for (int i = 0; i < 100; i++)
            {
                moneySlotDown.Refresh();
                moneySlotUp.Refresh();
                card_indicator.Refresh();
                Thread.Sleep(7);
                currentCard_image.Top -= 10;
                if (currentCard_image.Location.Y < 130)
                {
                    currentCard_image.Refresh();
                    SlotLeft.Visible = true;
                    SlotRight.Visible = true;
                    SlotDown.SendToBack();
                    SlotUp.Refresh();
                    SlotDown.Refresh();
                }
                else
                    currentCard_image.Refresh();
            }
            SlotUp.Refresh();
            SlotDown.Refresh();
            SlotDown.BringToFront();
            currentCard_image.Visible = false;
            SlotLeft.Visible = false;
            SlotRight.Visible = false;

            foreach (CardOwner co in validOwners)
            {
                if (co.cardNumber == selectedCard)
                    currentUser = co;
            }

            if (currentUser.cardBlocked)
            {
                MessageBox.Show("Ваша карта заблокирована, для разблокировки обратитесь в соответствующее отделение банка.", "Карта заблокирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
                card_indicator.Image = Properties.Resources.cardNotActive;
                wayToPay = "cash";
                currentCard_image.Visible = true;
                currentCard_image.Enabled = true;
                NextCardButton.Visible = true;
                NextCardButton.Enabled = true;
                giveCardBack_button.Visible = false;
                balanceButton_pictureBox.Visible = false;
                historyButton_pictureBox.Visible = false;
                currentUser = null;
            } else
            {
                Application.DoEvents();
                login = new login_form();
                login.Owner = this;
                login.Show();
            }
        }


        private void ButtonNews_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox ButtonInPassive = sender as PictureBox;
            ButtonInPassive.Location = new Point(ButtonInPassive.Location.X + 3, ButtonInPassive.Location.Y + 3);
        }

        private void ButtonNews_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox ButtonInPassive = sender as PictureBox;
            ButtonInPassive.Location = new Point(ButtonInPassive.Location.X - 3, ButtonInPassive.Location.Y - 3);
        }


        private void ButtonMobile_Click(object sender, EventArgs e)
        {
            currentOperation = "МОБИЛЬНАЯ СВЯЗЬ";
            mobileOperationForm = new mobileCommunicate_form();
            mobileOperationForm.Owner = this;
            mobileOperationForm.Show();

            currentCard_image.Visible = false;
            NextCardButton.Visible = false;
        }


        private void NextMoneyButton_Click(object sender, EventArgs e)
        {
            counterForMoney++;
            if (counterForMoney == 4)
                counterForMoney = 0;
            switch (counterForMoney)
            {
                case 0:
                    {
                        currentMoney_image.Image = Properties.Resources.Cash20k;
                        selectedMoney = 20000;
                        break;
                    }
                case 1:
                    {
                        currentMoney_image.Image = Properties.Resources.Cash50k;
                        selectedMoney = 50000;
                        break;
                    }
                case 2:
                    {
                        currentMoney_image.Image = Properties.Resources.Cash100k;
                        selectedMoney = 100000;
                        break;
                    }
                case 3:
                    {
                        currentMoney_image.Image = Properties.Resources.Cash200k;
                        selectedMoney = 200000;
                        break;
                    }
            }
        }


        private void currentMoney_image_Click(object sender, EventArgs e)
        {
            cashPay.Owner = this;
            for (int i = 0; i < 100; i++)
            {
                moneySlotDown.Refresh();
                moneySlotUp.Refresh();
                Thread.Sleep(7);
                currentMoney_image.Top -= 10;
                if (currentCard_image.Location.Y < 95)
                {
                    currentMoney_image.Refresh();
                    moneySlotDown.Refresh();
                    moneySlotUp.Refresh();
                }
                else
                    currentMoney_image.Refresh();
                this.Invalidate();
            }
            currentMoney_image.Refresh();
            currentMoney_image.Visible = false;
            currentMoney_image.Location = new Point(29, 570);
            moneySlotDown.Refresh();
            moneySlotUp.Refresh();
            this.Invalidate();
            cashPay.totalMoneyForOperation += selectedMoney;
            cashPay.label2.Text = "Всего внесено.........." + cashPay.totalMoneyForOperation + " BYR";
            cashPay.moneyForOperation_label.Text = "Сумма оплаты: " + Convert.ToString(cashPay.totalMoneyForOperation);
            Thread.Sleep(1000);
            currentMoney_image.Visible = true;
        }


        private void ButtonTransfer_Click(object sender, EventArgs e)
        {
            this.currentOperation = "ДЕНЕЖНЫЕ ПЕРЕВОДЫ";
            moneyTransferForm = new moneyTransfer_form();
            moneyTransferForm.Owner = this;
            moneyTransferForm.Show();
        }


        private void ButtonNews_Click(object sender, EventArgs e)
        {
            if (wayToPay == "card")
            {
                this.currentOperation = "ПОДПИСКА НА СМИ";
                MMSubscribeForm = new massMediaSubscribe_form();
                MMSubscribeForm.Owner = this;
                MMSubscribeForm.Show();
            }
            else
                MessageBox.Show("К сожалению, данная функция доступна только с использованием карточки.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void giveCardBack_button_MouseMove(object sender, MouseEventArgs e)
        {
            giveCardBack_button.Image = Properties.Resources.aerobutton_RED_takeCardBack1;
        }


        private void giveCardBack_button_MouseLeave(object sender, EventArgs e)
        {
            giveCardBack_button.Image = Properties.Resources.aerobutton_RED_takeCardBack0;
        }


        private void giveCardBack_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завершить работу с картой?", "Подтвердите", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                card_indicator.Image = Properties.Resources.cardNotActive;
                wayToPay = "cash";
                currentCard_image.Visible = true;
                currentCard_image.Enabled = true;
                NextCardButton.Visible = true;
                NextCardButton.Enabled = true;
                giveCardBack_button.Visible = false;
                balanceButton_pictureBox.Visible = false;
                historyButton_pictureBox.Visible = false;
                currentUser = null;
            }
        }


        private void ButtonWebmoney_Click(object sender, EventArgs e)
        {
            this.currentOperation = "WEBMONEY";
            webMoneyOperation_form = new operationWebmoney_form();
            webMoneyOperation_form.Owner = this;
            webMoneyOperation_form.Show();
        }


        private void ButtonGame_Click(object sender, EventArgs e)
        {
            currentOperation = "ОНЛАЙН ИГРЫ";
            games_form = new onlineGames_form();
            games_form.Owner = this;
            games_form.Show();
        }

        private void ButtonLottery_Click(object sender, EventArgs e)
        {
            currentOperation = "ЛОТЕРЕИ";
            lottery_form = new lotteryCheck_form();
            lottery_form.Owner = this;
            lottery_form.Show();
        }

        private void ButtonCredits_Click(object sender, EventArgs e)
        {
            currentOperation = "ОПЛАТА КРЕДИТА";
            credit_form = new creditOperation_form();
            credit_form.Owner = this;
            credit_form.Show();
        }

        private void ButtonCardBalance_Click(object sender, EventArgs e)
        {
            currentOperation = "ПОПОЛНЕНИЕ БАЛАНСА";
            card_form = new cardOperation_form();
            card_form.Owner = this;
            card_form.Show();
        }

        private void ButtonCharity_Click(object sender, EventArgs e)
        {
            currentOperation = "БЛАГОТВОРИТЕЛЬНОСТЬ";
            switch (wayToPay)
            {
                case "cash":
                    {
                        cashPay = new cashPay_form();
                        cashPay.Owner = this;
                        cashPay.Show();

                        break;
                    }
                case "card":
                    {
                        cardPay = new cardPay_form();
                        cardPay.Owner = this;
                        cardPay.Show();

                        break;
                    }
            }
        }


        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Self-Service Terminal Help.chm");
        }


        private void balanceButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            balanceButton_pictureBox.Image = Properties.Resources.balance_button1;
        }


        private void balanceButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            balanceButton_pictureBox.Image = Properties.Resources.balance_button0;
        }


        private void historyButton_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            historyButton_pictureBox.Image = Properties.Resources.history_button1;
        }


        private void historyButton_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            historyButton_pictureBox.Image = Properties.Resources.history_button0;
        }


        private void balanceButton_pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Остаток на счете: " + this.currentUser.cardCurrentBalance + " рублей");
        }


        private void historyButton_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(currentUser.cardNumber + ".txt");
            }
            catch
            {
                MessageBox.Show("Файл истории не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void terminalMain_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            tf.serializeOwners(validOwners);
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завершить работу?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        
    }
}