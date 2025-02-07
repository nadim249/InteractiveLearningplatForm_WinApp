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
    public partial class AssignmentResult : Form
    {

        private string userName;
        private int userId;

        public AssignmentResult(string userName, int userId)
        {
            InitializeComponent();
            this.userName = userName;
            this.userId = userId;
        }

        private void AssignmentResult_Load(object sender, EventArgs e)
        {
            LoadSubmission(userId);
        }

        private void LoadSubmission(int userId)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    asub.SubmissionID, 
                    asub.AssignmentID, 
                    asub.StudentID, 
                    asub.SubmissionDate, 
                    asub.FilePath, 
                    asub.Marks, 
                    asub.Feedback
                FROM AssignmentSubmissions asub
                JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
                JOIN Courses c ON a.CourseID = c.CourseID
                WHERE asub.StudentID = @UserID OR c.InstructorID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
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

        private void coubuy_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName,userId);
            courseBuy.Show();
            this.Hide();
        }

        private void mycou_btn_Click(object sender, EventArgs e)
        {
            MyCouse myCouse = new MyCouse(userName,userId);
            myCouse.Show(); 
            this.Hide();

        }

        private void assign_btn_Click(object sender, EventArgs e)
        {
            SAssUpl sAssUplo = new SAssUpl(userName, userId);
            sAssUplo.Show();
            this.Hide();
        }

        private void dgvAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvAssignments.Rows[e.RowIndex];
                if (selectedRow.Cells.Count >= 2)
                {
                    label1.Text = "Your Marks : "+ selectedRow.Cells["Marks"].Value.ToString();
                    label3.Text = "Feedback : " + selectedRow.Cells["Feedback"].Value.ToString();



                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void annouc_btn_Click(object sender, EventArgs e)
        {
            AnnoucmentStudent annoucmentStudent = new AnnoucmentStudent(userName, userId);
            annoucmentStudent.Show();
            this.Hide();
        }

        private void AssignmentResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
