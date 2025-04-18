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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
            richTextBox.Text = "CÁCH CHƠI: \n" +
                                "1.Người chơi bắt đầu chọn chồng gạch mà mình muốn lấy bằng cách chọn các tùy chọn có sẵn.\n" +
                                "2.Người chơi chọn số lượng viên gạch muốn lấy ứng với chồng đó (có thể chọn hết), có thể nhập từ bàn phím hoặc tăng giảm các tùy chọn.\n" +
                                "3.Khi chọn hoàn tất người chơi nhấn nút \"Lấy\" để thực hiện lượt đi của mình.\n"+
                                "4.Trò chơi kết thúc khi không còn viên gạch nào để lấy.\n" +
                                "5.Người lấy gạch cuối cùng là người chiến thắng.\n" + 
                                "6. Đối với trường hợp hai người chơi nếu hết thời gian qui định mà người" +
                                "chơi không thực hiện nước đi của mình chương trình sẽ tự lấy 1 viên gạch bất kỳ ở chồng bất kỳ nào đó.";
            richTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LimeGreen;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightGreen;
        }
    }
}
