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
    public partial class InstructorStudInfo : Form
    {
        private string insName;
        private int insId;
        public InstructorStudInfo(string insName, int insId)
        {
            InitializeComponent();
            this.insName = insName;
            this.insId = insId;
        }

        private void ins_home_btn_Click(object sender, EventArgs e)
        {
            InstructorStudDet instructorStudDet = new InstructorStudDet(insName,insId);
            instructorStudDet.Show();
            this.Hide();
        }

        private void stu_pro_btn_Click(object sender, EventArgs e)
        {
            InstructorStudInfo instructorStudInfo = new InstructorStudInfo(insName,insId);
            instructorStudInfo.Show();
            this.Hide();

        }

        private void ins_stu_perf_btn_Click(object sender, EventArgs e)
        {
            InstructorStudPerf instructorStudPerf = new InstructorStudPerf(insName,insId);
            instructorStudPerf.Show();
            this.Hide();
        }

        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName,insId);
            instructorDashboard.Show();
            this.Hide();
        }

        private void InstructorStudInfo_Load(object sender, EventArgs e)
        {
            LoadStudent(insId);
        }

        private void LoadStudent(int insId)
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
                    u.Mobile,
                    u.Email,
                    c.CourseName
                FROM Users u
                JOIN Enrollments e ON u.UserID = e.UserID
                JOIN Courses c ON e.CourseID = c.CourseID
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

        private void ins_del_btn_Click(object sender, EventArgs e)
        {

            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAssignments.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dgvAssignments.Rows[selectedRowIndex].Cells[0].Value);

                try
                {
                    using (SqlConnection connection = DbConnection.GetConnection())
                    {
                        connection.Open();

                        
                        string getEnrollmentQuery = "SELECT EnrollmentID FROM Enrollments WHERE UserID = @UserID AND CourseID IN (SELECT CourseID FROM Courses WHERE InstructorID = @InstructorID)";

                        using (SqlCommand getCmd = new SqlCommand(getEnrollmentQuery, connection))
                        {
                            getCmd.Parameters.AddWithValue("@UserID", userId);
                            getCmd.Parameters.AddWithValue("@InstructorID", insId); 

                            var result = getCmd.ExecuteScalar();
                            if (result != null)
                            {
                                int enrollmentId = Convert.ToInt32(result);

                           
                                string deleteQuery = "DELETE FROM Enrollments WHERE EnrollmentID = @EnrollmentID";
                                using (SqlCommand delCmd = new SqlCommand(deleteQuery, connection))
                                {
                                    delCmd.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                                    delCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Student removed from course successfully.");
                                LoadStudent(insId); 
                            }
                            else
                            {
                                MessageBox.Show("The selected student is not enrolled in your course.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Cannot remove this student because there are associated records in other tables.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting the student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No student selected for deletion.");
            }
        }
    }
}
