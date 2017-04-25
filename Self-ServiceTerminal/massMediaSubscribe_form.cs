using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Self_ServiceTerminal
{
    public partial class massMediaSubscribe_form : Form
    {
        terminalFunctions tf = new terminalFunctions();
        terminalMain_form terminal;
        public bool subscribeOnMagazine;
        public bool subscribeOnNewsPaper;
        public bool FIOpayer = false;
        public bool adress = false;
        public bool canWriteNumPad = true;
        public bool canWriteFIO;
        public bool canWriteAdress;
        private int[] pricesMagazine = new int[35]
        {
            12500, 14200, 15000, 21000, 8800, 31200, 31500, 5500, 12650, 33000, 5600, 12600, 11400, 15300, 42500, 61400, 31200, 73900, 89200, 39200, 45000, 31400, 28100, 95300, 44000, 41300, 55000, 51200, 42000, 31500, 12500, 13000, 13500, 33200, 90000
        };

        private int[] pricesNewsPaper = new int[44]
        {
            12650, 33000, 61400, 31200, 73900, 12500, 12600, 11400, 15300, 42500, 31500, 33000, 5600, 31200, 73900, 89200, 39200, 45000, 31400, 28100, 95300, 44000, 41300, 55000, 5500, 12650,  51200, 42000, 31500, 12500, 13000, 13500, 33200, 61400, 14200, 15000, 21000, 5600, 12600, 11400, 15300, 42500,  8800, 31200
        };

        public massMediaSubscribe_form()
        {
            InitializeComponent();
        }

        private void massMediaSubscribe_form_Load(object sender, EventArgs e)
        {
            //загружаем список газет или журналов
            string[] lines = File.ReadAllLines("massMedia_magazines.txt", Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                magazines_combobox.Items.Add(lines[i]);
            }

            string[] lines1 = File.ReadAllLines("massMedia_newspapers.txt", Encoding.Default);
            for (int i = 0; i < lines1.Length; i++)
            {
                newsPapers_combobox.Items.Add(lines1[i]);
            }

            terminal = this.Owner as terminalMain_form;
            terminal.currentCard_image.Visible = false;
            terminal.currentCard_image.Enabled = false;
            terminal.NextCardButton.Visible = false;
            terminal.NextCardButton.Enabled = false;
        }

        private void massMediaSubscribe_form_FormClosing(object sender, FormClosingEventArgs e)
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
        
        

        private void magazine_label_MouseMove(object sender, MouseEventArgs e)
        {
            Label lb = sender as Label;
            lb.ForeColor = Color.GreenYellow;
        }

        private void magazine_label_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.ForeColor = Color.White;
        }

        private void magazine_label_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = sender as Label;
            lb.Location = new Point(lb.Location.X + 2, lb.Location.Y + 2);
        }

        private void magazine_label_MouseUp(object sender, MouseEventArgs e)
        {
            Label lb = sender as Label;
            lb.Location = new Point(lb.Location.X - 2, lb.Location.Y - 2);
        }

        private void magazine_label_Click_1(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            if (lb.Name == "newspaper_label")
            {
                subscribeOnNewsPaper = true;
                subscribeOnMagazine = false;
                newsPapers_combobox.Visible = true;
            } else
            {
                subscribeOnNewsPaper = false;
                subscribeOnMagazine = true;
                magazines_combobox.Visible = true;
            }
            buttonAccept.Visible = true;
            newspaper_label.Visible = false;
            magazine_label.Visible = false;
            workPanel.Visible = true;
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
            this.Close();
        }

        private void FIOpayer_textbox_Click(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Name == "FIOpayer_textbox")
            {
                FIOpayer = true;
                adress = false;
                FIOpayer_textbox.BackColor = Color.GreenYellow;
            }

            if (tb.Name == "adress_textbox")
            {
                FIOpayer = false;
                adress = true;
                adress_textbox.BackColor = Color.GreenYellow;
            }
            
            terminal = this.Owner as terminalMain_form;
            terminal.keyboard = new keyBoard_form();
            terminal.keyboard.Owner = terminal;
            terminal.keyboard.ShowDialog();
        }

        private void np1_Click(object sender, EventArgs e)
        {
            if (canWriteNumPad)
            {
                PictureBox numpadkeyPress = sender as PictureBox;
                index_textbox.BackColor = Color.GreenYellow;
                index_textbox.Text += numpadkeyPress.Name[2];
            }
        }

        private void index_textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length == 6)
            {
                NumPad.Visible = false;
                canWriteNumPad = false;
                index_textbox.BackColor = Color.White;
            }
        }

        private void NumPadDel_Click(object sender, EventArgs e)
        {
            index_textbox.Text = index_textbox.Text.Substring(0, index_textbox.Text.Length - 1);
            canWriteNumPad = true;
        }

        private void index_textbox_Click(object sender, EventArgs e)
        {
            index_textbox.BackColor = Color.GreenYellow;
            NumPad.Visible = true;
        }

        private void buttonAccept_MouseLeave(object sender, EventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton0;
        }

        private void buttonAccept_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAccept.Image = Properties.Resources.acceptButton1;
        }

        private void NumPadDel_Click_1(object sender, EventArgs e)
        {
            if (index_textbox.Text.Length >= 1)
            {
                index_textbox.Text = index_textbox.Text.Substring(0, index_textbox.Text.Length - 1);
                canWriteNumPad = true;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (((magazines_combobox.Text != "") || (newsPapers_combobox.Text != "")) &&
                (FIOpayer_textbox.Text != "") &&
                (index_textbox.Text.Length == 6) && 
                (adress_textbox.Text != ""))
            {
                int priceForSubscribe = 0;

                if (subscribeOnMagazine)
                    priceForSubscribe = pricesMagazine[magazines_combobox.SelectedIndex];
                else
                    priceForSubscribe = pricesNewsPaper[newsPapers_combobox.SelectedIndex];

                if (MessageBox.Show("С вашего счета будет списано " + priceForSubscribe + " BYR, желаете продолжить ?", "Подтвердите действие", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    terminal.currentUser.cardCurrentBalance -= priceForSubscribe;
                    if (MessageBox.Show("Операция выполнена успешно, печатать чек ?", "Способ получения чека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        tf.printCheckMassMediaSubscribe(priceForSubscribe);

                    this.Close();
                }
            }
            else
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void index_textbox_Leave(object sender, EventArgs e)
        {
            index_textbox.BackColor = Color.White;
        }
    }
}
