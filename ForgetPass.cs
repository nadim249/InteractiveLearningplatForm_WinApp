using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace InterractiveLearningPlatform
{
    public partial class ForgetPass : Form
    {
        private string generatedOTP = "";
        private string userEmail = "";

        public ForgetPass()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void usr_avail_chk_btn_Click(object sender, EventArgs e)
        {

            userEmail = email_tb.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Please enter an email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND RoleID = 3";


            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        int count = (int)cmd.ExecuteScalar(); 

                        if (count > 0)
                        {
                            generatedOTP = GenerateOTP();
                            loadingLabel.Visible = true;
                            backgroundWorker1.RunWorkerAsync();

                           
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadingLabel.Visible = false;

                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SendOTPEmail(userEmail, generatedOTP);

        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
      
            loadingLabel.Visible = false;

        
            MessageBox.Show("OTP has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        

        private void passcng_btn_Click(object sender, EventArgs e)
        {
            string otp = otp_tb.Text.Trim();   
            string newPassword = pass_tb.Text.Trim();
            string confirmPassword = confrim_pass_tb.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Please check user availability first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(otp) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (otp != generatedOTP)
            {
                MessageBox.Show("Invalid OTP. Please check your email and enter the correct OTP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Email not found. Please enter a registered email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); 
        }

       
        private void SendOTPEmail(string toEmail, string otp)
        {
            try
            {
                string fromEmail = "mahmoudnadim47@gmail.com"; 
                string fromPassword = "zukbcwajnntseetn"; 

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = $"Your OTP code for password reset is: {otp}\n\nDo not share this code with anyone.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP. Error: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
