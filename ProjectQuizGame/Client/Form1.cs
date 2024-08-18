using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;
        int currentQuestionIndex = 0;
        List<Question> questions = new List<Question>();
        System.Windows.Forms.Timer timer;
        int timeLeft = 10; // Thời gian cho mỗi câu hỏi

        public Form1()
        {
            InitializeComponent();
            button1.Click += ConnectToServer; // Gán sự kiện click cho nút "Chơi"
            button2.Click += SubmitAnswer; // Gán sự kiện click cho nút "Xác nhận"

            timer = new System.Windows.Forms.Timer(); // Khởi tạo timer
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void ConnectToServer(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("192.168.1.8", 12345); ; // Kết nối đến server
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);


                // Nhận câu hỏi và bắt đầu trò chơi
                ReceiveQuestions();
                button1.Visible = false; // Ẩn nút "Chơi" sau khi kết nối

                /* Khởi tạo và bắt đầu timer
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 giây
                timer.Tick += Timer_Tick;
                timer.Start();*/
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
                DisplayQuestion();
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
                timeLeft = 10;
                label2.Text = timeLeft.ToString();

                timer.Start(); // Bắt đầu lại timer cho câu hỏi mới
            }
            else
            {
                EndGame();
            }
        }

        private void SubmitAnswer(object sender, EventArgs e)
        {
            timer.Stop(); // Dừng timer khi nhấn nút "Xác nhận"

            string selectedAnswer = "";
            if (radioButton1.Checked)
                selectedAnswer = radioButton1.Text;
            else if (radioButton2.Checked)
                selectedAnswer = radioButton2.Text;

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
                button1.Visible = true; // Hiển thị lại nút "Chơi"
                currentQuestionIndex = 0;
                questions.Clear();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            label2.Text = timeLeft.ToString();

            if (timeLeft == 0)
            {
                // Hết giờ, tự động gửi câu trả lời trống
                writer.WriteLine("");
                writer.Flush();

                currentQuestionIndex++;
                DisplayQuestion();
            }
        }

    }

    class Question
    {
        public string Content { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
    }
}