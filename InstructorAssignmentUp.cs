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
    public partial class InstructorAssignmentUp : Form
    {
        private string insName;
        private int insId;

        public InstructorAssignmentUp(string insName, int insId)
        {
            InitializeComponent();
            this.insName = insName;
            this.insId = insId;
        }

    

        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName,insId);
            instructorDashboard.Show();
            this.Hide();
        }

        private void assg_sub_btn_Click(object sender, EventArgs e)
        {
            InstructorAssignSub instructorAssignSub = new InstructorAssignSub(insName,insId);
            instructorAssignSub.Show();
            this.Hide();
        }

        private void InstructorAssignmentUp_Load(object sender, EventArgs e)
        {
            LoadAssignments(insId);
            CouseIDSet();
        }
        private void CouseIDSet()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT CourseID FROM Courses WHERE InstructorID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", insId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    csid_tb.Text = reader["CourseID"].ToString();
                }
            }
        }
        private void LoadAssignments(int userId)
        {
            
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT DISTINCT a.AssignmentID, a.Title, a.Description, a.DueDate,a.FilePath
            FROM Assignments a
            INNER JOIN Courses c ON a.CourseID = c.CourseID
            WHERE c.InstructorID = @UserID"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAssignments.DataSource = dt;
            }
     
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                lblStatus.Text = "Please fill in all fields.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
             
                byte[] fileData =File.ReadAllBytes(txtFilePath.Text);

       
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO Assignments (CourseID,Title, Description, FilePath, DueDate, FileData) " +
                                   "VALUES (@CourseID,@Title, @Description, @FilePath, @DueDate, @FileData)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", csid_tb.Text); 
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                        cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                        cmd.Parameters.AddWithValue("@FileData", fileData);

                        cmd.ExecuteNonQuery();
                    }
                }
                LoadAssignments(insId);

                lblStatus.Text = "Assignment uploaded successfully!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void assignment_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssignments.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an assignment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);

                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Assignments WHERE AssignmentID = @AssignmentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AssignmentID", assignmentId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No assignment found with the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                LoadAssignments(insId); 
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: Assignment is Provided to Student You can't delete it", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
