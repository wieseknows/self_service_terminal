using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class keyBoard_form : Form
    {
        terminalMain_form terminal;

        public keyBoard_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X + 3, numPadButton.Location.Y + 3);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox numPadButton = sender as PictureBox;
            numPadButton.Location = new Point(numPadButton.Location.X - 3, numPadButton.Location.Y - 3);
        }

        private void з_Click(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            PictureBox keyboard_key = sender as PictureBox;

            switch (terminal.currentOperation)
            {
                case "МОБИЛЬНАЯ СВЯЗЬ":
                    {
                        terminal.mobileOperationForm.payerFIO_textbox.ReadOnly = true;
                        terminal.mobileOperationForm.payerFIO_textbox.Text += keyboard_key.Name.ToUpper();
                        break;
                    }
                case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                    {
                        if (terminal.moneyTransferForm.FIOpayer)
                            terminal.moneyTransferForm.FIOpayer_textbox.Text += keyboard_key.Name.ToUpper();
                        if (terminal.moneyTransferForm.FIOreciever)
                            terminal.moneyTransferForm.FIOreciever_textbox.Text += keyboard_key.Name.ToUpper();

                        break;
                    }
                case "ПОДПИСКА НА СМИ":
                    {
                        if (terminal.MMSubscribeForm.FIOpayer)
                            terminal.MMSubscribeForm.FIOpayer_textbox.Text += keyboard_key.Name.ToUpper();
                        if (terminal.MMSubscribeForm.adress)
                            terminal.MMSubscribeForm.adress_textbox.Text += keyboard_key.Name.ToUpper();
                        break;
                    }
                case "WEBMONEY":
                    {
                        terminal.webMoneyOperation_form.description_textBox.Text += keyboard_key.Name.ToUpper();
                        break;
                    }
                case "ОНЛАЙН ИГРЫ":
                    {
                        terminal.games_form.accountName_textbox.Text += keyboard_key.Name;
                        break;
                    }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            switch (terminal.currentOperation)
            { 
                case "МОБИЛЬНАЯ СВЯЗЬ":
                    {
                        if (terminal.mobileOperationForm.payerFIO_textbox.Text.Length >= 1)
                        {
                            terminal.mobileOperationForm.payerFIO_textbox.Text = terminal.mobileOperationForm.payerFIO_textbox.Text.Substring(0, terminal.mobileOperationForm.payerFIO_textbox.Text.Length - 1);
                            terminal.mobileOperationForm.payerFIO_textbox.ReadOnly = true;
                        }
                        break;
                    }
                case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                    {
                        if ((terminal.moneyTransferForm.FIOpayer) && (terminal.moneyTransferForm.FIOpayer_textbox.Text.Length >= 1))
                            terminal.moneyTransferForm.FIOpayer_textbox.Text = terminal.moneyTransferForm.FIOpayer_textbox.Text.Substring(0, terminal.moneyTransferForm.FIOpayer_textbox.Text.Length - 1);
                        if ((terminal.moneyTransferForm.FIOreciever) && (terminal.moneyTransferForm.FIOreciever_textbox.Text.Length >= 1))
                            terminal.moneyTransferForm.FIOreciever_textbox.Text = terminal.moneyTransferForm.FIOreciever_textbox.Text.Substring(0, terminal.moneyTransferForm.FIOreciever_textbox.Text.Length - 1);
                        terminal.moneyTransferForm.FIOpayer_textbox.ReadOnly = true;
                        terminal.moneyTransferForm.FIOreciever_textbox.ReadOnly = true;

                        break;
                    }
                case "ПОДПИСКА НА СМИ":
                    {
                        if ((terminal.MMSubscribeForm.FIOpayer) && (terminal.MMSubscribeForm.FIOpayer_textbox.Text.Length >= 1))
                            terminal.MMSubscribeForm.FIOpayer_textbox.Text = terminal.MMSubscribeForm.FIOpayer_textbox.Text.Substring(0, terminal.MMSubscribeForm.FIOpayer_textbox.Text.Length - 1);
                        if ((terminal.MMSubscribeForm.adress) && (terminal.MMSubscribeForm.adress_textbox.Text.Length >= 1))
                            terminal.MMSubscribeForm.adress_textbox.Text = terminal.MMSubscribeForm.adress_textbox.Text.Substring(0, terminal.MMSubscribeForm.adress_textbox.Text.Length - 1);
                        terminal.MMSubscribeForm.FIOpayer_textbox.ReadOnly = true;
                        terminal.MMSubscribeForm.adress_textbox.ReadOnly = true;

                        break;
                    }
                case "WEBMONEY":
                    {
                        if (terminal.webMoneyOperation_form.description_textBox.Text.Length >= 1)
                            terminal.webMoneyOperation_form.description_textBox.Text = terminal.webMoneyOperation_form.description_textBox.Text.Substring(0, terminal.webMoneyOperation_form.description_textBox.Text.Length - 1);
                        terminal.webMoneyOperation_form.description_textBox.ReadOnly = true;

                        break;
                    }
                case "ОНЛАЙН ИГРЫ":
                    {
                        if (terminal.games_form.accountName_textbox.Text.Length >= 1)
                            terminal.games_form.accountName_textbox.Text = terminal.games_form.accountName_textbox.Text.Substring(0, terminal.games_form.accountName_textbox.Text.Length - 1);
                        terminal.games_form.accountName_textbox.ReadOnly = true;

                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Top -= 21;
            if (this.Location.Y <= 440)
                timer1.Stop();
        }

        private void KeyBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        
        private void minus_Click(object sender, EventArgs e)
        {
            char neededChar = ' ';
            PictureBox pb = sender as PictureBox;
            if (pb.Name == "minus")
                neededChar = '-';
            else
                neededChar = ' ';

            terminal = this.Owner as terminalMain_form;
            switch (terminal.currentOperation)
            {
                case "МОБИЛЬНАЯ СВЯЗЬ":
                    {
                        terminal.mobileOperationForm.payerFIO_textbox.Text += neededChar;
                        break;
                    }
                case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                    {
                        if (terminal.moneyTransferForm.FIOpayer)
                            terminal.moneyTransferForm.FIOpayer_textbox.Text += neededChar;
                        if (terminal.moneyTransferForm.FIOreciever)
                            terminal.moneyTransferForm.FIOreciever_textbox.Text += neededChar;
                        break;
                    }
                case "ПОДПИСКА НА СМИ":
                    {
                        if (terminal.MMSubscribeForm.FIOpayer)
                            terminal.MMSubscribeForm.FIOpayer_textbox.Text += neededChar;
                        if (terminal.MMSubscribeForm.adress)
                            terminal.MMSubscribeForm.adress_textbox.Text += neededChar;
                        break;
                    }
                case "WEBMONEY":
                    {
                        terminal.webMoneyOperation_form.description_textBox.Text += neededChar;
                        break;
                    }
                case "ОНЛАЙН ИГРЫ":
                    {
                        terminal.games_form.accountName_textbox.Text += neededChar;
                        break;
                    }
            }
        }

        private void keyBoard_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            switch (terminal.currentOperation)
            {
                case "МОБИЛЬНАЯ СВЯЗЬ":
                    {
                        terminal.mobileOperationForm.payerFIO_textbox.BackColor = Color.White;
                        break;
                    }
                case "ДЕНЕЖНЫЕ ПЕРЕВОДЫ":
                    {
                        if (terminal.moneyTransferForm.FIOpayer)
                            terminal.moneyTransferForm.FIOpayer_textbox.BackColor = Color.White;
                        if (terminal.moneyTransferForm.FIOreciever)
                            terminal.moneyTransferForm.FIOreciever_textbox.BackColor = Color.White;
                        break;
                    }
                case "ПОДПИСКА НА СМИ":
                    {
                        if (terminal.MMSubscribeForm.FIOpayer)
                            terminal.MMSubscribeForm.FIOpayer_textbox.BackColor = Color.White;
                        if (terminal.MMSubscribeForm.adress)
                            terminal.MMSubscribeForm.adress_textbox.BackColor = Color.White;
                        break;
                    }
                case "WEBMONEY":
                    {
                        terminal.webMoneyOperation_form.description_textBox.BackColor = Color.White;
                        break;
                    }
                case "ОНЛАЙН ИГРЫ":
                    {
                        terminal.games_form.accountName_textbox.BackColor = Color.White;
                        break;
                    }
            }
        }
    }
}
