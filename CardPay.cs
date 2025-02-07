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
    public partial class CardPay : Form
    {
        private string userName;
        private int userID;
        private int courseId;
        private string price ;
        public CardPay(string username,int id,int cid,string pr)
        {
            InitializeComponent();
            userName = username;
            userID = id;
            courseId = cid;
            price = pr;
        }
        private void CardPay_Load(object sender, EventArgs e)
        {
            pay_label.Text = "Pay: " + price + " TK";
            cmplte_btn.Enabled = false; 

            Card_num_tb.TextChanged += ValidateInputs;
            pin_tb.TextChanged += ValidateInputs;
            holder_name_tb.TextChanged += ValidateInputs;
            expire_tb.TextChanged += ValidateInputs;
            cvc_tb.TextChanged += ValidateInputs;


        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isCardNumValid = Card_num_tb.Text.Trim().Length == 16;
            bool isPinValid = pin_tb.Text.Trim().Length == 4;
            bool isHolderNameValid = !string.IsNullOrWhiteSpace(holder_name_tb.Text);
            bool isExpireValid = !string.IsNullOrWhiteSpace(expire_tb.Text);
            bool isCvcValid = !string.IsNullOrWhiteSpace(cvc_tb.Text);

            cmplte_btn.Enabled = isCardNumValid && isPinValid && isHolderNameValid && isExpireValid && isCvcValid;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }

        private void cmplte_btn_Click(object sender, EventArgs e)
        {
            string cardNumber = Card_num_tb.Text.Trim();
            string pin = pin_tb.Text.Trim();
            string holderName = holder_name_tb.Text.Trim();
            string expireDate = expire_tb.Text.Trim();
            string cvc = cvc_tb.Text.Trim();

            // Insert enrollment into the database
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string paymentQuery = "INSERT INTO Payments (UserID, CourseID, Amount, PaymentMethod, PaymentStatus, TransactionDate) " +
                                                      "VALUES (@UserID, @CourseID, @Amount, 'Card', 'Completed', GETDATE()); " +
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
    }
}
