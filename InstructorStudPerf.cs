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

namespace InterractiveLearningPlatform
{
    public partial class InstructorStudPerf : Form
    {
        private string insName;
        private int insId;
        public InstructorStudPerf(string insName, int insId)
        {
            InitializeComponent();
            this.insName = insName;
            this.insId = insId;
        }

        private void ins_home_btn_Click(object sender, EventArgs e)
        {
            InstructorStudDet instructorStudDet = new InstructorStudDet(insName, insId);
            instructorStudDet.Show();
            this.Hide();
        }

        private void stu_pro_btn_Click(object sender, EventArgs e)
        {
            InstructorStudInfo instructorStudInfo = new InstructorStudInfo(insName, insId);
            instructorStudInfo.Show();
            this.Hide();
        }

        private void ins_stu_perf_btn_Click(object sender, EventArgs e)
        {
            InstructorStudPerf instructorStudPerf = new InstructorStudPerf(insName, insId);
            instructorStudPerf.Show();
            this.Hide();
        }

        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName,insId);
            instructorDashboard.Show();
            this.Hide();
        }

        private void InstructorStudPerf_Load(object sender, EventArgs e)
        {
            LoadPErformance(insId);
        }
        private void LoadPErformance(int insId)
        {

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection()) 
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    u.UserID AS StudentID,
                    u.Name AS StudentName,
                    c.CourseName,
                    ISNULL(qr.Score, 0) AS QuizMark,
                    ISNULL(asub.Marks, 0) AS AssignmentMark
                FROM Users u
                JOIN Enrollments e ON u.UserID = e.UserID
                JOIN Courses c ON e.CourseID = c.CourseID
                LEFT JOIN Assignments a ON c.CourseID = a.CourseID
                LEFT JOIN AssignmentSubmissions asub ON a.AssignmentID = asub.AssignmentID AND u.UserID = asub.StudentID
                LEFT JOIN Quizzes q ON c.CourseID = q.CourseID
                LEFT JOIN QuizResults qr ON q.QuizID = qr.QuizID AND u.UserID = qr.StudentID
                WHERE c.InstructorID = @InstructorID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InstructorID", insId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvAssignments.DataSource = dt; 
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
}
