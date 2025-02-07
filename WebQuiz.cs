using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace InterractiveLearningPlatform
{
    public partial class WebQuiz : Form
    {
        private string userName;
        private int userID;
        private int quizID ;
        private int timeLeft = 10; 

        public WebQuiz(string name,int id)
        {
            InitializeComponent();
            userName = name;
            userID = id;
            quizID = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();

            WebDevCoureVideo webCourseVideo = new WebDevCoureVideo(userName, userID);
            webCourseVideo.Show();
            this.Hide();

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            int score = 0;
            quizTimer.Stop();

           
            if (corect1.Checked) score+=5;
            if (correct2.Checked) score+=5;
            if (correct3.Checked) score+=5;
            if (correct4.Checked) score+=5;

            label3.Text = "Your Score is: " + score;
       
             if (!HasStudentAlreadyAttemptedQuiz())
             {
                 SubmitResult(score);
             }
             else
             {
                 MessageBox.Show("You have already attempted this quiz. Your score will not be updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

        }
        private bool HasStudentAlreadyAttemptedQuiz()
        {
           

          

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM QuizResults WHERE QuizID = @QuizID AND StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                      
                        cmd.Parameters.AddWithValue("@QuizID", quizID);
                        cmd.Parameters.AddWithValue("@StudentID", userID);

       
                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; 
                }
            }
        }

        private void SubmitResult(int score)
        {
           


            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO QuizResults (QuizID, StudentID, Score) VALUES (@QuizID, @StudentID, @Score)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@QuizID", quizID);
                        cmd.Parameters.AddWithValue("@StudentID", userID);
                        cmd.Parameters.AddWithValue("@Score", score);

                    
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Quiz result submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit quiz result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WebQuiz_Load(object sender, EventArgs e)
        {
            // Start the timer
            quizTimer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timer_label.Text = "Time Left: "+timeLeft + " seconds";
            }
            else
            {
                quizTimer.Stop();
                MessageBox.Show("Time is up! Quiz will be submitted automatically.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                submit_btn.PerformClick();
            }

        }
    }
}
