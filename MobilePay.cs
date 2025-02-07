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
    public partial class MobilePay : Form
    {
        private string userName;
        private int userID;
        private int courseId;
        private string price;
        public MobilePay(string username,int id,int cid,string pr)
        {
            InitializeComponent();
            userName = username;
            userID = id;
            courseId = cid;
            price = pr;
        }

        private void MobilePay_Load(object sender, EventArgs e)
        {
            pay_label.Text = "Pay: " + price+" TK";
            cmplte_btn.Enabled = false; 

            
            mobile_num_tb.TextChanged += ValidateInputs;
            pin_tb.TextChanged += ValidateInputs;
        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isMobileValid = mobile_num_tb.Text.Trim().Length == 11;
            bool isPinValid = pin_tb.Text.Trim().Length == 4;

            cmplte_btn.Enabled = isMobileValid && isPinValid;
        }

        private void cmplte_btn_Click(object sender, EventArgs e)
        {
            string mobileNumber = mobile_num_tb.Text.Trim();
            string pin = pin_tb.Text.Trim();

          
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                   
                    string paymentQuery = "INSERT INTO Payments (UserID, CourseID, Amount, PaymentMethod, PaymentStatus, TransactionDate) " +
                                          "VALUES (@UserID, @CourseID, @Amount, 'Mobile', 'Completed', GETDATE()); " +
                                          "SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(paymentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@CourseID", courseId);
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(price));

                        object result = cmd.ExecuteScalar();
                        int paymentId = result != null ? Convert.ToInt32(result) : 0;

                        if (paymentId > 0)
                        {
                           
                            string enrollmentQuery = "INSERT INTO Enrollments (UserID, CourseID, EnrollmentDate) VALUES (@UserID, @CourseID, GETDATE())";
                            using (SqlCommand enrollCmd = new SqlCommand(enrollmentQuery, conn))
                            {
                                enrollCmd.Parameters.AddWithValue("@UserID", userID);
                                enrollCmd.Parameters.AddWithValue("@CourseID", courseId);

                                enrollCmd.ExecuteNonQuery();
                            }
                         
                            Congratulations congratulations = new Congratulations(userName, userID);
                            congratulations.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Enrollment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }
    }
}
