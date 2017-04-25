namespace Self_ServiceTerminal
{
    partial class onlineGames_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onlineGames_form));
            this.HS = new System.Windows.Forms.PictureBox();
            this.WF = new System.Windows.Forms.PictureBox();
            this.steam = new System.Windows.Forms.PictureBox();
            this.WOT = new System.Windows.Forms.PictureBox();
            this.accountName_label = new System.Windows.Forms.Label();
            this.accountName_textbox = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.currentGame_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGame_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HS
            // 
            this.HS.BackColor = System.Drawing.Color.Transparent;
            this.HS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HS.Image = ((System.Drawing.Image)(resources.GetObject("HS.Image")));
            this.HS.Location = new System.Drawing.Point(12, 116);
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(121, 121);
            this.HS.TabIndex = 0;
            this.HS.TabStop = false;
            this.HS.Click += new System.EventHandler(this.HS_Click);
            this.HS.MouseLeave += new System.EventHandler(this.HS_MouseLeave);
            this.HS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HS_MouseMove);
            // 
            // WF
            // 
            this.WF.BackColor = System.Drawing.Color.Transparent;
            this.WF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WF.Image = ((System.Drawing.Image)(resources.GetObject("WF.Image")));
            this.WF.Location = new System.Drawing.Point(12, 243);
            this.WF.Name = "WF";
            this.WF.Size = new System.Drawing.Size(121, 121);
            this.WF.TabIndex = 1;
            this.WF.TabStop = false;
            this.WF.Click += new System.EventHandler(this.HS_Click);
            this.WF.MouseLeave += new System.EventHandler(this.HS_MouseLeave);
            this.WF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HS_MouseMove);
            // 
            // steam
            // 
            this.steam.BackColor = System.Drawing.Color.Transparent;
            this.steam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.steam.Image = ((System.Drawing.Image)(resources.GetObject("steam.Image")));
            this.steam.Location = new System.Drawing.Point(12, 370);
            this.steam.Name = "steam";
            this.steam.Size = new System.Drawing.Size(121, 121);
            this.steam.TabIndex = 1;
            this.steam.TabStop = false;
            this.steam.Click += new System.EventHandler(this.HS_Click);
            this.steam.MouseLeave += new System.EventHandler(this.HS_MouseLeave);
            this.steam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HS_MouseMove);
            // 
            // WOT
            // 
            this.WOT.BackColor = System.Drawing.Color.Transparent;
            this.WOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WOT.Image = global::Self_ServiceTerminal.Properties.Resources.wot95;
            this.WOT.Location = new System.Drawing.Point(12, 497);
            this.WOT.Name = "WOT";
            this.WOT.Size = new System.Drawing.Size(121, 121);
            this.WOT.TabIndex = 2;
            this.WOT.TabStop = false;
            this.WOT.Click += new System.EventHandler(this.HS_Click);
            this.WOT.MouseLeave += new System.EventHandler(this.HS_MouseLeave);
            this.WOT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HS_MouseMove);
            // 
            // accountName_label
            // 
            this.accountName_label.AutoSize = true;
            this.accountName_label.BackColor = System.Drawing.Color.Transparent;
            this.accountName_label.Font = new System.Drawing.Font("SF UI Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountName_label.ForeColor = System.Drawing.Color.White;
            this.accountName_label.Location = new System.Drawing.Point(440, 216);
            this.accountName_label.Name = "accountName_label";
            this.accountName_label.Size = new System.Drawing.Size(245, 25);
            this.accountName_label.TabIndex = 3;
            this.accountName_label.Text = "Введите имя аккаунта";
            this.accountName_label.Visible = false;
            // 
            // accountName_textbox
            // 
            this.accountName_textbox.Font = new System.Drawing.Font("SF UI Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountName_textbox.Location = new System.Drawing.Point(435, 244);
            this.accountName_textbox.Name = "accountName_textbox";
            this.accountName_textbox.ReadOnly = true;
            this.accountName_textbox.Size = new System.Drawing.Size(261, 33);
            this.accountName_textbox.TabIndex = 4;
            this.accountName_textbox.Visible = false;
            this.accountName_textbox.Click += new System.EventHandler(this.accountName_textbox_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.Image = global::Self_ServiceTerminal.Properties.Resources.acceptButton0;
            this.buttonAccept.Location = new System.Drawing.Point(435, 283);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(261, 81);
            this.buttonAccept.TabIndex = 24;
            this.buttonAccept.TabStop = false;
            this.buttonAccept.Visible = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            this.buttonAccept.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseDown);
            this.buttonAccept.MouseLeave += new System.EventHandler(this.buttonAccept_MouseLeave);
            this.buttonAccept.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseMove);
            this.buttonAccept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseUp);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = global::Self_ServiceTerminal.Properties.Resources.back0;
            this.back_button.Location = new System.Drawing.Point(435, 497);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(259, 82);
            this.back_button.TabIndex = 113;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            this.back_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseDown);
            this.back_button.MouseLeave += new System.EventHandler(this.back_button_MouseLeave);
            this.back_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_button_MouseMove);
            this.back_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAccept_MouseUp);
            // 
            // currentGame_pictureBox
            // 
            this.currentGame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.currentGame_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentGame_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("currentGame_pictureBox.Image")));
            this.currentGame_pictureBox.Location = new System.Drawing.Point(507, 92);
            this.currentGame_pictureBox.Name = "currentGame_pictureBox";
            this.currentGame_pictureBox.Size = new System.Drawing.Size(121, 121);
            this.currentGame_pictureBox.TabIndex = 114;
            this.currentGame_pictureBox.TabStop = false;
            this.currentGame_pictureBox.Visible = false;
            // 
            // onlineGames_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Self_ServiceTerminal.Properties.Resources.games_final;
            this.ClientSize = new System.Drawing.Size(1049, 622);
            this.Controls.Add(this.currentGame_pictureBox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.accountName_textbox);
            this.Controls.Add(this.accountName_label);
            this.Controls.Add(this.WOT);
            this.Controls.Add(this.steam);
            this.Controls.Add(this.WF);
            this.Controls.Add(this.HS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(288, 38);
            this.Name = "onlineGames_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.onlineGames_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGame_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HS;
        private System.Windows.Forms.PictureBox WF;
        private System.Windows.Forms.PictureBox steam;
        private System.Windows.Forms.PictureBox WOT;
        private System.Windows.Forms.Label accountName_label;
        private System.Windows.Forms.PictureBox buttonAccept;
        public System.Windows.Forms.TextBox accountName_textbox;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.PictureBox currentGame_pictureBox;
    }
}