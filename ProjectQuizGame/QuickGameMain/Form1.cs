using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuickGameMain
{
    public partial class Form1 : Form
    {
        private string correctAnswer;
        private Random random = new Random();
        private List<(string Question, string[] Answers, string CorrectAnswer)> questions;
        private int score = 0;
        private int questionCount = 0; // Biến để đếm số câu hỏi đã trả lời
        private const int totalQuestions = 10; // Tổng số câu hỏi
        private string playerName;
        private string questionsFile = "questions.txt";
        private const string scoresFile = "scores.txt"; // Đường dẫn của scores.txt
        private Server.ServerForm formServer; // Tham chiếu tới FormServer

        public Form1(string playerName, Server.ServerForm formServer)
        {
            InitializeComponent();
            this.playerName = playerName;
            lblPlayerName.Text = "Player: " + playerName;
            lblResult.Visible = false; // Ẩn lblResult khi bắt đầu
            LoadQuestions();
            LoadNextQuestion();
            this.formServer = formServer; // Lưu tham chiếu tới FormServer
        }

        private void LoadQuestions()
        {
            questions = new List<(string, string[], string)>();
            if (!File.Exists(questionsFile))
            {
                MessageBox.Show("Questions file not found.");
                return;
            }

            var lines = File.ReadAllLines(questionsFile);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 6)
                {
                    var question = parts[0];
                    var answers = parts.Skip(1).Take(4).ToArray();
                    var correctAnswer = parts[5];
                    questions.Add((question, answers, correctAnswer));
                }
            }
        }

        private void LoadNextQuestion()
        {
            if (questionCount >= totalQuestions || questions.Count == 0)
            {
                ShowCompletionMessage();
                return;
            }

            var questionIndex = random.Next(questions.Count);
            var question = questions[questionIndex];

            lblQuestion.Text = question.Question;
            rbtnAnswer1.Text = question.Answers[0];
            rbtnAnswer2.Text = question.Answers[1];
            rbtnAnswer3.Text = question.Answers[2];
            rbtnAnswer4.Text = question.Answers[3];
            correctAnswer = question.CorrectAnswer;
            ClearSelections();
        }

        private void ClearSelections()
        {
            rbtnAnswer1.Checked = false;
            rbtnAnswer2.Checked = false;
            rbtnAnswer3.Checked = false;
            rbtnAnswer4.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";
            if (rbtnAnswer1.Checked) selectedAnswer = rbtnAnswer1.Text;
            else if (rbtnAnswer2.Checked) selectedAnswer = rbtnAnswer2.Text;
            else if (rbtnAnswer3.Checked) selectedAnswer = rbtnAnswer3.Text;
            else if (rbtnAnswer4.Checked) selectedAnswer = rbtnAnswer4.Text;

            if (selectedAnswer == correctAnswer)
            {
                score++;
            }

            lblScore.Text = $"Scores: {score}"; // Cập nhật lblScore để hiển thị tổng số điểm

            questionCount++; // Tăng số câu hỏi đã trả lời
            LoadNextQuestion();
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Reset điểm và số câu hỏi đã trả lời
            score = 0;
            questionCount = 0;

            lblScore.Text = $"Scores: {score}";

            // Hiển thị lại các điều khiển và ẩn kết quả
            lblResult.Visible = false;
            lblQuestion.Visible = true;
            rbtnAnswer1.Visible = true;
            rbtnAnswer2.Visible = true;
            rbtnAnswer3.Visible = true;
            rbtnAnswer4.Visible = true;
            btnSubmit.Visible = true;
            btnPlayAgain.Visible = false; // Ẩn nút Play Again

            // Tải lại câu hỏi và bắt đầu trò chơi
            LoadQuestions();
            LoadNextQuestion();
        }


        private void ShowCompletionMessage()
        {
            lblResult.Text = $"Bạn đã hoàn thành! Điểm của bạn là: {score}";
            lblResult.Visible = true; // Hiển thị lblResult

            // Ẩn các điều khiển câu hỏi và nút Submit
            lblQuestion.Visible = false;
            rbtnAnswer1.Visible = false;
            rbtnAnswer2.Visible = false;
            rbtnAnswer3.Visible = false;
            rbtnAnswer4.Visible = false;
            btnSubmit.Visible = false;

            // Hiển thị nút Play Again
            btnPlayAgain.Visible = true;

            // Lưu điểm vào scores.txt
            using (var writer = new StreamWriter(scoresFile, true))
            {
                writer.WriteLine($"{playerName}|{score}");
            }

            // Gọi hàm LoadScores của FormServer để làm mới danh sách điểm
            formServer.LoadScores(); // Cập nhật danh sách điểm từ FormServer
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã để xử lý khi form được tải
        }
    }
}
