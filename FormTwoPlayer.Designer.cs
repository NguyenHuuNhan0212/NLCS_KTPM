namespace NimProject
{
    partial class FormTwoPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTwoPlayer));
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numerPlayer1Move = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboPile2 = new System.Windows.Forms.ComboBox();
            this.numerPlayer2Move = new System.Windows.Forms.NumericUpDown();
            this.pnlPilesContainer5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.pnlPilesContainer4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPilesContainer3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPilesContainer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlayer1Move = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlayer2Move = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTimePlayer1 = new System.Windows.Forms.Label();
            this.lblTimePlayer2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cboPile1 = new System.Windows.Forms.ComboBox();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayer1Move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayer2Move)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHistory
            // 
            this.lstHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(458, 687);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(432, 224);
            this.lstHistory.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstHistory, "Lịch sử lượt chơi");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 709);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn chồng gạch";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 770);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số viên gạch lấy";
            // 
            // numerPlayer1Move
            // 
            this.numerPlayer1Move.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numerPlayer1Move.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerPlayer1Move.Location = new System.Drawing.Point(241, 766);
            this.numerPlayer1Move.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numerPlayer1Move.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerPlayer1Move.Name = "numerPlayer1Move";
            this.numerPlayer1Move.Size = new System.Drawing.Size(200, 37);
            this.numerPlayer1Move.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numerPlayer1Move, "Số viên gạch cần lấy");
            this.numerPlayer1Move.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboPile2
            // 
            this.cboPile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPile2.FormattingEnabled = true;
            this.cboPile2.Location = new System.Drawing.Point(1115, 703);
            this.cboPile2.Name = "cboPile2";
            this.cboPile2.Size = new System.Drawing.Size(200, 38);
            this.cboPile2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cboPile2, "Chọn chồng gạch");
            // 
            // numerPlayer2Move
            // 
            this.numerPlayer2Move.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numerPlayer2Move.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerPlayer2Move.Location = new System.Drawing.Point(1115, 765);
            this.numerPlayer2Move.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numerPlayer2Move.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerPlayer2Move.Name = "numerPlayer2Move";
            this.numerPlayer2Move.Size = new System.Drawing.Size(200, 37);
            this.numerPlayer2Move.TabIndex = 11;
            this.toolTip1.SetToolTip(this.numerPlayer2Move, "Số viên gạch lấy");
            this.numerPlayer2Move.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlPilesContainer5
            // 
            this.pnlPilesContainer5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainer5.AutoSize = true;
            this.pnlPilesContainer5.Location = new System.Drawing.Point(113, 51);
            this.pnlPilesContainer5.Name = "pnlPilesContainer5";
            this.pnlPilesContainer5.Size = new System.Drawing.Size(1157, 567);
            this.pnlPilesContainer5.TabIndex = 14;
            this.toolTip1.SetToolTip(this.pnlPilesContainer5, "Minh họa các chồng gạch");
            this.pnlPilesContainer5.WrapContents = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::NimProject.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 70);
            this.btnLogOut.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnLogOut, "Về trang chính");
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupport.BackgroundImage = global::NimProject.Properties.Resources.question;
            this.btnSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupport.Location = new System.Drawing.Point(1276, 12);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(75, 70);
            this.btnSupport.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnSupport, "Thông tin");
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // pnlPilesContainer4
            // 
            this.pnlPilesContainer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainer4.AutoSize = true;
            this.pnlPilesContainer4.Location = new System.Drawing.Point(225, 41);
            this.pnlPilesContainer4.Name = "pnlPilesContainer4";
            this.pnlPilesContainer4.Size = new System.Drawing.Size(959, 585);
            this.pnlPilesContainer4.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlPilesContainer4, "Minh họa các chồng gạch");
            // 
            // pnlPilesContainer3
            // 
            this.pnlPilesContainer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainer3.AutoSize = true;
            this.pnlPilesContainer3.Location = new System.Drawing.Point(317, 31);
            this.pnlPilesContainer3.Name = "pnlPilesContainer3";
            this.pnlPilesContainer3.Size = new System.Drawing.Size(785, 587);
            this.pnlPilesContainer3.TabIndex = 18;
            this.toolTip1.SetToolTip(this.pnlPilesContainer3, "Minh họa các chồng gạch");
            // 
            // pnlPilesContainer2
            // 
            this.pnlPilesContainer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainer2.AutoSize = true;
            this.pnlPilesContainer2.Location = new System.Drawing.Point(412, 41);
            this.pnlPilesContainer2.Name = "pnlPilesContainer2";
            this.pnlPilesContainer2.Size = new System.Drawing.Size(563, 585);
            this.pnlPilesContainer2.TabIndex = 19;
            this.toolTip1.SetToolTip(this.pnlPilesContainer2, "Minh họa các chồng gạch");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lịch sử chơi:";
            // 
            // btnPlayer1Move
            // 
            this.btnPlayer1Move.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayer1Move.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlayer1Move.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1Move.Location = new System.Drawing.Point(154, 882);
            this.btnPlayer1Move.Name = "btnPlayer1Move";
            this.btnPlayer1Move.Size = new System.Drawing.Size(140, 50);
            this.btnPlayer1Move.TabIndex = 7;
            this.btnPlayer1Move.Text = "Lấy";
            this.btnPlayer1Move.UseVisualStyleBackColor = false;
            this.btnPlayer1Move.Click += new System.EventHandler(this.btnPlayer1Move_Click);
            this.btnPlayer1Move.MouseEnter += new System.EventHandler(this.btnPlayer1Move_MouseEnter);
            this.btnPlayer1Move.MouseLeave += new System.EventHandler(this.btnPlayer1Move_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(896, 713);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chọn chồng gạch";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 774);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số viên gạch lấy";
            // 
            // btnPlayer2Move
            // 
            this.btnPlayer2Move.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayer2Move.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlayer2Move.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2Move.Location = new System.Drawing.Point(1080, 882);
            this.btnPlayer2Move.Name = "btnPlayer2Move";
            this.btnPlayer2Move.Size = new System.Drawing.Size(140, 50);
            this.btnPlayer2Move.TabIndex = 12;
            this.btnPlayer2Move.Text = "Lấy";
            this.btnPlayer2Move.UseVisualStyleBackColor = false;
            this.btnPlayer2Move.Click += new System.EventHandler(this.btnPlayer2Move_Click);
            this.btnPlayer2Move.MouseEnter += new System.EventHandler(this.btnPlayer2Move_MouseEnter);
            this.btnPlayer2Move.MouseLeave += new System.EventHandler(this.btnPlayer2Move_MouseLeave);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Tomato;
            this.lblPlayer1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPlayer1.Location = new System.Drawing.Point(276, 656);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(80, 28);
            this.lblPlayer1.TabIndex = 15;
            this.lblPlayer1.Text = "label6";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Tomato;
            this.lblPlayer2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPlayer2.Location = new System.Drawing.Point(951, 656);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(80, 28);
            this.lblPlayer2.TabIndex = 16;
            this.lblPlayer2.Text = "label6";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Người chơi 1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1154, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Người chơi 2";
            // 
            // lblTimePlayer1
            // 
            this.lblTimePlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimePlayer1.AutoSize = true;
            this.lblTimePlayer1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlayer1.Location = new System.Drawing.Point(166, 828);
            this.lblTimePlayer1.Name = "lblTimePlayer1";
            this.lblTimePlayer1.Size = new System.Drawing.Size(99, 37);
            this.lblTimePlayer1.TabIndex = 22;
            this.lblTimePlayer1.Text = "00:00";
            // 
            // lblTimePlayer2
            // 
            this.lblTimePlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimePlayer2.AutoSize = true;
            this.lblTimePlayer2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlayer2.Location = new System.Drawing.Point(1093, 828);
            this.lblTimePlayer2.Name = "lblTimePlayer2";
            this.lblTimePlayer2.Size = new System.Drawing.Size(99, 37);
            this.lblTimePlayer2.TabIndex = 23;
            this.lblTimePlayer2.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cboPile1
            // 
            this.cboPile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPile1.FormattingEnabled = true;
            this.cboPile1.Location = new System.Drawing.Point(241, 709);
            this.cboPile1.Name = "cboPile1";
            this.cboPile1.Size = new System.Drawing.Size(200, 38);
            this.cboPile1.TabIndex = 24;
            // 
            // blinkTimer
            // 
            this.blinkTimer.Interval = 500;
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // FormTwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1363, 952);
            this.Controls.Add(this.cboPile1);
            this.Controls.Add(this.lblTimePlayer2);
            this.Controls.Add(this.lblTimePlayer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlPilesContainer2);
            this.Controls.Add(this.pnlPilesContainer3);
            this.Controls.Add(this.pnlPilesContainer4);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pnlPilesContainer5);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnPlayer2Move);
            this.Controls.Add(this.numerPlayer2Move);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPile2);
            this.Controls.Add(this.btnPlayer1Move);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numerPlayer1Move);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTwoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hai người chơi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTwoPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTwoPlayer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayer1Move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayer2Move)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numerPlayer1Move;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlayer1Move;
        private System.Windows.Forms.ComboBox cboPile2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numerPlayer2Move;
        private System.Windows.Forms.Button btnPlayer2Move;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainer5;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainer4;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainer3;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimePlayer1;
        private System.Windows.Forms.Label lblTimePlayer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox cboPile1;
        private System.Windows.Forms.Timer blinkTimer;
    }
}