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
    public partial class InstructorDashboard : Form
    {
        private string insName;
        private int insId;
        private string couName;
        public InstructorDashboard(string name,int id)
        {
            InitializeComponent();
            insName = name;
            insId = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void ins_announce_btn_Click(object sender, EventArgs e)
        {
            InstructorAnnoument instructorAnnoument = new InstructorAnnoument(insName,insId);
            instructorAnnoument.Show();
            this.Hide();
        }

        private void ins_my_stu_btn_Click(object sender, EventArgs e)
        {
            InstructorStudDet instructorStudDet = new InstructorStudDet(insName,insId);
            instructorStudDet.Show();
            this.Hide();
        }

        private void ins_assign_btn_Click(object sender, EventArgs e)
        {
            InstructorAssignmentUp instructorAssignmentUp = new InstructorAssignmentUp(insName,insId);
            instructorAssignmentUp.Show();
            this.Hide();
        }

        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {
            labelwel.Text = " Welcome " + insName;
            courseName(insId);

        }

        private void courseName(int insId)
        {

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

              
                    string query = "SELECT CourseName FROM Courses WHERE InstructorID = @InstructorID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
           
                        cmd.Parameters.AddWithValue("@InstructorID", insId);

       
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            couName = result.ToString();
                        }
                        else
                        {
                            couName = "No course assigned"; 
                        }
                    }
                }

                labelcousename.Text = "Course Name: " + couName;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ins_back_btn_Click_1(object sender, EventArgs e)
        {

            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void InstructorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
Application.Exit();
        }
    }
}
