namespace Self_ServiceTerminal
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.NumPad = new System.Windows.Forms.GroupBox();
            this.NumPadDel = new System.Windows.Forms.PictureBox();
            this.np0 = new System.Windows.Forms.PictureBox();
            this.np9 = new System.Windows.Forms.PictureBox();
            this.np8 = new System.Windows.Forms.PictureBox();
            this.np7 = new System.Windows.Forms.PictureBox();
            this.np6 = new System.Windows.Forms.PictureBox();
            this.np5 = new System.Windows.Forms.PictureBox();
            this.np4 = new System.Windows.Forms.PictureBox();
            this.np3 = new System.Windows.Forms.PictureBox();
            this.np2 = new System.Windows.Forms.PictureBox();
            this.np1 = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.NumPad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPadDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.np1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Font = new System.Drawing.Font("SF UI Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textbox.Location = new System.Drawing.Point(357, 197);
            this.password_textbox.MaxLength = 1;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.ReadOnly = true;
            this.password_textbox.Size = new System.Drawing.Size(234, 23);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // NumPad
            // 
            this.NumPad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NumPad.BackgroundImage")));
            this.NumPad.Controls.Add(this.NumPadDel);
            this.NumPad.Controls.Add(this.np0);
            this.NumPad.Controls.Add(this.np9);
            this.NumPad.Controls.Add(this.np8);
            this.NumPad.Controls.Add(this.np7);
            this.NumPad.Controls.Add(this.np6);
            this.NumPad.Controls.Add(this.np5);
            this.NumPad.Controls.Add(this.np4);
            this.NumPad.Controls.Add(this.np3);
            this.NumPad.Controls.Add(this.np2);
            this.NumPad.Controls.Add(this.np1);
            this.NumPad.Location = new System.Drawing.Point(727, 176);
            this.NumPad.Name = "NumPad";
            this.NumPad.Size = new System.Drawing.Size(300, 390);
            this.NumPad.TabIndex = 98;
            this.NumPad.TabStop = false;
            // 
            // NumPadDel
            // 
            this.NumPadDel.Image = ((System.Drawing.Image)(resources.GetObject("NumPadDel.Image")));
            this.NumPadDel.Location = new System.Drawing.Point(15, 289);
            this.NumPadDel.Name = "NumPadDel";
            this.NumPadDel.Size = new System.Drawing.Size(135, 90);
            this.NumPadDel.TabIndex = 11;
            this.NumPadDel.TabStop = false;
            this.NumPadDel.Click += new System.EventHandler(this.NumPadDel_Click);
            this.NumPadDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.NumPadDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np0
            // 
            this.np0.Image = ((System.Drawing.Image)(resources.GetObject("np0.Image")));
            this.np0.Location = new System.Drawing.Point(150, 289);
            this.np0.Name = "np0";
            this.np0.Size = new System.Drawing.Size(135, 90);
            this.np0.TabIndex = 10;
            this.np0.TabStop = false;
            this.np0.Click += new System.EventHandler(this.NumPad1_Click);
            this.np0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np9
            // 
            this.np9.Image = ((System.Drawing.Image)(resources.GetObject("np9.Image")));
            this.np9.Location = new System.Drawing.Point(195, 199);
            this.np9.Name = "np9";
            this.np9.Size = new System.Drawing.Size(90, 90);
            this.np9.TabIndex = 8;
            this.np9.TabStop = false;
            this.np9.Click += new System.EventHandler(this.NumPad1_Click);
            this.np9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np8
            // 
            this.np8.Image = ((System.Drawing.Image)(resources.GetObject("np8.Image")));
            this.np8.Location = new System.Drawing.Point(105, 199);
            this.np8.Name = "np8";
            this.np8.Size = new System.Drawing.Size(90, 90);
            this.np8.TabIndex = 7;
            this.np8.TabStop = false;
            this.np8.Click += new System.EventHandler(this.NumPad1_Click);
            this.np8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np7
            // 
            this.np7.Image = ((System.Drawing.Image)(resources.GetObject("np7.Image")));
            this.np7.Location = new System.Drawing.Point(15, 199);
            this.np7.Name = "np7";
            this.np7.Size = new System.Drawing.Size(90, 90);
            this.np7.TabIndex = 6;
            this.np7.TabStop = false;
            this.np7.Click += new System.EventHandler(this.NumPad1_Click);
            this.np7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np6
            // 
            this.np6.Image = ((System.Drawing.Image)(resources.GetObject("np6.Image")));
            this.np6.Location = new System.Drawing.Point(195, 109);
            this.np6.Name = "np6";
            this.np6.Size = new System.Drawing.Size(90, 90);
            this.np6.TabIndex = 5;
            this.np6.TabStop = false;
            this.np6.Click += new System.EventHandler(this.NumPad1_Click);
            this.np6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np5
            // 
            this.np5.Image = ((System.Drawing.Image)(resources.GetObject("np5.Image")));
            this.np5.Location = new System.Drawing.Point(105, 109);
            this.np5.Name = "np5";
            this.np5.Size = new System.Drawing.Size(90, 90);
            this.np5.TabIndex = 4;
            this.np5.TabStop = false;
            this.np5.Click += new System.EventHandler(this.NumPad1_Click);
            this.np5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np4
            // 
            this.np4.Image = ((System.Drawing.Image)(resources.GetObject("np4.Image")));
            this.np4.Location = new System.Drawing.Point(15, 109);
            this.np4.Name = "np4";
            this.np4.Size = new System.Drawing.Size(90, 90);
            this.np4.TabIndex = 3;
            this.np4.TabStop = false;
            this.np4.Click += new System.EventHandler(this.NumPad1_Click);
            this.np4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np3
            // 
            this.np3.Image = ((System.Drawing.Image)(resources.GetObject("np3.Image")));
            this.np3.Location = new System.Drawing.Point(195, 19);
            this.np3.Name = "np3";
            this.np3.Size = new System.Drawing.Size(90, 90);
            this.np3.TabIndex = 2;
            this.np3.TabStop = false;
            this.np3.Click += new System.EventHandler(this.NumPad1_Click);
            this.np3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np2
            // 
            this.np2.Image = ((System.Drawing.Image)(resources.GetObject("np2.Image")));
            this.np2.Location = new System.Drawing.Point(105, 19);
            this.np2.Name = "np2";
            this.np2.Size = new System.Drawing.Size(90, 90);
            this.np2.TabIndex = 1;
            this.np2.TabStop = false;
            this.np2.Click += new System.EventHandler(this.NumPad1_Click);
            this.np2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // np1
            // 
            this.np1.Image = ((System.Drawing.Image)(resources.GetObject("np1.Image")));
            this.np1.Location = new System.Drawing.Point(15, 19);
            this.np1.Name = "np1";
            this.np1.Size = new System.Drawing.Size(90, 90);
            this.np1.TabIndex = 0;
            this.np1.TabStop = false;
            this.np1.Click += new System.EventHandler(this.NumPad1_Click);
            this.np1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.np1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Enabled = false;
            this.login_button.Image = global::Self_ServiceTerminal.Properties.Resources.login_button;
            this.login_button.Location = new System.Drawing.Point(320, 258);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(282, 44);
            this.login_button.TabIndex = 0;
            this.login_button.TabStop = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            this.login_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.login_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Image = global::Self_ServiceTerminal.Properties.Resources.back0;
            this.back_button.Location = new System.Drawing.Point(12, 525);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(259, 75);
            this.back_button.TabIndex = 99;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseDown);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            this.back_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_button_MouseMove);
            this.back_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumPad1_MouseUp);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.NumPad);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(288, 38);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "login_form";
            this.NumPad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumPadDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.np1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox NumPad;
        public System.Windows.Forms.PictureBox np9;
        public System.Windows.Forms.PictureBox np8;
        public System.Windows.Forms.PictureBox np7;
        public System.Windows.Forms.PictureBox np6;
        public System.Windows.Forms.PictureBox np5;
        public System.Windows.Forms.PictureBox np4;
        public System.Windows.Forms.PictureBox np3;
        public System.Windows.Forms.PictureBox np2;
        public System.Windows.Forms.PictureBox np1;
        private System.Windows.Forms.PictureBox login_button;
        private System.Windows.Forms.PictureBox np0;
        private System.Windows.Forms.PictureBox NumPadDel;
        public System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.PictureBox back_button;
    }
}