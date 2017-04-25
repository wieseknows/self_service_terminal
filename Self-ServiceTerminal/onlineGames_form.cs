using System;
using System.Drawing;
using System.Windows.Forms;

namespace Self_ServiceTerminal
{
    public partial class onlineGames_form : Form
    {
        terminalMain_form terminal;
        public string currentGame;
        public onlineGames_form()
        {
            InitializeComponent();
        }

        private void HS_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            switch (pb.Name)
            {
                case "HS":
                    {
                        HS.Image = Properties.Resources.Hearthstone_121;
                        break;
                    }
                case "WOT":
                    {
                        WOT.Image = Properties.Resources.WOT_121;
                        break;
                    }
                case "steam":
                    {
                        steam.Image = Properties.Resources.Steam_121;
                        break;
                    }
                case "WF":
                    {
                        WF.Image = Properties.Resources.Warface_121;
                        break;
                    }
            }
        }

        private void HS_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            switch (pb.Name)
            {
                case "HS":
                    {
                        HS.Image = Properties.Resources.hearthstone95;
                        break;
                    }
                case "WOT":
                    {
                        WOT.Image = Properties.Resources.wot95;
                        break;
                    }
                case "steam":
                    {
                        steam.Image = Properties.Resources.steam95;
                        break;
                    }
                case "WF":
                    {
                        WF.Image = Properties.Resources.warface95;
                        break;
                    }
            }
        }

        private void HS_Click(object sender, EventArgs e)
        {
            back_button.Location = new Point(435, 360);
            accountName_label.Visible = true;
            accountName_textbox.Visible = true;
            buttonAccept.Visible = true;
            HS.Visible = false;
            WF.Visible = false;
            steam.Visible = false;
            WOT.Visible = false;

            this.BackgroundImage = Properties.Resources.games_operation;
            PictureBox pb = sender as PictureBox;
            switch (pb.Name)
            {
                case "HS":
                    {
                        currentGame_pictureBox.Image = Properties.Resources.Hearthstone_121;
                        currentGame = "HearthStone";
                        break;
                    }
                case "WOT":
                    {
                        currentGame_pictureBox.Image = Properties.Resources.WOT_121;
                        currentGame = "World Of Tanks";
                        break;
                    }
                case "steam":
                    {
                        currentGame_pictureBox.Image = Properties.Resources.Steam_121;
                        currentGame = "Steam";
                        break;
                    }
                case "WF":
                    {
                        currentGame_pictureBox.Image = Properties.Resources.Warface_121;
                        currentGame = "WarFace";
                        break;
                    }
            }
            currentGame_pictureBox.Visible = true;
        }

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void buttonAccept_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox accept = sender as PictureBox;
            accept.Location = new Point(accept.Location.X + 2, accept.Location.Y + 2);
        }

        private void buttonAccept_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox accept = sender as PictureBox;
            accept.Location = new Point(accept.Location.X - 2, accept.Location.Y - 2);
        }

        private void accountName_textbox_Click(object sender, EventArgs e)
        {
            accountName_textbox.BackColor = Color.GreenYellow;
            terminal = this.Owner as terminalMain_form;
            terminal.keyboard = new keyBoard_form();
            terminal.keyboard.Owner = terminal;
            terminal.keyboard.ShowDialog();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (accountName_textbox.Text.Length >= 4)
            {
                terminal = this.Owner as terminalMain_form;
                if (terminal.wayToPay == "cash")
                {
                    if (accountName_textbox.Text != "")
                    {
                        terminal.cashPay = new cashPay_form();
                        terminal.cashPay.Owner = terminal;
                        
                        terminal.cashPay.operationName_label.Text = "Наименование операции: " + terminal.currentOperation;
                        terminal.cashPay.option1.Text = "Имя аккаунта: " + accountName_textbox.Text;

                        terminal.cashPay.accountName = accountName_textbox.Text;
                        terminal.cashPay.gameName = currentGame;

                        this.Close();
                        terminal.cashPay.Show();
                    }
                    else
                    {
                        MessageBox.Show("Введите имя аккаунта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (accountName_textbox.Text != "")
                    {
                        terminal.cardPay = new cardPay_form();
                        terminal.cardPay.Owner = terminal;
                        terminal.cardPay.option1.Text = "Имя аккаунта: " + accountName_textbox.Text;

                        terminal.cardPay.accountName = accountName_textbox.Text;
                        terminal.cardPay.gameName = currentGame;

                        this.Close();
                        terminal.cardPay.Show();
                    }
                    else
                        MessageBox.Show("Введите имя аккаунта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Слишком короткое имя аккаунта!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void onlineGames_form_Load(object sender, EventArgs e)
        {
            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.Image = Properties.Resources.back0;
        }

        private void back_button_MouseMove(object sender, MouseEventArgs e)
        {
            back_button.Image = Properties.Resources.back1;
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
    }
}
