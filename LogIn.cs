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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InterractiveLearningPlatform
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_login_tb.Text.Trim();
            string password = pasLogin_tb.Text.Trim();
            string role = comboBox1.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Email and Password are required fields.");
                return;
            }



            string query ="SELECT * FROM Users WHERE Email =@Email AND Password = @Password AND RoleID =@RoleID";
            
           

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RoleID", GetRoleID(role));
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        
                        dataAdapter.Fill(dt);
                    }

                    if (dt.Rows.Count == 1)
                    {
                        DataRow userRow = dt.Rows[0]; 
                        string userName = userRow["Name"].ToString(); 
                        int userID = Convert.ToInt32(userRow["UserID"]); 
                        MessageBox.Show("Login successful.");
                        if (role == "Admin")
                        {
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                        }
                        else if (role == "Instructor")
                        {
                           InstructorDashboard instructorDashboard = new InstructorDashboard(userName,userID);
                            instructorDashboard.Show();

                        }
                        else if (role == "Learner")
                        {
                            CourseBuy studentDashboard = new CourseBuy(userName, userID);
                            studentDashboard.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }

        }
        private int GetRoleID(string role)
        {
            switch (role)
            {
                case "Admin":
                    return 1;
                case "Instructor":
                    return 2;
                case "Learner":
                    return 3;
                default:
                    throw new ArgumentException("Invalid role");
            }
        }

        private void forget_btn_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPassword = new ForgetPass();
            forgetPassword.Show();
            this.Hide();
        }

        private void makerdt_btn_Click(object sender, EventArgs e)
        {
            DeveloperDetails developerDetails = new DeveloperDetails();
            developerDetails.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pasLogin_tb.UseSystemPasswordChar = !checkBox1.Checked;

        }
    }
}
