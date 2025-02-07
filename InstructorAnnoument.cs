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
    public partial class InstructorAnnoument : Form
    {
        private string insName;
        private int insId;
        public InstructorAnnoument(string insName, int insId)
        {
            InitializeComponent();
            
            this.insName = insName;
            this.insId = insId;
            LoadAnnouncements(insId);

        }

        public class AnnouncementItem
        {
            public int Id { get; set; }
            public string Message { get; set; }
            public DateTime PostedDate { get; set; }

            public override string ToString()
            {
                return $"{PostedDate}: {Message}";
            }
        }


        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName,insId);
            instructorDashboard.Show();
            this.Hide();
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            string message = post_tb.Text.Trim(); 

            if (!string.IsNullOrWhiteSpace(message))
            {
                try
                {
               
                    int courseId = GetCourseIdByInstructorId(insId);

                    if (courseId > 0) 
                    {
                        using (SqlConnection conn = DbConnection.GetConnection())
                        {
                            conn.Open();
                            string query = "INSERT INTO Announcements (Message, InstructorID, CourseID) VALUES (@Message, @InstructorID, @CourseID)";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Message", message);
                                cmd.Parameters.AddWithValue("@InstructorID", insId); 
                                cmd.Parameters.AddWithValue("@CourseID", courseId); 
                                cmd.ExecuteNonQuery();
                            }
                        }

                        LoadAnnouncements(insId); 
                        post_tb.Clear(); 
                        MessageBox.Show("Announcement posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No course found for the instructor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error posting announcement: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter an announcement.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private int GetCourseIdByInstructorId(int instructorId)
        {
            int courseId = 0;  
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CourseID FROM Courses WHERE InstructorID = @InstructorID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InstructorID", instructorId);
                        var result = cmd.ExecuteScalar(); 

                        if (result != null)
                        {
                            courseId = Convert.ToInt32(result);
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
                MessageBox.Show("Error retrieving course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return courseId;
        }


        private void LoadAnnouncements(int insID) {

            try
            {
                listBox1.Items.Clear();
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Message, PostedDate FROM Announcements WHERE InstructorID= @insId ORDER BY PostedDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) { 
                        cmd.Parameters.AddWithValue("@insId", insId);
                    
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                AnnouncementItem item = new AnnouncementItem
                                {
                                    Id = (int)reader["Id"],
                                    Message = reader["Message"].ToString(),
                                    PostedDate = (DateTime)reader["PostedDate"]
                                };

                                
                                listBox1.Items.Add(item);
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
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void post_delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
            
                AnnouncementItem selectedItem = (AnnouncementItem)listBox1.SelectedItem;

                
                int announcementId = selectedItem.Id;

                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Announcements WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", announcementId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Announcement deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Error: Announcement not found in the database.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting announcement: " + ex.Message);
                    }
                }

              
                LoadAnnouncements(insId);
            }
            else
            {
                MessageBox.Show("Please select an announcement to delete.");
            }
        }

    }
}
