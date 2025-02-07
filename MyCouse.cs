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
    public partial class MyCouse : Form
    {
        private string userName;
        private int userID;
        public MyCouse(string name,int id)
        {
            InitializeComponent();
            userName = name;
            userID = id;
        }

      
        

    
      
        public List<int> GetUserEnrolledCourses(int userId)
        {
            List<int> enrolledCourseIds = new List<int>();

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT CourseID FROM Enrollments WHERE UserID = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        enrolledCourseIds.Add(reader.GetInt32(0));
                    }
                }
            }
            return enrolledCourseIds;
        }



        private void MyCouse_Load(object sender, EventArgs e)
        {
            welcomelabe.Text = $"Welcome, {userName} ";
            

            int userId = userID;
            List<int> enrolledCourseIds = GetUserEnrolledCourses(userId);

            panelCSharp.Visible = enrolledCourseIds.Contains(3);
            panelML.Visible = enrolledCourseIds.Contains(1);
            panelDS.Visible = enrolledCourseIds.Contains(4);
            panelWeb.Visible = enrolledCourseIds.Contains(2);

            flowLayoutPanel1.Controls.Clear();
            List<Panel> coursePanels = new List<Panel> { panelML, panelWeb, panelCSharp, panelDS };

            foreach (Panel panel in coursePanels)
            {
                if (panel.Visible)
                {
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }

        }

       

        private void ds_view_btn_Click(object sender, EventArgs e)
        {
            DsaCourseVideo dsaCourseVideo = new DsaCourseVideo(userName, userID);
            dsaCourseVideo.Show();
            this.Hide();
        }

        private void ml_view_btn_Click(object sender, EventArgs e)
        {
            MLCourseVideo mlCourseVideo = new MLCourseVideo(userName, userID);
            mlCourseVideo.Show();
            this.Hide();
        }

        private void web_view_btn_Click(object sender, EventArgs e)
        {
            WebDevCoureVideo webDevCoureVideo = new WebDevCoureVideo(userName, userID);
            webDevCoureVideo.Show();
            this.Hide();
        }

        private void csharp_view_btn_Click(object sender, EventArgs e)
        {
            CshrapCourseVideo cshrapCourseVideo = new CshrapCourseVideo(userName, userID);
            cshrapCourseVideo.Show();
            this.Hide();
        }

        private void coubuy_btn_Click_1(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();

        }


        private void assign_btn_Click_1(object sender, EventArgs e)
        {
            SAssUpl sa = new SAssUpl(userName, userID);
            sa.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();

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

        private void MyCouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
