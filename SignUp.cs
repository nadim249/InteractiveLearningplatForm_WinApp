using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterractiveLearningPlatform
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

      

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text.Trim();
            string email = email_tb.Text.Trim();
            string mobile = mobile_tb.Text.Trim();
            string address = addr_tb.Text.Trim();
            DateTime dob = datepicksign.Value;
            string password = pass_tb.Text.Trim();
            string confirmPassword = confrim_pass_tb.Text.Trim();

           
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Name, Email, and Mobile are required fields.");
                return;
            }

           

            
            if (!Regex.IsMatch(mobile, @"^\d{11,13}$")) 
            {
                MessageBox.Show("Invalid mobile number. only digits and be 10-15 characters long.");
                return;
            }

           
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            string query = "INSERT INTO Users (Name, Email,Password, Mobile, DOB, Address, RoleID)" +
                " VALUES (@Name, @Email,@Password, @Mobile, @DOB, @Address, 3)";

            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Address", address);


                    connection.Open();
                    int rowsInserted = command.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("New learner added successfully.");
                        ClearTextBox();
                        LogIn l1 = new LogIn();
                        l1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add the new learner. Please try again.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the learner: {ex.Message}");
            }

        }
        private void ClearTextBox()
        {
            name_tb.Clear();
            email_tb.Clear();
            mobile_tb.Clear();
            addr_tb.Clear();
            datepicksign.ResetText();
            pass_tb.Clear();
            confrim_pass_tb.ResetText();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn();
            l1.Show();
            this.Hide();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
