namespace Self_ServiceTerminal
{
    partial class travolta
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
            this.emotion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emotion)).BeginInit();
            this.SuspendLayout();
            // 
            // emotion
            // 
            this.emotion.Image = global::Self_ServiceTerminal.Properties.Resources.LOSE;
            this.emotion.Location = new System.Drawing.Point(3, -7);
            this.emotion.Name = "emotion";
            this.emotion.Size = new System.Drawing.Size(411, 476);
            this.emotion.TabIndex = 0;
            this.emotion.TabStop = false;
            // 
            // travolta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(408, 468);
            this.Controls.Add(this.emotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(93, 296);
            this.Name = "travolta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "travolta";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.travolta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox emotion;
    }
}