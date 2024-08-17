using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        private const string scoresFile = "scores.txt";

        public ServerForm()
        {
            InitializeComponent();
            LoadScores(); // Gọi LoadScores khi khởi tạo
        }

        public void LoadScores()
        {
            if (!File.Exists(scoresFile))
            {
                MessageBox.Show("Scores file not found.");
                return;
            }

            var lines = File.ReadAllLines(scoresFile);
            var scores = lines.Select(line =>
            {
                var parts = line.Split('|');
                return $"{parts[0]}: {parts[1]} điểm";
            }).ToArray();

            lstScores.Items.Clear();
            lstScores.Items.AddRange(scores);
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã để xử lý khi form được tải nếu cần
            LoadScores(); // Đảm bảo gọi LoadScores khi form được tải
        }

        private void lstScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm mã để xử lý khi danh sách điểm được thay đổi nếu cần
        }
    }
}
