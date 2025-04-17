namespace NimProject
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnLaw = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnStart.Location = new System.Drawing.Point(550, 575);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 81);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chế độ chơi";
            // 
            // cboMode
            // 
            this.cboMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "Chơi với máy",
            "Hai người chơi"});
            this.cboMode.Location = new System.Drawing.Point(751, 430);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(204, 37);
            this.cboMode.TabIndex = 1;
            this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::NimProject.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(339, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(410, 510);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(110, 33);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Cấp độ";
            // 
            // cboLevel
            // 
            this.cboLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Dễ",
            "Trung bình",
            "Khó"});
            this.cboLevel.Location = new System.Drawing.Point(751, 506);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(204, 37);
            this.cboLevel.TabIndex = 5;
            // 
            // btnLaw
            // 
            this.btnLaw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaw.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLaw.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaw.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLaw.Location = new System.Drawing.Point(550, 672);
            this.btnLaw.Name = "btnLaw";
            this.btnLaw.Size = new System.Drawing.Size(198, 81);
            this.btnLaw.TabIndex = 6;
            this.btnLaw.Text = "Cách chơi";
            this.btnLaw.UseVisualStyleBackColor = false;
            this.btnLaw.Click += new System.EventHandler(this.btnLaw_Click);
            this.btnLaw.MouseEnter += new System.EventHandler(this.btnLaw_MouseEnter);
            this.btnLaw.MouseLeave += new System.EventHandler(this.btnLaw_MouseLeave);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQuit.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnQuit.Location = new System.Drawing.Point(550, 785);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(198, 81);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // FormStart
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1358, 952);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLaw);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi NIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Button btnLaw;
        private System.Windows.Forms.Button btnQuit;
    }
}