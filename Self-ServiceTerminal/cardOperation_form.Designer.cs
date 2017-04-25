namespace Self_ServiceTerminal
{
    partial class cardOperation_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardOperation_form));
            this.NumPad = new System.Windows.Forms.GroupBox();
            this.NumPadOK = new System.Windows.Forms.PictureBox();
            this.np0 = new System.Windows.Forms.PictureBox();
            this.NumPadDel = new System.Windows.Forms.PictureBox();
            this.np9 = new System.Windows.Forms.PictureBox();
            this.np8 = new System.Windows.Forms.PictureBox();
            this.np7 = new System.Windows.Forms.PictureBox();
            this.np6 = new System.Windows.Forms.PictureBox();
            this.np5 = new System.Windows.Forms.PictureBox();
            this.np4 = new System.Windows.Forms.PictureBox();
            this.np3 = new System.Windows.Forms.PictureBox();
            this.np2 = new System.Windows.Forms.PictureBox();
            this.np1 = new System.Windows.Forms.PictureBox();
            this.cardNumber_textBox = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.insertCardNumber_label = new System.Windows.Forms.Label();
            this.cardOrCash_panel = new System.Windows.Forms.Panel();
            this.cancel_pictureBox = new System.Windows.Forms.PictureBox();
            this.ok_pictureBox = new System.Windows.Forms.PictureBox();
            this.cash_radioButton = new System.Windows.Forms.RadioButton();
            this.card_radioButton = new System.Windows.Forms.RadioButton();
            this.NumPad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPadOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPadDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.cardOrCash_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NumPad
            // 
            this.NumPad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NumPad.BackgroundImage")));
            this.NumPad.Controls.Add(this.NumPadOK);
            this.NumPad.Controls.Add(this.np0);
            this.NumPad.Controls.Add(this.NumPadDel);
            this.NumPad.Controls.Add(this.np9);
            this.NumPad.Controls.Add(this.np8);
            this.NumPad.Controls.Add(this.np7);
            this.NumPad.Controls.Add(this.np6);
            this.NumPad.Controls.Add(this.np5);
            this.NumPad.Controls.Add(this.np4);
            this.NumPad.Controls.Add(this.np3);
            this.NumPad.Controls.Add(this.np2);
            this.NumPad.Controls.Add(this.np1);
            this.NumPad.Location = new System.Drawing.Point(647, 97);
            this.NumPad.Name = "NumPad";
            this.NumPad.Size = new System.Drawing.Size(300, 390);
            this.NumPad.TabIndex = 99;
            this.NumPad.TabStop = false;
            this.NumPad.Visible = false;
            // 
            // NumPadOK
            // 
            this.NumPadOK.Cursor = System.Windows.Forms.Cursors.No;
            this.NumPadOK.Image = ((System.Drawing.Image)(resources.GetObject("NumPadOK.Image")));
            this.NumPadOK.Location = new System.Drawing.Point(195, 289);
            this.NumPadOK.Name = "NumPadOK";
            this.NumPadOK.Size = new System.Drawing.Size(90, 90);
            this.NumPadOK.TabIndex = 11;
            this.NumPadOK.TabStop = false;
            this.NumPadOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.NumPadOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np0
            // 
            this.np0.Image = ((System.Drawing.Image)(resources.GetObject("np0.Image")));
            this.np0.Location = new System.Drawing.Point(105, 289);
            this.np0.Name = "np0";
            this.np0.Size = new System.Drawing.Size(90, 90);
            this.np0.TabIndex = 10;
            this.np0.TabStop = false;
            this.np0.Click += new System.EventHandler(this.np1_Click);
            this.np0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // NumPadDel
            // 
            this.NumPadDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumPadDel.Image = ((System.Drawing.Image)(resources.GetObject("NumPadDel.Image")));
            this.NumPadDel.Location = new System.Drawing.Point(15, 289);
            this.NumPadDel.Name = "NumPadDel";
            this.NumPadDel.Size = new System.Drawing.Size(90, 90);
            this.NumPadDel.TabIndex = 9;
            this.NumPadDel.TabStop = false;
            this.NumPadDel.Click += new System.EventHandler(this.NumPadDel_Click);
            this.NumPadDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.NumPadDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np9
            // 
            this.np9.Image = ((System.Drawing.Image)(resources.GetObject("np9.Image")));
            this.np9.Location = new System.Drawing.Point(195, 199);
            this.np9.Name = "np9";
            this.np9.Size = new System.Drawing.Size(90, 90);
            this.np9.TabIndex = 8;
            this.np9.TabStop = false;
            this.np9.Click += new System.EventHandler(this.np1_Click);
            this.np9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np8
            // 
            this.np8.Image = ((System.Drawing.Image)(resources.GetObject("np8.Image")));
            this.np8.Location = new System.Drawing.Point(105, 199);
            this.np8.Name = "np8";
            this.np8.Size = new System.Drawing.Size(90, 90);
            this.np8.TabIndex = 7;
            this.np8.TabStop = false;
            this.np8.Click += new System.EventHandler(this.np1_Click);
            this.np8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np7
            // 
            this.np7.Image = ((System.Drawing.Image)(resources.GetObject("np7.Image")));
            this.np7.Location = new System.Drawing.Point(15, 199);
            this.np7.Name = "np7";
            this.np7.Size = new System.Drawing.Size(90, 90);
            this.np7.TabIndex = 6;
            this.np7.TabStop = false;
            this.np7.Click += new System.EventHandler(this.np1_Click);
            this.np7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np6
            // 
            this.np6.Image = ((System.Drawing.Image)(resources.GetObject("np6.Image")));
            this.np6.Location = new System.Drawing.Point(195, 109);
            this.np6.Name = "np6";
            this.np6.Size = new System.Drawing.Size(90, 90);
            this.np6.TabIndex = 5;
            this.np6.TabStop = false;
            this.np6.Click += new System.EventHandler(this.np1_Click);
            this.np6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np5
            // 
            this.np5.Image = ((System.Drawing.Image)(resources.GetObject("np5.Image")));
            this.np5.Location = new System.Drawing.Point(105, 109);
            this.np5.Name = "np5";
            this.np5.Size = new System.Drawing.Size(90, 90);
            this.np5.TabIndex = 4;
            this.np5.TabStop = false;
            this.np5.Click += new System.EventHandler(this.np1_Click);
            this.np5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np4
            // 
            this.np4.Image = ((System.Drawing.Image)(resources.GetObject("np4.Image")));
            this.np4.Location = new System.Drawing.Point(15, 109);
            this.np4.Name = "np4";
            this.np4.Size = new System.Drawing.Size(90, 90);
            this.np4.TabIndex = 3;
            this.np4.TabStop = false;
            this.np4.Click += new System.EventHandler(this.np1_Click);
            this.np4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np3
            // 
            this.np3.Image = ((System.Drawing.Image)(resources.GetObject("np3.Image")));
            this.np3.Location = new System.Drawing.Point(195, 19);
            this.np3.Name = "np3";
            this.np3.Size = new System.Drawing.Size(90, 90);
            this.np3.TabIndex = 2;
            this.np3.TabStop = false;
            this.np3.Click += new System.EventHandler(this.np1_Click);
            this.np3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np2
            // 
            this.np2.Image = ((System.Drawing.Image)(resources.GetObject("np2.Image")));
            this.np2.Location = new System.Drawing.Point(105, 19);
            this.np2.Name = "np2";
            this.np2.Size = new System.Drawing.Size(90, 90);
            this.np2.TabIndex = 1;
            this.np2.TabStop = false;
            this.np2.Click += new System.EventHandler(this.np1_Click);
            this.np2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // np1
            // 
            this.np1.Image = ((System.Drawing.Image)(resources.GetObject("np1.Image")));
            this.np1.Location = new System.Drawing.Point(15, 19);
            this.np1.Name = "np1";
            this.np1.Size = new System.Drawing.Size(90, 90);
            this.np1.TabIndex = 0;
            this.np1.TabStop = false;
            this.np1.Click += new System.EventHandler(this.np1_Click);
            this.np1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.np1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // cardNumber_textBox
            // 
            this.cardNumber_textBox.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumber_textBox.Location = new System.Drawing.Point(386, 126);
            this.cardNumber_textBox.Name = "cardNumber_textBox";
            this.cardNumber_textBox.ReadOnly = true;
            this.cardNumber_textBox.Size = new System.Drawing.Size(198, 30);
            this.cardNumber_textBox.TabIndex = 100;
            this.cardNumber_textBox.Click += new System.EventHandler(this.cardNumber_textBox_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.Image = global::Self_ServiceTerminal.Properties.Resources.acceptButton0;
            this.buttonAccept.Location = new System.Drawing.Point(386, 328);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(258, 81);
            this.buttonAccept.TabIndex = 119;
            this.buttonAccept.TabStop = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            this.buttonAccept.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.buttonAccept.MouseLeave += new System.EventHandler(this.buttonAccept_MouseLeave);
            this.buttonAccept.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseMove);
            this.buttonAccept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = global::Self_ServiceTerminal.Properties.Resources.back0;
            this.back_button.Location = new System.Drawing.Point(386, 415);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(256, 82);
            this.back_button.TabIndex = 118;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            this.back_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_button_MouseMove);
            this.back_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // insertCardNumber_label
            // 
            this.insertCardNumber_label.AutoSize = true;
            this.insertCardNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.insertCardNumber_label.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertCardNumber_label.ForeColor = System.Drawing.Color.White;
            this.insertCardNumber_label.Location = new System.Drawing.Point(383, 100);
            this.insertCardNumber_label.Name = "insertCardNumber_label";
            this.insertCardNumber_label.Size = new System.Drawing.Size(201, 23);
            this.insertCardNumber_label.TabIndex = 120;
            this.insertCardNumber_label.Text = "Введите номер карты";
            // 
            // cardOrCash_panel
            // 
            this.cardOrCash_panel.BackColor = System.Drawing.Color.Transparent;
            this.cardOrCash_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardOrCash_panel.BackgroundImage")));
            this.cardOrCash_panel.Controls.Add(this.cancel_pictureBox);
            this.cardOrCash_panel.Controls.Add(this.ok_pictureBox);
            this.cardOrCash_panel.Location = new System.Drawing.Point(380, 93);
            this.cardOrCash_panel.Name = "cardOrCash_panel";
            this.cardOrCash_panel.Size = new System.Drawing.Size(576, 400);
            this.cardOrCash_panel.TabIndex = 121;
            this.cardOrCash_panel.Visible = false;
            // 
            // cancel_pictureBox
            // 
            this.cancel_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cancel_pictureBox.Image")));
            this.cancel_pictureBox.Location = new System.Drawing.Point(406, 150);
            this.cancel_pictureBox.Name = "cancel_pictureBox";
            this.cancel_pictureBox.Size = new System.Drawing.Size(80, 80);
            this.cancel_pictureBox.TabIndex = 1;
            this.cancel_pictureBox.TabStop = false;
            this.cancel_pictureBox.Click += new System.EventHandler(this.cancel_pictureBox_Click);
            this.cancel_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.cancel_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // ok_pictureBox
            // 
            this.ok_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ok_pictureBox.Image")));
            this.ok_pictureBox.Location = new System.Drawing.Point(106, 150);
            this.ok_pictureBox.Name = "ok_pictureBox";
            this.ok_pictureBox.Size = new System.Drawing.Size(80, 80);
            this.ok_pictureBox.TabIndex = 0;
            this.ok_pictureBox.TabStop = false;
            this.ok_pictureBox.Click += new System.EventHandler(this.ok_pictureBox_Click);
            this.ok_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.ok_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // cash_radioButton
            // 
            this.cash_radioButton.AutoSize = true;
            this.cash_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.cash_radioButton.Checked = true;
            this.cash_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cash_radioButton.ForeColor = System.Drawing.Color.White;
            this.cash_radioButton.Location = new System.Drawing.Point(386, 162);
            this.cash_radioButton.Name = "cash_radioButton";
            this.cash_radioButton.Size = new System.Drawing.Size(199, 28);
            this.cash_radioButton.TabIndex = 2;
            this.cash_radioButton.TabStop = true;
            this.cash_radioButton.Text = "Оплата наличными";
            this.cash_radioButton.UseVisualStyleBackColor = false;
            this.cash_radioButton.Visible = false;
            // 
            // card_radioButton
            // 
            this.card_radioButton.AutoSize = true;
            this.card_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.card_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_radioButton.ForeColor = System.Drawing.Color.White;
            this.card_radioButton.Location = new System.Drawing.Point(386, 196);
            this.card_radioButton.Name = "card_radioButton";
            this.card_radioButton.Size = new System.Drawing.Size(161, 28);
            this.card_radioButton.TabIndex = 3;
            this.card_radioButton.Text = "Оплата картой";
            this.card_radioButton.UseVisualStyleBackColor = false;
            this.card_radioButton.Visible = false;
            // 
            // cardOperation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.card_radioButton);
            this.Controls.Add(this.insertCardNumber_label);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.cash_radioButton);
            this.Controls.Add(this.cardNumber_textBox);
            this.Controls.Add(this.NumPad);
            this.Controls.Add(this.cardOrCash_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(288, 38);
            this.Name = "cardOperation_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.cardOperation_form_Load);
            this.NumPad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumPadOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPadDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.cardOrCash_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancel_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox NumPad;
        public System.Windows.Forms.PictureBox NumPadOK;
        public System.Windows.Forms.PictureBox np0;
        public System.Windows.Forms.PictureBox NumPadDel;
        public System.Windows.Forms.PictureBox np9;
        public System.Windows.Forms.PictureBox np8;
        public System.Windows.Forms.PictureBox np7;
        public System.Windows.Forms.PictureBox np6;
        public System.Windows.Forms.PictureBox np5;
        public System.Windows.Forms.PictureBox np4;
        public System.Windows.Forms.PictureBox np3;
        public System.Windows.Forms.PictureBox np2;
        public System.Windows.Forms.PictureBox np1;
        private System.Windows.Forms.TextBox cardNumber_textBox;
        private System.Windows.Forms.PictureBox buttonAccept;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.Label insertCardNumber_label;
        private System.Windows.Forms.Panel cardOrCash_panel;
        private System.Windows.Forms.PictureBox cancel_pictureBox;
        private System.Windows.Forms.PictureBox ok_pictureBox;
        private System.Windows.Forms.RadioButton card_radioButton;
        private System.Windows.Forms.RadioButton cash_radioButton;
    }
}