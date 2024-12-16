using System;
using System.Collections.Generic;
using System.Drawing; // Namespace liên quan đến giao diện
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Introduce : Form
    {
        private Timer slideTimer;
        private Timer autoSlideTimer;
        private int currentIndex = 0;
        private List<Panel> panels;
        private int slideSpeed = 14; // Tốc độ trượt
        private int panelWidth; // Độ rộng của Panel

        public Introduce()
        {
            InitializeComponent();

            panelWidth = this.Width; // Lấy độ rộng Form hiện tại

            panels = new List<Panel>
            {
                CreatePanel("Nguyễn Quốc Chí\nMSSV: 49.01.104.014\nNhiệm vụ:Xây dựng chương trình chính, phân quyền người dùng, chức năng đăng nhập, giao diện chính, đăng kí \nMức độ tham gia: 100%"),
                CreatePanel("Nguyễn Nhứt Lâm\nMSSV: 49.01.104.080\nNhiệm vụ:Thực hiện chức năng thêm ,cập nhật thông tin thuốc và nhân viên, làm báo cáo\nMức độ tham gia: 100%"),
                CreatePanel("Nguyễn Hữu Lập\nMSSV: 49.01.104.082\nNhiệm vụ: Giới thiệu thành viên và thực hiện chức năng nghiệp vụ chính, đăng nhập\nMức độ tham gia: 100%"),
                CreatePanel("Nguyễn Đặng Đại Nam\nMSSV: 49.01.104.094\nNhiệm vụ:Đọc dữ liệu từ database, quản lý nhân viên, cài đặt qua app.config, báo cáo về doanh thu \nMức độ tham gia: 100%")
            };

            foreach (var panel in panels)
            {
                // Đặt panel ngoài màn hình
                panel.Location = new System.Drawing.Point(this.Width, 0);
                this.Controls.Add(panel);
            }

            // Đặt panel đầu tiên vào màn hình
            panels[0].Location = new System.Drawing.Point(0, 0);

            slideTimer = new Timer { Interval = 3 };
            slideTimer.Tick += SlideTimer_Tick;

            autoSlideTimer = new Timer { Interval = 2000 };
            autoSlideTimer.Tick += AutoSlideTimer_Tick;
            autoSlideTimer.Start();

            this.Resize += Introduce_Resize; // Gắn sự kiện Resize
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            var currentPanel = panels[currentIndex];
            var nextIndex = (currentIndex + 1) % panels.Count;
            var nextPanel = panels[nextIndex];

            // Di chuyển các panel
            currentPanel.Left -= slideSpeed;
            nextPanel.Left -= slideSpeed;

            // Nếu panel hiện tại đã ra khỏi màn hình hoàn toàn
            if (currentPanel.Right <= 0)
            {
                // Đặt lại vị trí của panel hiện tại ngoài màn hình
                currentPanel.Location = new System.Drawing.Point(this.Width, 0);
                slideTimer.Stop();
                currentIndex = nextIndex; // Chuyển sang panel tiếp theo
            }
        }

        private void AutoSlideTimer_Tick(object sender, EventArgs e)
        {
            slideTimer.Start(); // Bắt đầu trượt
        }

        private Panel CreatePanel(string content)
        {
            Panel panel = new Panel
            {
                Size = new Size(this.Width, this.Height), // Panel có kích thước bằng form
                BackColor = Color.White
            };

            // Tạo PictureBox căn giữa
            PictureBox pictureBox = new PictureBox
            {
                Image = Properties.Resources.pharmacist1,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(this.Width / 2, this.Height / 3),
                Location = new System.Drawing.Point((this.Width - this.Width / 2) / 2, 96) // Y cố định 96
            };

            // Tạo Label hiển thị nội dung
            Label label = new Label
            {
                Text = content,
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                TextAlign = ContentAlignment.TopCenter,
                Size = new Size(this.Width, this.Height - pictureBox.Bottom - 20),
                Location = new System.Drawing.Point(0, pictureBox.Bottom + 20) // Dưới hình
            };

            // Thêm các control vào panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            return panel;
        }

        private void Introduce_Load(object sender, EventArgs e)
        {
            autoSlideTimer.Start();
        }

        private void Introduce_Resize(object sender, EventArgs e)
        {
            foreach (var panel in panels)
            {
                // Cập nhật kích thước panel
                panel.Size = new Size(this.Width, this.Height);

                foreach (Control control in panel.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        // Cập nhật kích thước và vị trí hình ảnh
                        pictureBox.Size = new Size(this.Width / 2, this.Height / 3);
                        pictureBox.Location = new System.Drawing.Point((this.Width - pictureBox.Width) / 2, 96);
                    }
                    else if (control is Label label)
                    {
                        // Cập nhật kích thước và vị trí nội dung
                        label.Size = new Size(this.Width, this.Height - 96 - (this.Height / 3) - 20);
                        label.Location = new System.Drawing.Point(0, 96 + (this.Height / 3) + 20);
                    }
                }
            }
        }
    }
}
