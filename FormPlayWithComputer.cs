using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace NimProject
{
    public partial class FormPlayWithComputer : Form
    {
        private int[] piles;
        private Random random = new Random();
        private int indexLevel, helpCount, seconds;
        private string playTime;
        private WindowsMediaPlayer player;
        FormStart formStart = new FormStart();
        public FormPlayWithComputer()
        {
            InitializeComponent();
            InitializeGame();
            player = new WindowsMediaPlayer();
        }
        public void playSound(string path)
        {
            try
            {
                if(System.IO.File.Exists(path))
                {
                    if(player == null)
                    {
                        player = new WindowsMediaPlayer();
                    }
                    player.URL = path;
                    player.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát âm thanh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void stopSound()
        {
            if(player != null)
            {
                player.controls.stop();
            }
        }
        public FormPlayWithComputer(int level)
        {
            indexLevel = level;
            InitializeComponent();
            InitializeGame();
            player = new WindowsMediaPlayer();
        }
        private void UpdateUI()
        {
            pnlPilesContainerKho.Controls.Clear();
            pnlPilesContainerDe.Controls.Clear();
            pnlPilesContainerTB.Controls.Clear();
            for(int i=0; i < piles.Length; i++)
            {
                // Tạo FlowLayoutPanel cho mỗi chồng
                FlowLayoutPanel pilePanel = new FlowLayoutPanel();
                pilePanel.FlowDirection = FlowDirection.TopDown;
                pilePanel.AutoSize = true;
                pilePanel.Width = 140;
                pilePanel.Height = 330;
                pilePanel.BorderStyle = BorderStyle.FixedSingle;
                pilePanel.BackColor = Color.LightBlue;
                pilePanel.Name = $"pile{i + 1}";
                // Thêm các nút cho mỗi chồng
                for(int j = 0; j < piles[i]; j++)
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
                // Thêm tiêu đề
                Label labelPile = new Label();
                labelPile.Text = $"          Chồng {i + 1}";
                labelPile.AutoSize = true;
                labelPile.Font = new Font("Arial", 10, FontStyle.Bold);
                // Tạo một Panel chứa Label và FlowLayoutPanel
                Panel containerPanel = new Panel();
                containerPanel.AutoSize = true;
                containerPanel.Controls.Add(labelPile);
                containerPanel.Controls.Add(pilePanel);
                pilePanel.Top = labelPile.Bottom + 5;//định dạng cho pilePanel nằm dưới cách labelPile 5px tính từ vị trí dưới cùng
                //Thêm containerPanel vào pnlPilesContainer
                if (indexLevel == 0)
                {
                    pnlPilesContainerKho.Hide();
                    pnlPilesContainerTB.Hide();
                    pnlPilesContainerDe.Controls.Add(containerPanel);
                }
                else if (indexLevel == 1)
                {
                    pnlPilesContainerKho.Hide();
                    pnlPilesContainerDe.Hide();
                    pnlPilesContainerTB.Controls.Add(containerPanel);
                }
                else
                {
                    pnlPilesContainerDe.Hide();
                    pnlPilesContainerTB.Hide();
                    pnlPilesContainerKho.Controls.Add(containerPanel);
                }
                
            }
        }
        private async void btnPlayerMove_Click_1(object sender, EventArgs e)
        {
            btnPlayerMove.Enabled = false;
            int pileIndex = cboPile.SelectedIndex;
            int playerMove = (int)numerPlayerMove.Value;
            if (playerMove > 0 && playerMove <= piles[pileIndex])
            {
                piles[pileIndex] -= playerMove;
                lstHistory.Items.Add($"Người chơi lấy {playerMove} viên từ chồng {pileIndex + 1}");
                saveStateGame("Người chơi");
                lblLuotChoi.Hide();
                if (isGameOver())
                {
                    btnPlayerMove.Enabled = true;
                    lblLuotChoi.Show();
                    checkGameOver("Bạn", "C:\\Users\\PC\\OneDrive\\Desktop\\Ct239_NLCS\\NimUpdate\\chienThang.mp3");
                    return;
                }
                else
                {
                    checkGameOver("Bạn", "C:\\Users\\PC\\OneDrive\\Desktop\\Ct239_NLCS\\NimUpdate\\chienThang.mp3");
                }
                numerPlayerMove.Value = 1;
                await Task.Delay(1000);
                computerMove();
                lblLuotChoi.Show();

            }
            else
            {
                if (piles[pileIndex] == 0)
                {
                    MessageBox.Show("Vui lòng chọn chồng hợp lệ.", "CẢNH BÁO!!!", MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số viên gạch hợp lệ.","CẢNH BÁO!!!", MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);
                }
            }
            btnPlayerMove.Enabled = true;
        }
        private bool isGameOver()
        {
            foreach (int pile in piles)
            {
                if(pile > 0)
                {
                    return false;
                }
               
            }
            return true;
        }
        private void computerMove()
        {
            if (isGameOver()) return;
            int nimSum = 0;
            foreach (int pile in piles) 
            { 
                nimSum ^= pile;//tinh nim sum bang toan tu XOR
            }
            int pileIndex = -1, move = 0;
            if (nimSum == 0) { //bat loi, khong co chien luoc chon ngau nhien dai mot chong 
                for(int i = 0; i< piles.Length; i++)
                {
                    if (piles[i] > 0)
                    {
                        pileIndex = i;
                        move = 1;
                        break;
                    }
                }
            }else// chon nuoc di toi uu
            {
                for(int i = 0;i< piles.Length;i++)
                {
                    int target = piles[i] ^ nimSum;
                    if(target < piles[i])
                    {
                        pileIndex = i;
                        move = piles[i] - target;
                        break;
                    }

                }
            }
            piles[pileIndex] -= move;
            lstHistory.Items.Add($"Máy tính lấy {move} viên từ chồng {pileIndex+1}");
            saveStateGame("Computer");
            checkGameOver("Máy Tính", "C:\\Users\\PC\\OneDrive\\Desktop\\Ct239_NLCS\\NimUpdate\\thatBai.mp3");
        }
        private void suggestMove()
        {
            int nimSum = 0;
            foreach (int pile in piles)
            {
                nimSum ^= pile;
            }
            if(nimSum == 0) 
            {
                    MessageBox.Show("Không có nước đi tối ưu. Bạn có thể chọn một chồng bất kỳ để lấy 1 viên.", "Gợi ý nước đi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }else { 
                for (int i = 0; i < piles.Length; i++) 
                { 
                    int target = piles[i] ^ nimSum;
                    if(target < piles[i])
                    {
                        int optimalMove = piles[i] - target;
                        MessageBox.Show($"Gợi ý: Bạn nên lấy {optimalMove} viên từ chồng {i + 1}.", "Gợi ý nước đi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }


        private  void checkGameOver(string lastPlayer, string path)
        {
            if (isGameOver())
            {
                playSound(path);
                timer.Stop();
                UpdateUI();
                DialogResult result = MessageBox.Show($"{lastPlayer} thắng cuộc trong thời gian {playTime} \nBạn có muốn chơi tiếp không",
                    "CHIẾN THẮNG!!!",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                if (result == DialogResult.OK) {
                    stopSound();
                    btnReset_Click(this, EventArgs.Empty);
                }else 
                {
                    stopSound();
                    System.IO.File.Delete("state_game.txt");
                    this.Close();
                    formStart.Show();
                }
                
            }
            else
            {
                UpdateUI();
            }
        }
        private void InitializeGame()
        {
            seconds = 0;
            lblTime.Text = "00:00";
            timer.Stop();
            timer.Start();
            int minPiles;
            int maxPiles;
            helpCount = 0;
            if (indexLevel == 0) {
                minPiles = 2;
                maxPiles = 3;
            } else if (indexLevel == 1)
            {
                minPiles = 3;
                maxPiles = 4;
            }else
            {
                minPiles = 5;
                maxPiles = 6;
            }
            int numberOfPiles = random.Next(minPiles, maxPiles);
            piles = new int[numberOfPiles];
            for(int i=0; i<numberOfPiles; i++)
            {
                piles[i] = random.Next(1,10);
            }
            saveStateGame("Khởi tạo");
            UpdateUI();
            lstHistory.Items.Clear();
            cboPile.Items.Clear();
            for (int i = 0; i < piles.Length; i++)
            {
                cboPile.Items.Add($"Chồng {i + 1}");
            }
            cboPile.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeGame();
            
        }
        private void saveStateGame (string namePlayer)
        {
            string filePath = "state_game.txt";
            string pileData = string.Join(",", piles);
            string currentTime = DateTime.Now.ToString("dd:MM:yy  HH:mm:ss");
            string moveHistory = $"{currentTime} - {namePlayer}: {pileData}\n";
            System.IO.File.AppendAllText(filePath, moveHistory);
        }
        private void FormPlayWithComputer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.IO.File.Delete("state_game.txt");
            this.Hide();
            formStart.Show();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            timer.Stop();
            string gameRules = "Luật chơi: \n" +
                                "1.Người chơi bắt đầu chọn chồng gạch mà mình muốn lấy bằng cách chọn các tùy chọn có sẵn.\n" +
                                "2.Người chơi chọn số lượng viên gạch muốn lấy ứng với chồng đó (có thể chọn hết), có thể nhập từ bàn phím hoặc tăng giảm các tùy chọn.\n" +
                                "3.Khi chọn hoàn tất người chơi nhấn nút \"Lấy\" để thực hiện lượt đi của mình.\n" +
                                "4.Trò chơi kết thúc khi không còn viên gạch nào để lấy.\n" +
                                "5.Người lấy gạch cuối cùng là người chiến thắng.\n\n\n" +
                                "Người phát triển: Nguyễn Hữu Nhân.\n" +
                                "MSSV: B2203517.\n" +
                                "Năm: 2024-2025";

            DialogResult result = MessageBox.Show(gameRules, "Hướng dẫn sử dụng!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { 
                timer.Start();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("state_game.txt");
            this.Hide();
            formStart.Show();
        }

        private void btnPlayerMove_MouseEnter(object sender, EventArgs e)
        {
            btnPlayerMove.BackColor = Color.LimeGreen;
        }

        private void btnPlayerMove_MouseLeave(object sender, EventArgs e)
        {
            btnPlayerMove.BackColor = Color.LightGreen;
        }
        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.LimeGreen;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor= Color.LightGreen;
        }

        private void FormPlayWithComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            int minutes = seconds / 60;
            int secs = seconds % 60;

            lblTime.Text = $"{minutes:D2}:{secs:D2}"; //hien thi mm:ss: D2 dinh dang them so 0 vao ben trai neu co 1 chu so
            playTime = $"{minutes} phút {secs} giây" ;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if(helpCount < 2)
            {
                suggestMove();
                helpCount++;
            }else
            {
                MessageBox.Show("Bạn đã sử dụng hết 2 lần gợi ý!!!", "Gợi ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
