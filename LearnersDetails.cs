using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace InterractiveLearningPlatform
{
    public partial class LearnersDetails : Form
    {

        public LearnersDetails()
        {
            InitializeComponent();
        }

       

       

        
        private void LearnersDetails_Load(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void LoadUsersData()
        {

         
            string query = "SELECT UserID, Name, Email, Password, Mobile, DOB, Address FROM Users WHERE RoleID = 3";


            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

              
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard admind1 = new AdminDashboard();
            admind1.Show();
            this.Close();
        }

        private void LearnerAdd_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string mobile = MobilrTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            DateTime dob = dateTimeDOB.Value;
            string password = PasswordTB.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Name, Email, and Mobile are required fields.");
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
                        LoadUsersData(); 
                        ClearTextBox();

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

        private void LearnerUpdate_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(MobilrTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                string updatedName = NameTextBox.Text.Trim();
                string updatedEmail = EmailTextBox.Text.Trim();
                string updatedMobile = MobilrTextBox.Text.Trim();
                string updatedAddress = AddressTextBox.Text.Trim();
                DateTime updatedDOB = dateTimeDOB.Value;
                string updatepassword = PasswordTB.Text.Trim();

            
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password=@Password,Mobile = @Mobile, DOB = @DOB, Address = @Address WHERE UserID = @UserID";

                try
                {
                    using (SqlConnection connection = DbConnection.GetConnection())
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", updatedName);
                        command.Parameters.AddWithValue("@Email", updatedEmail);
                        command.Parameters.AddWithValue("@Mobile", updatedMobile);
                        command.Parameters.AddWithValue("@DOB", updatedDOB);
                        command.Parameters.AddWithValue("@Address", updatedAddress);
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@Password", updatepassword);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully.");
                            ClearTextBox();

                            
                            LoadUsersData();  
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check your input.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the user details: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No user selected for update.");
            }

        }


        private void LearnerDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                

                try
                {
                    using (SqlConnection connection = DbConnection.GetConnection())
                    {
                        string query = "DELETE FROM Users WHERE UserID = @UserID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserID", userId);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                
                    LoadUsersData();
                    MessageBox.Show("User deleted successfully.");
                    ClearTextBox();

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) 
                    {
                        MessageBox.Show("Cannot delete this user because they have associated records in other tables.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No user selected for deletion.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower();

          
            string query = "SELECT UserID, Name, Email, Password, Mobile, DOB, Address" +
                " FROM Users WHERE (Name LIKE @SearchTerm OR Email LIKE @SearchTerm) AND RoleID = 3";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

               
                dataGridView1.DataSource = dataTable;
            }
        }

        private void LearnerCancle_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            MobilrTextBox.Clear();
            AddressTextBox.Clear();
            dateTimeDOB.ResetText();
            PasswordTB.Clear();
            dateTimeDOB.ResetText();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

             
                if (selectedRow.Cells.Count > 6)
                {
                  
                    NameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    EmailTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    MobilrTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    AddressTextBox.Text = selectedRow.Cells[6].Value.ToString();
                    dateTimeDOB.Text = selectedRow.Cells[5].Value.ToString();
                    PasswordTB.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
        }

      
    }
}
