namespace NimProject
{
    partial class FormPlayWithComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayWithComputer));
            this.lblPile2 = new System.Windows.Forms.Label();
            this.cboPile = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.numerPlayerMove = new System.Windows.Forms.NumericUpDown();
            this.pnlPilesContainerKho = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPilesContainerTB = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPilesContainerDe = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnPlayerMove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPile = new System.Windows.Forms.Label();
            this.lblSoQue = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblLuotChoi = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayerMove)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPile2
            // 
            this.lblPile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPile2.AutoSize = true;
            this.lblPile2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPile2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPile2.ForeColor = System.Drawing.Color.Red;
            this.lblPile2.Location = new System.Drawing.Point(622, 280);
            this.lblPile2.Name = "lblPile2";
            this.lblPile2.Size = new System.Drawing.Size(0, 33);
            this.lblPile2.TabIndex = 1;
            // 
            // cboPile
            // 
            this.cboPile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPile.BackColor = System.Drawing.SystemColors.Window;
            this.cboPile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPile.FormattingEnabled = true;
            this.cboPile.IntegralHeight = false;
            this.cboPile.Items.AddRange(new object[] {
            "chồng que 1",
            "chồng que 2",
            "chồng que 3"});
            this.cboPile.Location = new System.Drawing.Point(991, 689);
            this.cboPile.Name = "cboPile";
            this.cboPile.Size = new System.Drawing.Size(195, 38);
            this.cboPile.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboPile, "Chọn chồng gạch");
            // 
            // lstHistory
            // 
            this.lstHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(194, 699);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(539, 222);
            this.lstHistory.TabIndex = 6;
            this.toolTip1.SetToolTip(this.lstHistory, "Lịch sử lượt chơi");
            // 
            // numerPlayerMove
            // 
            this.numerPlayerMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numerPlayerMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerPlayerMove.Location = new System.Drawing.Point(991, 746);
            this.numerPlayerMove.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numerPlayerMove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerPlayerMove.Name = "numerPlayerMove";
            this.numerPlayerMove.Size = new System.Drawing.Size(195, 37);
            this.numerPlayerMove.TabIndex = 13;
            this.numerPlayerMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.numerPlayerMove, "Số viên gạch muốn lấy");
            this.numerPlayerMove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlPilesContainerKho
            // 
            this.pnlPilesContainerKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainerKho.AutoScroll = true;
            this.pnlPilesContainerKho.AutoSize = true;
            this.pnlPilesContainerKho.Location = new System.Drawing.Point(116, 57);
            this.pnlPilesContainerKho.Name = "pnlPilesContainerKho";
            this.pnlPilesContainerKho.Size = new System.Drawing.Size(1128, 574);
            this.pnlPilesContainerKho.TabIndex = 12;
            this.toolTip1.SetToolTip(this.pnlPilesContainerKho, "Minh họa các chồng gạch");
            // 
            // pnlPilesContainerTB
            // 
            this.pnlPilesContainerTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainerTB.AutoSize = true;
            this.pnlPilesContainerTB.Location = new System.Drawing.Point(336, 43);
            this.pnlPilesContainerTB.Name = "pnlPilesContainerTB";
            this.pnlPilesContainerTB.Size = new System.Drawing.Size(751, 608);
            this.pnlPilesContainerTB.TabIndex = 18;
            this.toolTip1.SetToolTip(this.pnlPilesContainerTB, "Minh họa các chồng gạch");
            // 
            // pnlPilesContainerDe
            // 
            this.pnlPilesContainerDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPilesContainerDe.AutoSize = true;
            this.pnlPilesContainerDe.Location = new System.Drawing.Point(473, 25);
            this.pnlPilesContainerDe.Name = "pnlPilesContainerDe";
            this.pnlPilesContainerDe.Size = new System.Drawing.Size(566, 606);
            this.pnlPilesContainerDe.TabIndex = 19;
            this.toolTip1.SetToolTip(this.pnlPilesContainerDe, "Minh họa các chồng gạch");
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackgroundImage = global::NimProject.Properties.Resources.Help;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(1273, 106);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 70);
            this.btnHelp.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnHelp, "Gợi ý ");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
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
            this.btnSupport.BackColor = System.Drawing.Color.Transparent;
            this.btnSupport.BackgroundImage = global::NimProject.Properties.Resources.question;
            this.btnSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSupport.Location = new System.Drawing.Point(1273, 12);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(75, 70);
            this.btnSupport.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnSupport, "Thông tin");
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnPlayerMove
            // 
            this.btnPlayerMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayerMove.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlayerMove.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerMove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayerMove.Location = new System.Drawing.Point(1019, 864);
            this.btnPlayerMove.Name = "btnPlayerMove";
            this.btnPlayerMove.Size = new System.Drawing.Size(145, 57);
            this.btnPlayerMove.TabIndex = 5;
            this.btnPlayerMove.Text = "Lấy";
            this.btnPlayerMove.UseVisualStyleBackColor = false;
            this.btnPlayerMove.Click += new System.EventHandler(this.btnPlayerMove_Click_1);
            this.btnPlayerMove.MouseEnter += new System.EventHandler(this.btnPlayerMove_MouseEnter);
            this.btnPlayerMove.MouseLeave += new System.EventHandler(this.btnPlayerMove_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.LightGreen;
            this.btnReset.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(794, 864);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 57);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Chơi lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // lblPile
            // 
            this.lblPile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPile.AutoSize = true;
            this.lblPile.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPile.Location = new System.Drawing.Point(749, 699);
            this.lblPile.Name = "lblPile";
            this.lblPile.Size = new System.Drawing.Size(213, 28);
            this.lblPile.TabIndex = 10;
            this.lblPile.Text = "Chọn chồng gạch";
            // 
            // lblSoQue
            // 
            this.lblSoQue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoQue.AutoSize = true;
            this.lblSoQue.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoQue.Location = new System.Drawing.Point(754, 755);
            this.lblSoQue.Name = "lblSoQue";
            this.lblSoQue.Size = new System.Drawing.Size(208, 28);
            this.lblSoQue.TabIndex = 11;
            this.lblSoQue.Text = "Số viên muốn lấy";
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(189, 654);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(165, 28);
            this.lblHistory.TabIndex = 14;
            this.lblHistory.Text = "Lịch sử chơi:";
            // 
            // lblLuotChoi
            // 
            this.lblLuotChoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuotChoi.AutoSize = true;
            this.lblLuotChoi.BackColor = System.Drawing.Color.Tomato;
            this.lblLuotChoi.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuotChoi.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblLuotChoi.Location = new System.Drawing.Point(946, 644);
            this.lblLuotChoi.Name = "lblLuotChoi";
            this.lblLuotChoi.Size = new System.Drawing.Size(165, 28);
            this.lblLuotChoi.TabIndex = 21;
            this.lblLuotChoi.Text = "Lượt của bạn";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(929, 806);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 37);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "00:00";
            // 
            // FormPlayWithComputer
            // 
            this.AcceptButton = this.btnPlayerMove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1360, 952);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblLuotChoi);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlPilesContainerDe);
            this.Controls.Add(this.pnlPilesContainerTB);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.numerPlayerMove);
            this.Controls.Add(this.pnlPilesContainerKho);
            this.Controls.Add(this.lblSoQue);
            this.Controls.Add(this.lblPile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlayerMove);
            this.Controls.Add(this.cboPile);
            this.Controls.Add(this.lblPile2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlayWithComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chơi với máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayWithComputer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlayWithComputer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numerPlayerMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPile2;
        private System.Windows.Forms.ComboBox cboPile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPlayerMove;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPile;
        private System.Windows.Forms.Label lblSoQue;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainerKho;
        private System.Windows.Forms.NumericUpDown numerPlayerMove;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainerTB;
        private System.Windows.Forms.FlowLayoutPanel pnlPilesContainerDe;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblLuotChoi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
    }
}

