using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimProject
{
    public partial class FormStart : Form
    {
        String[] levelPlayer = { "2 chồng", "3 chồng", "4 chồng", "5 chồng" };
        String[] levelComputer = { "Dễ", "Trung bình", "Khó" };
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int indexMode = cboMode.SelectedIndex;
           if(indexMode == -1)
            {
                MessageBox.Show("Vui lòng chọn chế độ chơi", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (indexMode == 0) 
            {
                int indexLevel = cboLevel.SelectedIndex;
                if (indexLevel == -1) {
                    MessageBox.Show("Vui lòng chọn cấp độ", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    FormPlayWithComputer formPlayWithComputer = new FormPlayWithComputer(indexLevel);
                    this.Hide();
                    formPlayWithComputer.Show();
                }
            }
           else
            {
                int indexLevel = cboLevel.SelectedIndex;
                if (indexLevel == -1) {
                    MessageBox.Show("Vui lòng chọn số lượng chồng gạch", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormTwoPlayer formTwoPlayer = new FormTwoPlayer(indexLevel);
                    this.Hide();
                    formTwoPlayer.Show();
                }
               
            }
        }
        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
           System.IO.File.Delete("state_game.txt");
           System.IO.File.Delete("state_game_two_player.txt");
           Application.Exit();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            cboMode.SelectedIndex = 0;
            cboLevel.SelectedIndex = 0;
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMode = cboMode.SelectedIndex;
            if (indexMode == 1) { 
                lblLevel.Text = "Số lượng chồng gạch";
                cboLevel.Items.Clear();
                cboLevel.Items.AddRange(levelPlayer);
                cboLevel.SelectedIndex = 0;
            }
            else
            {
                lblLevel.Text = "Cấp độ";
                cboLevel.Items.Clear();
                cboLevel.Items.AddRange(levelComputer);
                cboLevel.SelectedIndex = 0;
            }
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Green;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.DarkGreen;
        }

        private void btnLaw_MouseEnter(object sender, EventArgs e)
        {
            btnLaw.BackColor = Color.Green;
        }

        private void btnLaw_MouseLeave(object sender, EventArgs e)
        {
            btnLaw.BackColor = Color.DarkGreen;
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.Green;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.DarkGreen;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ ?", "Xác nhận thoát!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) {
                Application.Exit();
            }
           
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
           HowToPlay FormLaw = new HowToPlay();
            FormLaw.ShowDialog();
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kiem tra  su kien dong form khi nhan X , ALT F4
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ ?", "Xác nhận thoát!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    System.IO.File.Delete("state_game.txt");
                    System.IO.File.Delete("state_game_two_player.txt");
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
