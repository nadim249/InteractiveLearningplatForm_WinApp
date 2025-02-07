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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterractiveLearningPlatform
{
    public partial class InstructorDetails : Form
    {

        public InstructorDetails()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void LoadUsersData()
        {

         
            string query = "SELECT  u.UserID,u.Name AS InstructorName,u.Email, u.Mobile,c.CourseName,u.Password " +
                               "FROM Courses c " +
                               "JOIN Users u ON c.InstructorID = u.UserID " +
                               "WHERE u.RoleID = 2";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

         
                dataGridViewIns.DataSource = dataTable;
            }
        }


        private void InstructorDetails_Load(object sender, EventArgs e)
        {
            LoadUsersData();

        }

        private void inst_back_btn_Click(object sender, EventArgs e)
        {
            AdminDashboard admind1 = new AdminDashboard();
            admind1.Show();
            this.Close();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewIns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewIns.Rows[e.RowIndex];

              
                if (selectedRow.Cells.Count >= 5)
                {
                    
                    nametxboxLe.Text = selectedRow.Cells[1].Value.ToString();
                    emailxboxLe.Text = selectedRow.Cells[2].Value.ToString();
                    mobiletxboxLe.Text = selectedRow.Cells[3].Value.ToString();
                    coursetxboxLe.Text = selectedRow.Cells[4].Value.ToString();
                    passtxboxLe.Text = selectedRow.Cells[5].Value.ToString();
                }
            }
        }

        private void ins_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {
            nametxboxLe.Clear();
            emailxboxLe.Clear();
            mobiletxboxLe.Clear();
            coursetxboxLe.Clear();
            passtxboxLe.Clear();

        }

        private void ins_add_us_btn_Click(object sender, EventArgs e)
        {
            string name = nametxboxLe.Text.Trim();
            string email = emailxboxLe.Text.Trim();
            string mobile = mobiletxboxLe.Text.Trim();
            string course = coursetxboxLe.Text.Trim();
            string password = passtxboxLe.Text.Trim();

      
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Name, Email,Course and Mobile are required fields.");
                return;
            }

            string userQuery = "INSERT INTO Users (Name, Email, Password, Mobile, RoleID) " +
                        "OUTPUT INSERTED.UserID VALUES (@Name, @Email, @Password, @Mobile, 2)";

            string courseQuery = "INSERT INTO Courses (CourseName, InstructorID) VALUES (@CourseName, @InstructorID)";
            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@Name", name);
                        userCommand.Parameters.AddWithValue("@Email", email);
                        userCommand.Parameters.AddWithValue("@Password", password);
                        userCommand.Parameters.AddWithValue("@Mobile", mobile);

                 
                        int userID = (int)userCommand.ExecuteScalar();

                        if (userID > 0)
                        {
                            using (SqlCommand courseCommand = new SqlCommand(courseQuery, connection))
                            {
                                courseCommand.Parameters.AddWithValue("@CourseName", course);
                                courseCommand.Parameters.AddWithValue("@InstructorID", userID);

                                int courseRowsInserted = courseCommand.ExecuteNonQuery();
                                if (courseRowsInserted > 0)
                                {
                                    MessageBox.Show("New learner and course added successfully.");
                                    LoadUsersData();
                                    ClearTextBox();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add the course. Please try again.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the new learner. Please try again.");
                        }
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

        private void ins_upt_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nametxboxLe.Text) ||
                string.IsNullOrWhiteSpace(emailxboxLe.Text) ||
                string.IsNullOrWhiteSpace(mobiletxboxLe.Text) ||
                string.IsNullOrWhiteSpace(passtxboxLe.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            if (dataGridViewIns.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewIns.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dataGridViewIns.Rows[selectedRowIndex].Cells[0].Value);

                string upname = nametxboxLe.Text.Trim();
                string upemail = emailxboxLe.Text.Trim();
                string upmobile = mobiletxboxLe.Text.Trim();
                string upcourse = coursetxboxLe.Text.Trim();
                string uppassword = passtxboxLe.Text.Trim();

     
                string query = "UPDATE Users SET Name = @Name, Email = @Email, Password=@Password,Mobile = @Mobile WHERE UserID = @UserID";

                try
                {
                    using (SqlConnection connection = DbConnection.GetConnection())
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", upname);
                        command.Parameters.AddWithValue("@Email", upemail);
                        command.Parameters.AddWithValue("@Mobile", upmobile);

                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@Password", uppassword);

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

        private void ins_del_btn_Click(object sender, EventArgs e)
        {
            if (dataGridViewIns.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewIns.SelectedRows[0].Index;
                int userId = Convert.ToInt32(dataGridViewIns.Rows[selectedRowIndex].Cells[0].Value);



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

        private void ins_sear_btn_Click(object sender, EventArgs e)
        {

            string searchTerm = ins_se_tb.Text.ToLower();

    
            string query = "SELECT UserID, Name, Email, Password, Mobile, DOB, Address" +
                " FROM Users WHERE (Name LIKE @SearchTerm OR Email LIKE @SearchTerm) AND RoleID = 2";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

  
                dataGridViewIns.DataSource = dataTable;

            }
        }
    }
}
