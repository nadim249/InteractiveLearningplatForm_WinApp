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
using static InterractiveLearningPlatform.InstructorAnnoument;

namespace InterractiveLearningPlatform
{
    public partial class AnnoucmentStudent : Form
    {
        private string userName;
        private int userId;
        public AnnoucmentStudent(string userName, int userId)
        {
            InitializeComponent();
            this.userName = userName;
            this.userId = userId;
        }

        private void AnnoucmentStudent_Load(object sender, EventArgs e)
        {
            LoadAnnoucment(userId);
        }

        private void LoadAnnoucment(int userId)
        {
            try
            {
                listBox1.Items.Clear();

                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT a.Id, a.Message, a.PostedDate
                FROM Announcements a
                JOIN Enrollments e ON a.CourseID = e.CourseID
                WHERE e.UserID = @UserID
                ORDER BY a.PostedDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
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

        private void logut_btn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void coubuy_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName,userId);
            courseBuy.Show();
            this.Hide();
        }

        private void mycou_btn_Click(object sender, EventArgs e)
        {
            MyCouse myCouse = new MyCouse(userName, userId);
            myCouse.Show();
            this.Hide();
        }

        private void assign_btn_Click(object sender, EventArgs e)
        {
            SAssUpl sAssUplo = new SAssUpl(userName, userId);
            sAssUplo.Show();
            this.Hide();
        }

        private void assg_result_btn_Click(object sender, EventArgs e)
        {
            AssignmentResult assignmentResult = new AssignmentResult(userName, userId);
            assignmentResult.Show();
            this.Hide();
        }

        private void annouc_btn_Click(object sender, EventArgs e)
        {
            AnnoucmentStudent annoucmentStudent = new AnnoucmentStudent(userName, userId);
            annoucmentStudent.Show();
            this.Hide();
        }

        private void AnnoucmentStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
