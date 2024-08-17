using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Sever
{
    class Question
    {
        public string Content { get; set; } // Nội dung câu hỏi
        public string Answer1 { get; set; } // Đáp án 1
        public string Answer2 { get; set; } // Đáp án 2
        public string CorrectAnswer { get; set; } // Đáp án đúng
    }

    class QuestionLoader
    {
        public static List<Question> LoadQuestions(string filename)
        {
            var questions = new List<Question>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length - 3; i += 4) // Dừng 3 vị trí trước khi kết thúc
            {
                questions.Add(new Question
                {
                    Content = lines[i],
                    Answer1 = lines[i + 1],
                    Answer2 = lines[i + 2],
                    CorrectAnswer = lines[i + 3]
                });
            }
            return questions;
        }
    }

    class QuizServer
    {
        public static List<Question> questions;

        public static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);

            try
            {
                // Nhận tên người đăng ký từ client
                string username = reader.ReadLine();

                // Chọn 10 câu hỏi ngẫu nhiên
                List<Question> randomQuestions = questions.OrderBy(x => Guid.NewGuid()).Take(10).ToList();

                // Gửi câu hỏi và đáp án cho client
                foreach (Question question in randomQuestions)
                {
                    writer.WriteLine(question.Content);
                    writer.WriteLine(question.Answer1);
                    writer.WriteLine(question.Answer2);
                    writer.Flush();
                }

                // Nhận câu trả lời từ client và tính điểm
                int correctAnswers = 0;
                for (int i = 0; i < 10; i++)
                {
                    string clientAnswer = reader.ReadLine();
                    if (clientAnswer == randomQuestions[i].CorrectAnswer)
                    {
                        correctAnswers++;
                    }
                }

                // Lưu kết quả vào file ketqua.txt
                SaveResult(username, correctAnswers);

                // Gửi kết quả cho client
                writer.WriteLine(correctAnswers + "/10");
                writer.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                stream.Close();
                client.Close();
            }
        }

        // Lưu kết quả vào file
        static void SaveResult(string username, int correctAnswers)
        {
            using (StreamWriter sw = File.AppendText("ketqua.txt"))
            {
                sw.WriteLine(username + "," + correctAnswers + "/10");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuizServer.questions = QuestionLoader.LoadQuestions("cauhoi.txt");

            // Tạo socket server và lắng nghe kết nối từ client
            TcpListener server = new TcpListener(IPAddress.Any, 12345);
            server.Start();
            Console.WriteLine("Server is listening...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client connected: " + client.Client.RemoteEndPoint);

                // Tạo luồng mới để xử lý yêu cầu từ client
                new Thread(() => QuizServer.HandleClient(client)).Start();
            }
        }
    }
}
