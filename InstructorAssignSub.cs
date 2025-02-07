using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterractiveLearningPlatform
{
    public partial class InstructorAssignSub : Form
    {
        private string insName;
        private int insId;
        public InstructorAssignSub(string insName, int insId)
        {
            InitializeComponent();
            this.insName = insName;
            this.insId = insId;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName, insId);
            instructorDashboard.Show();
            this.Hide();
        }

        private void assg_crt_btn_Click(object sender, EventArgs e)
        {
            InstructorAssignmentUp instructorAssignmentUp = new InstructorAssignmentUp(insName, insId);
            instructorAssignmentUp.Show();
            this.Hide();
        }

        private void InstructorAssignSub_Load(object sender, EventArgs e)
        {
            LoadAssignments(insId);
        }
        private void LoadAssignments(int userId)
        {
            using (SqlConnection conn = DbConnection.GetConnection()) 
            {
                conn.Open();
                string query = @"
            SELECT 
                asub.SubmissionID,
                asub.StudentID, 
                asub.SubmissionDate, 
                asub.FilePath, 
                asub.Marks, 
                asub.Feedback
            FROM AssignmentSubmissions asub
            JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
            JOIN Courses c ON a.CourseID = c.CourseID
            WHERE c.InstructorID = @InstructorID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InstructorID", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvAssignments.DataSource = dt; 
                    }
                }
            }
         
        }

        private void mark_up_tb_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignments.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a submission to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int submissionId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["SubmissionID"].Value);
                decimal marks;

             
                if (!decimal.TryParse(marks_tb.Text, out marks))
                {
                    MessageBox.Show("Please enter a valid numeric value for marks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string feedback = feeb_tb.Text.Trim();

                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                UPDATE AssignmentSubmissions 
                SET Marks = @Marks, Feedback = @Feedback 
                WHERE SubmissionID = @SubmissionID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Marks", marks);
                        cmd.Parameters.AddWithValue("@Feedback", feedback);
                        cmd.Parameters.AddWithValue("@SubmissionID", submissionId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Marks and Feedback updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Update failed. Submission not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        marks_tb.Text = "";
                        feeb_tb.Text = "";
                    }
                }

                LoadAssignments(insId);
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

        private void dwnl_btn_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment submission to download.");
                return;
            }

            int submissionId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["SubmissionID"].Value);
            DownloadStudentFile(submissionId);
        }

        private void DownloadStudentFile(int submissionId)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

               
                    string query = "SELECT FilePath, FileData FROM AssignmentSubmissions WHERE SubmissionID = @SubmissionID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubmissionID", submissionId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] fileData = reader["FileData"] as byte[];
                                string filePath = reader["FilePath"] as string;

                                if (fileData != null && fileData.Length > 0)
                                {
                                    string tempFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetFileName(filePath));

                                    File.WriteAllBytes(tempFilePath, fileData);
                                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(tempFilePath) { UseShellExecute = true });

                                    MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("File data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Submission not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    

