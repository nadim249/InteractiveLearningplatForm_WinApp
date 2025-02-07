using System;
using System.Collections;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

     

        private void Ad_Learner_btn_Click(object sender, EventArgs e)
        {
            LearnersDetails ld1 = new LearnersDetails();
            ld1.Show();
            this.Hide();
        }

        private void Ad_Instructor_btn_Click(object sender, EventArgs e)
        {
            InstructorDetails insd1 = new InstructorDetails();
            insd1.Show();
            this.Hide();
        }

        private void Ad_Course_btn_Click(object sender, EventArgs e)
        {
            CoursesDetails cod1 = new CoursesDetails();
            cod1.Show();
            this.Hide();
        }

        private void Ad_PayDetail_btn_Click(object sender, EventArgs e)
        {
            Paydetails pad1 = new Paydetails();
            pad1.Show();
            this.Hide();
        }



        //Total items
        private void LoadUsersData()
        {


            string query1 = "SELECT COUNT(*) FROM Users WHERE RoleID = 3";
            string query2 = "SELECT COUNT(*) FROM Courses";
            string query3 = "SELECT COUNT(*) FROM Users WHERE RoleID = 2";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                    
                        int count = (int)command.ExecuteScalar();

                      
                        tl_learn.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                   
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        
                        int count = (int)command.ExecuteScalar();

                      
                        tl_cours.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                      
                        int count = (int)command.ExecuteScalar();

                     
                        tl_Inst.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void enrollm_btn_Click(object sender, EventArgs e)
        {

           Enrollments insd1 = new Enrollments();
            insd1.Show();
            this.Hide();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            LogIn log1 = new LogIn();
            log1.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            CoursesDetails cod1 = new CoursesDetails();
            cod1.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            LearnersDetails learnersDetails = new LearnersDetails();
            learnersDetails.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            InstructorDetails instructorDetails = new InstructorDetails();
            instructorDetails.Show();
            this.Hide();
        }
    }
}
