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
    public partial class Paydetails : Form
    {

        public Paydetails()
        {
            InitializeComponent();
        }

       
    
        private void LoadUsersData()
        {

          
            string query = "SELECT PaymentID, UserID, CourseID, Amount,PaymentMethod,PaymentStatus,TransactionDate FROM Payments";


            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

             
                dataGridViewpay.DataSource = dataTable;
            }
        }

        private void Paydetails_Load(object sender, EventArgs e)
        {
            LoadUsersData();

        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashboard admind1 = new AdminDashboard();
            admind1.Show();
            this.Close();
        }

       
        private void pay_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();

        }
        private void ClearTextBox()
        {
            pay_id_tb.Clear();
           usr_id_tb.Clear();
            cour_id_tb.Clear();
            paymeth_tb.Clear();
           amt_tb.Clear();
            paysta_tb.Clear();

        }

        private void dataGridViewpay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewpay.Rows[e.RowIndex];

            
                if (selectedRow.Cells.Count >= 0)
                {
                 
                    pay_id_tb.Text = selectedRow.Cells[0].Value.ToString();
                    usr_id_tb.Text = selectedRow.Cells[1].Value.ToString();
                    cour_id_tb.Text = selectedRow.Cells[2].Value.ToString();
                    paymeth_tb.Text = selectedRow.Cells[4].Value.ToString();
                    amt_tb.Text = selectedRow.Cells[3].Value.ToString();
                    paysta_tb.Text = selectedRow.Cells[5].Value.ToString();
                }
            }
        }

        private void del_pay_btn_Click(object sender, EventArgs e)
        {
            string paymentID = pay_id_tb.Text;
            if (string.IsNullOrEmpty(paymentID))
            {
                MessageBox.Show("Please select a payment to delete");
                return;
            }
            string query = "DELETE FROM Payments WHERE PaymentID = @PaymentID";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PaymentID", paymentID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadUsersData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting payment: " + ex.Message);
                }
            }

        }

        private void add_pay_btn_Click(object sender, EventArgs e)
        {
            string paymentID = pay_id_tb.Text;
            string userID = usr_id_tb.Text;
            string courseID = cour_id_tb.Text;
            string amount = amt_tb.Text;
            string paymentMethod = paymeth_tb.Text;
            string paymentStatus = paysta_tb.Text;
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(courseID) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string query = "INSERT INTO Payments (UserID, CourseID, Amount, PaymentMethod,PaymentStatus) VALUES (@UserID, @CourseID, @Amount, @PaymentMethod,@PaymentStatus)";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadUsersData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error adding payment: " + ex.Message);
                }
            }

        }

        private void update_pay_btn_Click(object sender, EventArgs e)
        {
            string paymentID = pay_id_tb.Text;
            string userID = usr_id_tb.Text;
            string courseID = cour_id_tb.Text;
            string amount = amt_tb.Text;
            string paymentMethod = paymeth_tb.Text;
            string paymentStatus = paysta_tb.Text;
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(courseID) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string query = "UPDATE Payments SET UserID = @UserID, CourseID = @CourseID, Amount = @Amount, PaymentMethod = @PaymentMethod, PaymentStatus = @PaymentStatus WHERE PaymentID = @PaymentID";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PaymentID", paymentID);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadUsersData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error updating payment: " + ex.Message);
                }
            }

        }

        private void pay_sea_btn_Click(object sender, EventArgs e)
        {
            string query;
            if (string.IsNullOrWhiteSpace(search_pay_tb.Text))
            {
                LoadUsersData();
                return;
            }
            else
            {
                int searchId = Convert.ToInt32(search_pay_tb.Text);
               
                query = "SELECT PaymentID, UserID, CourseID, Amount, PaymentMethod, PaymentStatus, TransactionDate FROM Payments WHERE PaymentID LIKE @SearchId";
            }

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchId", "%" + search_pay_tb.Text + "%");
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewpay.DataSource = dataTable;
            }
        }

    }
}
