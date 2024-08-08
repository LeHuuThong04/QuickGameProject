using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuickGame
{
    public partial class Form1 : Form
    {
        private string correctAnswer;
        private Random random = new Random();
        private List<int> answeredQuestions = new List<int>();
        private List<(string Question, string[] Answers, string CorrectAnswer)> questions;
        private int level = 1;
        private int totalQuestionsPerLevel = 5; // Số câu hỏi mỗi cấp độ

        public Form1()
        {
            InitializeComponent();
            LoadQuestionsFromFile("D:\\Laptrinhmang\\ProjectQuickGame\\QuickGame\\QuickGame\\questions.txt");
            UpdateLevelLabel();
            LoadNextQuestion();
        }

        private void LoadQuestionsFromFile(string filePath)
        {
            questions = new List<(string, string[], string)>();
            var lines = File.ReadAllLines(filePath);

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
            if (answeredQuestions.Count >= totalQuestionsPerLevel)
            {
                ShowLevelCompletion();
                return;
            }

            int questionIndex;
            do
            {
                questionIndex = random.Next(questions.Count);
            } while (answeredQuestions.Contains(questionIndex));

            answeredQuestions.Add(questionIndex);
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
            resume.Visible = false;
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
                lblResult.Text = "Đúng!";
                lblCorrectAnswer.Text = "";
                resume.Visible = true;
                LoadNextQuestion();
            }
            else
            {
                lblResult.Text = "Sai!";
                lblCorrectAnswer.Text = "Đáp án đúng là: " + correctAnswer;
            }
            
        }

        private void ShowLevelCompletion()
        {
            messages.Text = "Hoàn thành cấp độ " + level + "!";
            lblCorrectAnswer.Text = "";
            lblResult.Text = "";

            // Ẩn các thành phần không cần thiết
            lblQuestion.Visible = false;
            rbtnAnswer1.Visible = false;
            rbtnAnswer2.Visible = false;
            rbtnAnswer3.Visible = false;
            rbtnAnswer4.Visible = false;
            btnSubmit.Visible = false;

            // Hiển thị nút Next Level
            btnNextLevel.Visible = true;
            messages.Visible = true;
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            level++;
            answeredQuestions.Clear();

            // Reset giao diện
            lblQuestion.Visible = true;
            rbtnAnswer1.Visible = true;
            rbtnAnswer2.Visible = true;
            rbtnAnswer3.Visible = true;
            rbtnAnswer4.Visible = true;
            btnSubmit.Visible = true;

            lblResult.Text = "";
            lblCorrectAnswer.Text = "";

            LoadNextQuestion();
            btnNextLevel.Visible = false;
            messages.Visible = false;
            resume.Visible = false;
            UpdateLevelLabel();
        }

        private void UpdateLevelLabel()
        {
            lblLevel.Text = "Level: " + level;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterControl(lblQuestion);
            CenterControl(rbtnAnswer1);
            CenterControl(rbtnAnswer2);
            CenterControl(rbtnAnswer3);
            CenterControl(rbtnAnswer4);
            CenterControl(btnSubmit);
            CenterControl(lblLevel);
            CenterControl(lblResult);
            CenterControl(lblCorrectAnswer);
            resume.Visible = false;
            btnNextLevel.Visible = false; // Hide the button initially
            messages.Visible=false;
        }

        private void CenterControl(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }
    }
}
