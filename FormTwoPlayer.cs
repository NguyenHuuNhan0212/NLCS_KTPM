using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NimProject
{
    public partial class FormTwoPlayer : Form
    {
        private int[] piles;
        private Random random = new Random();
        private bool player1Turn = true;
        private int numberOfPiles, seconds1, seconds2,  thinking1 = 0, thinking2 = 0, maxThinking = 15;
        private WindowsMediaPlayer player;
        bool isBlinking = false;
        bool blinkState = false;
        Color defaultColor = Color.Black;
        FormStart formStart = new FormStart();
        public FormTwoPlayer()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            InitializeGame();
        }
        public FormTwoPlayer(int index)
        {
            if(index == 0)
            {
                numberOfPiles = 2;
            }else if(index == 1)
            {
                numberOfPiles = 3;
            }else if(index == 2)
            {
                numberOfPiles = 4;
            }else
            {
                numberOfPiles = 5;
            }
            InitializeComponent();
            player = new WindowsMediaPlayer();
            InitializeGame();
        }
        public void playSound(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    if (player == null)
                    {
                        player = new WindowsMediaPlayer();
                    }
                    player.URL = path;
                    player.controls.play();
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void stopSound()
        {
            if (player != null)
            {
                player.controls.stop();
            }
        }
       private bool isGameOver()
        {
            foreach (int pile in piles) 
            {
                if (pile > 0)
                    return false;
            }
            return true;
        }
        private void checkGameOver(string lastPlayer, string path)
        {
            if (isGameOver())
            {
                playSound(path);
                timer1.Stop();
                timer2.Stop();
                lblPlayer1.Text = "";
                lblPlayer2.Text = "";
                lblTimePlayer1.Text = "";
                lblTimePlayer2.Text = "";
                updateUI();
                DialogResult result = MessageBox.Show($"{lastPlayer} chiến thắng !!!  \nBạn có muốn chơi tiếp không",
                    "CHIẾN THẮNG!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    stopSound();
                    InitializeGame();  
                }else
                {
                    stopSound();
                    System.IO.File.Delete("state_game_two_player.txt");
                    this.Close();
                    formStart.Show();
                }

            }
            else
            {
                updateUI();
            }
        }
        private void updateUI()
        {
            
            pnlPilesContainer5.Controls.Clear();
            pnlPilesContainer4.Controls.Clear();
            pnlPilesContainer3.Controls.Clear();
            pnlPilesContainer2.Controls.Clear();
            for (int i=0; i < piles.Length; i++)
            {
                FlowLayoutPanel pilePanel = new FlowLayoutPanel();
                pilePanel.FlowDirection = FlowDirection.TopDown;
                pilePanel.AutoSize = true;
                pilePanel.Width = 140;
                pilePanel.Height = 330;
                pilePanel.BorderStyle = BorderStyle.FixedSingle;
                pilePanel.BackColor = Color.LightBlue;
                pilePanel.Name = $"pile{i + 1}";
                for(int j=0; j < piles[i]; j++)
                {
                    Button btn = new Button();
                    btn.Width = 60;
                    btn.Height = 30;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Tomato;
                    btn.Enabled = false;
                    btn.Margin = new Padding(40, btn.Margin.Top, btn.Margin.Right, btn.Margin.Bottom);
                    btn.Text = "( ^ - ^ )";
                    pilePanel.Controls.Add(btn);
                }
                Label lbl = new Label();
                lbl.Text = $"          Chồng {i + 1}";
                lbl.AutoSize = true;
                lbl.Font = new Font("Arial", 10, FontStyle.Bold);
                
                Panel containerPanel = new Panel();
                containerPanel.AutoSize = true;
                containerPanel.Controls.Add(lbl);
                containerPanel.Controls.Add(pilePanel);
                pilePanel.Top = lbl.Bottom + 5;
                if(numberOfPiles == 2)
                {
                    pnlPilesContainer5.Hide();
                    pnlPilesContainer4.Hide();
                    pnlPilesContainer3.Hide();
                    pnlPilesContainer2.Controls.Add(containerPanel);
                }else if(numberOfPiles == 3)
                {
                    pnlPilesContainer5.Hide();
                    pnlPilesContainer4.Hide();
                    pnlPilesContainer2.Hide();
                    pnlPilesContainer3.Controls.Add(containerPanel);
                }else if(numberOfPiles == 4)
                {
                    pnlPilesContainer5.Hide();
                    pnlPilesContainer2.Hide();
                    pnlPilesContainer3.Hide();
                    pnlPilesContainer4.Controls.Add(containerPanel);
                }else
                {
                    pnlPilesContainer2.Hide();
                    pnlPilesContainer4.Hide();
                    pnlPilesContainer3.Hide();
                    pnlPilesContainer5.Controls.Add(containerPanel);
                }
                
            }
        }
        private void InitializeGame()
        {

            seconds1 = seconds2 = 15;
            lblTimePlayer1.Text = lblTimePlayer2.Text = "00:15";
            timer1.Stop();
            timer2.Stop();
            int player = random.Next(1, 3);
            if (player == 1)
            {
                player1Turn = true;
                timer1.Start();
            }
            else
            {
                player1Turn = false;
                timer2.Start();
            }

            piles = new int[numberOfPiles];
            for(int i=0; i < numberOfPiles; i++)
            {
                piles[i] = random.Next(1, 10);

            }
            saveStateGame("Khởi tạo");
            updateUI();
            lstHistory.Items.Clear();
            cboPile1.Items.Clear();
            cboPile2.Items.Clear();
            for (int i = 0; i < numberOfPiles; i++) 
            {
                cboPile1.Items.Add($"Chồng {i+1}");
                cboPile2.Items.Add($"Chồng {i + 1}");
            }
            cboPile1.SelectedIndex = 0;
            cboPile2.SelectedIndex = 0;
            UpdateLabel();
        }
        private void handlePlayerMove(ComboBox cboPile, NumericUpDown numerPlayerMove, string playerName)
        {
            int pileIndex = cboPile.SelectedIndex;
            int playerMove = (int)numerPlayerMove.Value;

            if (playerMove > 0 && playerMove <= piles[pileIndex])
            {
                piles[pileIndex] -= playerMove;
                lstHistory.Items.Add($"{playerName} lấy {playerMove} que từ chồng {pileIndex + 1}");
                player1Turn = !player1Turn;
                UpdateLabel();
                checkGameOver(playerName, "D:\\chienThang.mp3");
                
            }
            else
            {
                if (piles[pileIndex] == 0)
                {
                    MessageBox.Show("Vui lòng chọn chồng hợp lệ.", "CẢNH BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số viên gạch hợp lệ.", "CẢNH BÁO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPlayer1Move_Click(object sender, EventArgs e)
        {
            if (player1Turn)
            {
                handlePlayerMove(cboPile1, numerPlayer1Move, "Người chơi 1");
                saveStateGame("Người chơi 1");

            }else
            {
                MessageBox.Show("Không phải lượt của bạn.", "THÔNG BÁO!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            numerPlayer1Move.Value = 1;
        }

        private void btnPlayer2Move_Click(object sender, EventArgs e)
        {
            if (!player1Turn)
            {
                handlePlayerMove(cboPile2, numerPlayer2Move, "Người chơi 2");
                saveStateGame("Người chơi 2");
            }
            else
            {
                MessageBox.Show("Không phải lượt của bạn.", "THÔNG BÁO!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            numerPlayer2Move.Value = 1;
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            if (player1Turn) {
                timer1.Stop();
            }
            else
            {
                timer2.Stop();
            }

            string gameRules = "Luật chơi: \n" +
                                "1.Người chơi bắt đầu chọn chồng gạch mà mình muốn lấy bằng cách chọn các tùy chọn có sẵn.\n" +
                                "2.Người chơi chọn số lượng viên gạch muốn lấy ứng với chồng đó (có thể chọn hết), có thể nhập từ bàn phím hoặc tăng giảm các tùy chọn.\n" +
                                "3.Khi chọn hoàn tất người chơi nhấn nút \"Lấy\" để thực hiện lượt đi của mình.\n" +
                                "4.Trò chơi kết thúc khi không còn viên gạch nào để lấy.\n" +
                                "5.Mỗi người chơi có 15 giây để suy nghĩ và thực hiện lượt đi.\n"+
                                "6.Người lấy gạch cuối cùng là người chiến thắng.\n\n\n" +
                                "Người phát triển: Nguyễn Hữu Nhân.\n" +
                                "MSSV: B2203517.\n" +
                                "Năm: 2024-2025";

            DialogResult result =  MessageBox.Show(gameRules, "Hướng dẫn sử dụng!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                if (player1Turn)
                {
                    timer1.Start();
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void UpdateLabel()
        {
            blinkTimer.Stop();
            isBlinking = false;
            blinkState = false;
            lblTimePlayer1.ForeColor = defaultColor;
            lblTimePlayer2.ForeColor = defaultColor;
            if (player1Turn)
            {
                seconds1 = 15;
                timer2.Stop();
                thinking2 = 0;
                lblTimePlayer1.ForeColor = defaultColor;
                lblTimePlayer1.Text = "00:15";
                timer1.Start();
                lblPlayer1.Text = "Đến lượt bạn";
                lblPlayer2.Text = "";
                lblTimePlayer2.Text = "";
            }
            else
            {
                seconds2 = 15;
                timer1.Stop();
                thinking1 = 0;
                lblTimePlayer2.ForeColor = defaultColor;
                lblTimePlayer2.Text = "00:15";
                timer2.Start();
                lblPlayer2.Text = "Đến lượt bạn";
                lblPlayer1.Text = "";
                lblTimePlayer1.Text = "";
            }
        }
        private void saveStateGame(string player)
        {
            string filePath = "state_game_two_player.txt";
            string pileData = string.Join(",", piles);
            string currentTime = DateTime.Now.ToString("dd:MM:yy  HH:mm:ss");
            string moveHistory = $"{currentTime} - {player}: {pileData}\n";
            System.IO.File.AppendAllText(filePath, moveHistory);
        }

        private void FormTwoPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            System.IO.File.Delete("state_game_two_player.txt");
            this.Hide();
            formStart.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            thinking1 = 0;
            timer2.Stop();
            thinking2 = 0 ;
            System.IO.File.Delete("state_game_two_player.txt");
            this.Hide();
            formStart.Show();
        }

        private void btnPlayer1Move_MouseEnter(object sender, EventArgs e)
        {
            btnPlayer1Move.BackColor = Color.LimeGreen;
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            if (!isBlinking)
            {
                blinkTimer.Stop(); //khong con trong che do chop
                return;
            }

            blinkState = !blinkState;
            if (player1Turn)
            {
                lblTimePlayer1.ForeColor = blinkState ? Color.Red : defaultColor;
            }
            else
            {
                lblTimePlayer2.ForeColor = blinkState ? Color.Red : defaultColor;
            }
           
        }

        private void FormTwoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnPlayer1Move_MouseLeave(object sender, EventArgs e)
        {
            btnPlayer1Move.BackColor= Color.LightGreen;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds2--;
            thinking2++;
            int minutes = seconds2 / 60;
            int secs = seconds2 % 60;
            lblTimePlayer2.Text = $"{minutes:D2}:{secs:D2}"; // Hiển thị MM:SS
            if(thinking2 >= maxThinking)
            {
                timer2.Stop();
                blinkTimer.Stop();
                thinking2 = 0 ;
                numerPlayer2Move.Value = 1;
                lblTimePlayer2.ForeColor = defaultColor;
                isBlinking = false;
                blinkState = false;
                MessageBox.Show("Người chơi 2 suy nghĩ quá lâu, bỏ lượt!!!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                player1Turn = !player1Turn;
                UpdateLabel();
            }else if((thinking2 >= maxThinking - 5) && (thinking2 < maxThinking) && !isBlinking)
            {
                //Nhanh if nay chi vo dung 1 lan duy nhat boi quan ly bang isBlinking de bat trang thai chop
                isBlinking = true;
                defaultColor = lblTimePlayer2.ForeColor;
                blinkTimer.Start();
            }
            
        }

        private void btnPlayer2Move_MouseEnter(object sender, EventArgs e)
        {
            btnPlayer2Move.BackColor = Color.LimeGreen;
        }
        private void btnPlayer2Move_MouseLeave(object sender, EventArgs e)
        {
            btnPlayer2Move.BackColor = Color.LightGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds1--;
            thinking1++;
            int minutes = seconds1 / 60;
            int secs = seconds1 % 60;
            lblTimePlayer1.Text = $"{minutes:D2}:{secs:D2}"; // Hiển thị MM:SS
            if (thinking1 >= maxThinking)
            {
                timer1.Stop();
                blinkTimer.Stop();
                thinking1 = 0;
                numerPlayer1Move.Value = 1;
                lblTimePlayer1.ForeColor = defaultColor;
                isBlinking = false;
                blinkState = false;
                MessageBox.Show("Người chơi 1 suy nghĩ quá lâu, bỏ lượt!!!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                player1Turn = !player1Turn;
                UpdateLabel();
            }
            else if ((thinking1 >= maxThinking - 5) && (thinking1 < maxThinking) && !isBlinking)
            {
                isBlinking = true;
                defaultColor = lblTimePlayer1.ForeColor;
                blinkTimer.Start();
            }
        }
    }
}
