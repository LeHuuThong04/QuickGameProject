using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private int currentQuestionIndex = 0;
        private List<Question> questions = new List<Question>();
        private System.Windows.Forms.Timer timer;
        private int timeLeft = 10; // Thời gian cho mỗi câu hỏi

        public Form1()
        {
            InitializeComponent();
            InitializeGameComponents();
        }

        private void InitializeGameComponents()
        {
            // Gán sự kiện click cho các nút
            button1.Click += ConnectToServer;
            button2.Click += SubmitAnswer;

            // Khởi tạo timer
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;

            // Ẩn các thành phần giao diện ban đầu
            label1.Visible = false;
            label2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            // Gán sự kiện CheckedChanged cho radio buttons
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void ConnectToServer(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("192.168.1.8", 12345);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                ReceiveQuestions();
                DisplayQuestion();

                // Hiển thị các thành phần giao diện sau khi kết nối
                ToggleGameControls(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến server: " + ex.Message);
            }
        }

        private void ReceiveQuestions()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    string content = reader.ReadLine();
                    string answer1 = reader.ReadLine();
                    string answer2 = reader.ReadLine();
                    questions.Add(new Question { Content = content, Answer1 = answer1, Answer2 = answer2 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhận câu hỏi từ server: " + ex.Message);
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                label1.Text = questions[currentQuestionIndex].Content;
                radioButton1.Text = questions[currentQuestionIndex].Answer1;
                radioButton2.Text = questions[currentQuestionIndex].Answer2;

                ResetTimer();

                // Bỏ chọn tất cả radio buttons
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                EndGame();
            }
        }

        private void SubmitAnswer(object sender, EventArgs e)
        {
            timer.Stop();

            string selectedAnswer = radioButton1.Checked ? radioButton1.Text :
                                    radioButton2.Checked ? radioButton2.Text :
                                    "";

            writer.WriteLine(selectedAnswer);
            writer.Flush();

            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void EndGame()
        {
            timer.Stop();
            try
            {
                string result = reader.ReadLine();
                MessageBox.Show("Kết quả: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhận kết quả từ server: " + ex.Message);
            }
            finally
            {
                stream.Close();
                client.Close();
                ResetGame();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            label2.Text = timeLeft.ToString();

            if (timeLeft == 0)
            {
                writer.WriteLine(""); // Gửi câu trả lời trống khi hết giờ
                writer.Flush();

                currentQuestionIndex++;
                DisplayQuestion();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                if (radioButton == radioButton1)
                {
                    radioButton2.Checked = false;
                }
                else if (radioButton == radioButton2)
                {
                    radioButton1.Checked = false;
                }
            }
        }

        private void ResetTimer()
        {
            timeLeft = 10;
            label2.Text = timeLeft.ToString();
            timer.Start();
        }

        private void ToggleGameControls(bool isVisible)
        {
            button1.Visible = !isVisible;
            label1.Visible = isVisible;
            label2.Visible = isVisible;
            radioButton1.Visible = isVisible;
            radioButton2.Visible = isVisible;
        }

        private void ResetGame()
        {
            currentQuestionIndex = 0;
            questions.Clear();
            ToggleGameControls(false);
        }

        class Question
        {
            public string Content { get; set; }
            public string Answer1 { get; set; }
            public string Answer2 { get; set; }
        }
    }
}
