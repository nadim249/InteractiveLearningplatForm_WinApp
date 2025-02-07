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
    public partial class SAssUpl : Form
    {
        private string userName;
        private int userID;
        public SAssUpl(string name, int id)
        {
            InitializeComponent();
            userName = name;
            userID = id;
        }

        private void SAssUpl_Load(object sender, EventArgs e)
        {
            welcomelabe.Text = $"Welcome, {userName}!";
            

            LoadAssignments(userID);


        }
        private void LoadAssignments(int userId)
        {
            
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT DISTINCT a.AssignmentID, a.Title, a.Description, a.DueDate
            FROM Assignments a
            INNER JOIN Enrollments e ON a.CourseID = e.CourseID
            WHERE e.UserID = @UserID"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId); 

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvAssignments.DataSource = dt;
            }
        }



       

        private void coubuy_btn_Click_1(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }

        private void mycou_btn_Click_1(object sender, EventArgs e)
        {
            MyCouse myCouse = new MyCouse(userName, userID);
            myCouse.Show();
            this.Hide();

        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();

        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            SubmitAssignment(userID);

        }
        private void SubmitAssignment(int userId)
        {
            
            if (string.IsNullOrWhiteSpace(txtFilePath.Text) || dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment and a file.");
                return;
            }

        
            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("The selected file does not exist.");
                return;
            }

            try
            {
               
                int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);

               
                byte[] fileData = File.ReadAllBytes(txtFilePath.Text);

                
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                   
                    string checkQuery = "SELECT COUNT(*) FROM AssignmentSubmissions WHERE AssignmentID = @AssignmentID AND StudentID = @StudentID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                        checkCmd.Parameters.AddWithValue("@StudentID", userId); 

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("You have already submitted this assignment.");
                            return;
                        }
                    }

               
                    string query = "INSERT INTO AssignmentSubmissions (AssignmentID, StudentID, FilePath, SubmissionDate, FileData) " +
                                   "VALUES (@AssignmentID, @StudentID, @FilePath, @SubmissionDate, @FileData)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                        cmd.Parameters.AddWithValue("@StudentID", userId); 
                        cmd.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                        cmd.Parameters.AddWithValue("@SubmissionDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@FileData", fileData);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Assignment submitted successfully!");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File error: " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dwnl_btn_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to download.");
                return;
            }

            int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);
            DownloadTeacherFile(assignmentId);
        }


        private void DownloadTeacherFile(int assignmentId)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                  
                    string query = "SELECT FilePath, FileData FROM Assignments WHERE AssignmentID = @AssignmentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        byte[] fileData = reader["FileData"] as byte[];
                        string filePath = reader["FilePath"] as string;

                        if (fileData != null && fileData.Length > 0)
                        {
                            string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetFileName(filePath));

                            File.WriteAllBytes(tempFilePath, fileData);
                            System.Diagnostics.Process.Start(tempFilePath);



                            MessageBox.Show("File downloaded successfully!");
                        }
               
                    }
                    else
                    {
                        MessageBox.Show("Assignment not found or file is missing.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error downloading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void assg_result_btn_Click(object sender, EventArgs e)
        {
            AssignmentResult assignmentResult = new AssignmentResult(userName, userID);
            assignmentResult.Show();
            this.Hide();
        }

        private void annouc_btn_Click(object sender, EventArgs e)
        {
            AnnoucmentStudent annoucmentStudent = new AnnoucmentStudent(userName, userID);
            annoucmentStudent.Show();
            this.Hide();    
        }

        private void SAssUpl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
