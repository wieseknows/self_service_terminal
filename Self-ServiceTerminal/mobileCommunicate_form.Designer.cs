namespace Self_ServiceTerminal
{
    partial class mobileCommunicate_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobileCommunicate_form));
            this.keyboard_ico = new System.Windows.Forms.PictureBox();
            this.labelInsertPayerFIO = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.WriteNumber_label = new System.Windows.Forms.Label();
            this.payerFIO_textbox = new System.Windows.Forms.TextBox();
            this.MobileNumber_textbox = new System.Windows.Forms.TextBox();
            this.MobileMts = new System.Windows.Forms.RadioButton();
            this.MobileVelcom = new System.Windows.Forms.RadioButton();
            this.MobileLife = new System.Windows.Forms.RadioButton();
            this.OperatorLife_image = new System.Windows.Forms.PictureBox();
            this.OperatorMTC_image = new System.Windows.Forms.PictureBox();
            this.OperatorVelcom_image = new System.Windows.Forms.PictureBox();
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
            this.workPanel_mobileCommunicate = new System.Windows.Forms.PictureBox();
            this.operatorCode_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyboard_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorLife_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorMTC_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorVelcom_image)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.workPanel_mobileCommunicate)).BeginInit();
            this.SuspendLayout();
            // 
            // keyboard_ico
            // 
            this.keyboard_ico.BackColor = System.Drawing.SystemColors.Window;
            this.keyboard_ico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboard_ico.Image = ((System.Drawing.Image)(resources.GetObject("keyboard_ico.Image")));
            this.keyboard_ico.Location = new System.Drawing.Point(404, 115);
            this.keyboard_ico.Name = "keyboard_ico";
            this.keyboard_ico.Size = new System.Drawing.Size(29, 35);
            this.keyboard_ico.TabIndex = 109;
            this.keyboard_ico.TabStop = false;
            this.keyboard_ico.Click += new System.EventHandler(this.keyboard_ico_Click);
            this.keyboard_ico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.keyboard_ico.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // labelInsertPayerFIO
            // 
            this.labelInsertPayerFIO.AutoSize = true;
            this.labelInsertPayerFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.labelInsertPayerFIO.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInsertPayerFIO.ForeColor = System.Drawing.Color.Transparent;
            this.labelInsertPayerFIO.Location = new System.Drawing.Point(47, 76);
            this.labelInsertPayerFIO.Name = "labelInsertPayerFIO";
            this.labelInsertPayerFIO.Size = new System.Drawing.Size(289, 25);
            this.labelInsertPayerFIO.TabIndex = 107;
            this.labelInsertPayerFIO.Text = "Введите имя плательщика";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::Self_ServiceTerminal.Properties.Resources.back0;
            this.Back.Location = new System.Drawing.Point(27, 512);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(264, 98);
            this.Back.TabIndex = 83;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.np1_MouseDown);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            this.Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Back_MouseMove);
            this.Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.np1_MouseUp);
            // 
            // WriteNumber_label
            // 
            this.WriteNumber_label.AutoSize = true;
            this.WriteNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.WriteNumber_label.Font = new System.Drawing.Font("SF UI Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteNumber_label.ForeColor = System.Drawing.Color.White;
            this.WriteNumber_label.Location = new System.Drawing.Point(732, 37);
            this.WriteNumber_label.Name = "WriteNumber_label";
            this.WriteNumber_label.Size = new System.Drawing.Size(279, 25);
            this.WriteNumber_label.TabIndex = 108;
            this.WriteNumber_label.Text = "Введите номер телефона";
            // 
            // payerFIO_textbox
            // 
            this.payerFIO_textbox.Font = new System.Drawing.Font("SF UI Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payerFIO_textbox.Location = new System.Drawing.Point(52, 115);
            this.payerFIO_textbox.Name = "payerFIO_textbox";
            this.payerFIO_textbox.ReadOnly = true;
            this.payerFIO_textbox.Size = new System.Drawing.Size(381, 35);
            this.payerFIO_textbox.TabIndex = 105;
            // 
            // MobileNumber_textbox
            // 
            this.MobileNumber_textbox.Font = new System.Drawing.Font("SF UI Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobileNumber_textbox.Location = new System.Drawing.Point(812, 62);
            this.MobileNumber_textbox.MaxLength = 0;
            this.MobileNumber_textbox.Name = "MobileNumber_textbox";
            this.MobileNumber_textbox.ReadOnly = true;
            this.MobileNumber_textbox.Size = new System.Drawing.Size(225, 42);
            this.MobileNumber_textbox.TabIndex = 104;
            // 
            // MobileMts
            // 
            this.MobileMts.AutoSize = true;
            this.MobileMts.BackColor = System.Drawing.Color.Transparent;
            this.MobileMts.Font = new System.Drawing.Font("SF UI Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobileMts.ForeColor = System.Drawing.Color.White;
            this.MobileMts.Location = new System.Drawing.Point(546, 193);
            this.MobileMts.Name = "MobileMts";
            this.MobileMts.Size = new System.Drawing.Size(65, 23);
            this.MobileMts.TabIndex = 103;
            this.MobileMts.Text = "MTC";
            this.MobileMts.UseVisualStyleBackColor = false;
            this.MobileMts.CheckedChanged += new System.EventHandler(this.MobileLife_CheckedChanged);
            // 
            // MobileVelcom
            // 
            this.MobileVelcom.AutoSize = true;
            this.MobileVelcom.BackColor = System.Drawing.Color.Transparent;
            this.MobileVelcom.Font = new System.Drawing.Font("SF UI Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobileVelcom.ForeColor = System.Drawing.Color.White;
            this.MobileVelcom.Location = new System.Drawing.Point(546, 283);
            this.MobileVelcom.Name = "MobileVelcom";
            this.MobileVelcom.Size = new System.Drawing.Size(87, 23);
            this.MobileVelcom.TabIndex = 102;
            this.MobileVelcom.Text = "Velcom";
            this.MobileVelcom.UseVisualStyleBackColor = false;
            this.MobileVelcom.CheckedChanged += new System.EventHandler(this.MobileLife_CheckedChanged);
            // 
            // MobileLife
            // 
            this.MobileLife.AutoSize = true;
            this.MobileLife.BackColor = System.Drawing.Color.Transparent;
            this.MobileLife.Checked = true;
            this.MobileLife.Font = new System.Drawing.Font("SF UI Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobileLife.ForeColor = System.Drawing.Color.White;
            this.MobileLife.Location = new System.Drawing.Point(546, 94);
            this.MobileLife.Name = "MobileLife";
            this.MobileLife.Size = new System.Drawing.Size(75, 23);
            this.MobileLife.TabIndex = 101;
            this.MobileLife.TabStop = true;
            this.MobileLife.Text = "Life :)";
            this.MobileLife.UseVisualStyleBackColor = false;
            this.MobileLife.CheckedChanged += new System.EventHandler(this.MobileLife_CheckedChanged);
            // 
            // OperatorLife_image
            // 
            this.OperatorLife_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperatorLife_image.Image = ((System.Drawing.Image)(resources.GetObject("OperatorLife_image.Image")));
            this.OperatorLife_image.Location = new System.Drawing.Point(450, 62);
            this.OperatorLife_image.Name = "OperatorLife_image";
            this.OperatorLife_image.Size = new System.Drawing.Size(90, 90);
            this.OperatorLife_image.TabIndex = 98;
            this.OperatorLife_image.TabStop = false;
            // 
            // OperatorMTC_image
            // 
            this.OperatorMTC_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperatorMTC_image.Image = ((System.Drawing.Image)(resources.GetObject("OperatorMTC_image.Image")));
            this.OperatorMTC_image.Location = new System.Drawing.Point(450, 158);
            this.OperatorMTC_image.Name = "OperatorMTC_image";
            this.OperatorMTC_image.Size = new System.Drawing.Size(90, 90);
            this.OperatorMTC_image.TabIndex = 99;
            this.OperatorMTC_image.TabStop = false;
            // 
            // OperatorVelcom_image
            // 
            this.OperatorVelcom_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperatorVelcom_image.Image = ((System.Drawing.Image)(resources.GetObject("OperatorVelcom_image.Image")));
            this.OperatorVelcom_image.Location = new System.Drawing.Point(450, 254);
            this.OperatorVelcom_image.Name = "OperatorVelcom_image";
            this.OperatorVelcom_image.Size = new System.Drawing.Size(90, 90);
            this.OperatorVelcom_image.TabIndex = 100;
            this.OperatorVelcom_image.TabStop = false;
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
            this.NumPad.Location = new System.Drawing.Point(737, 115);
            this.NumPad.Name = "NumPad";
            this.NumPad.Size = new System.Drawing.Size(300, 390);
            this.NumPad.TabIndex = 97;
            this.NumPad.TabStop = false;
            // 
            // NumPadOK
            // 
            this.NumPadOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumPadOK.Image = ((System.Drawing.Image)(resources.GetObject("NumPadOK.Image")));
            this.NumPadOK.Location = new System.Drawing.Point(195, 289);
            this.NumPadOK.Name = "NumPadOK";
            this.NumPadOK.Size = new System.Drawing.Size(90, 90);
            this.NumPadOK.TabIndex = 11;
            this.NumPadOK.TabStop = false;
            this.NumPadOK.Click += new System.EventHandler(this.NumPadOK_Click);
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
            // workPanel_mobileCommunicate
            // 
            this.workPanel_mobileCommunicate.Image = ((System.Drawing.Image)(resources.GetObject("workPanel_mobileCommunicate.Image")));
            this.workPanel_mobileCommunicate.Location = new System.Drawing.Point(27, 62);
            this.workPanel_mobileCommunicate.Name = "workPanel_mobileCommunicate";
            this.workPanel_mobileCommunicate.Size = new System.Drawing.Size(417, 444);
            this.workPanel_mobileCommunicate.TabIndex = 110;
            this.workPanel_mobileCommunicate.TabStop = false;
            // 
            // operatorCode_comboBox
            // 
            this.operatorCode_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorCode_comboBox.Font = new System.Drawing.Font("SF UI Display", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorCode_comboBox.FormattingEnabled = true;
            this.operatorCode_comboBox.Location = new System.Drawing.Point(737, 62);
            this.operatorCode_comboBox.Name = "operatorCode_comboBox";
            this.operatorCode_comboBox.Size = new System.Drawing.Size(69, 42);
            this.operatorCode_comboBox.TabIndex = 111;
            // 
            // mobileCommunicate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.operatorCode_comboBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.keyboard_ico);
            this.Controls.Add(this.WriteNumber_label);
            this.Controls.Add(this.MobileNumber_textbox);
            this.Controls.Add(this.labelInsertPayerFIO);
            this.Controls.Add(this.NumPad);
            this.Controls.Add(this.MobileMts);
            this.Controls.Add(this.payerFIO_textbox);
            this.Controls.Add(this.MobileVelcom);
            this.Controls.Add(this.MobileLife);
            this.Controls.Add(this.OperatorVelcom_image);
            this.Controls.Add(this.OperatorLife_image);
            this.Controls.Add(this.OperatorMTC_image);
            this.Controls.Add(this.workPanel_mobileCommunicate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(288, 38);
            this.Name = "mobileCommunicate_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mobileCommunicate_form_FormClosing);
            this.Load += new System.EventHandler(this.mobileCommunicate_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyboard_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorLife_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorMTC_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorVelcom_image)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.workPanel_mobileCommunicate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox keyboard_ico;
        public System.Windows.Forms.Label labelInsertPayerFIO;
        public System.Windows.Forms.PictureBox Back;
        public System.Windows.Forms.Label WriteNumber_label;
        public System.Windows.Forms.TextBox payerFIO_textbox;
        public System.Windows.Forms.TextBox MobileNumber_textbox;
        public System.Windows.Forms.RadioButton MobileMts;
        public System.Windows.Forms.RadioButton MobileVelcom;
        public System.Windows.Forms.RadioButton MobileLife;
        public System.Windows.Forms.PictureBox OperatorLife_image;
        public System.Windows.Forms.PictureBox OperatorMTC_image;
        public System.Windows.Forms.PictureBox OperatorVelcom_image;
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
        private System.Windows.Forms.PictureBox workPanel_mobileCommunicate;
        private System.Windows.Forms.ComboBox operatorCode_comboBox;
    }
}