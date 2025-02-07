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
    public partial class Enrollments : Form
    {
        public Enrollments()
        {
            InitializeComponent();
        }

       
        private void LoadUsersData()
        {

    
string query = "SELECT EnrollmentID, UserID, CourseID, EnrollmentDate FROM Enrollments";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

               dataGridViewenrollments.DataSource = dataTable;
            }
        }
        private void Enrollments_Load(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void add_en_btn_Click(object sender, EventArgs e)
        {
            try
            {
       
               
                if(string.IsNullOrEmpty(usid_tb.Text) || string.IsNullOrEmpty(cou_id_tb.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
                int userId = Convert.ToInt32(usid_tb.Text);
                int courseId = Convert.ToInt32(cou_id_tb.Text);

                string query = "INSERT INTO Enrollments (UserID, CourseID, EnrollmentDate) VALUES (@UserID, @CourseID, getDate())";

                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@CourseID", courseId);
                    command.ExecuteNonQuery();
                }
                LoadUsersData();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void en_updat_btn_Click(object sender, EventArgs e)
        {


        }

        private void en_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int enrollmentId = Convert.ToInt32(enr_idtb.Text);
                string query = "DELETE FROM Enrollments WHERE EnrollmentID = @EnrollmentID";
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                    command.ExecuteNonQuery();
                }
                LoadUsersData();
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void en_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {
          enr_idtb.Text = "";
            usid_tb.Text = "";
            cou_id_tb.Text = "";

        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            AdminDashboard admind1 = new AdminDashboard();
            admind1.Show();
            this.Close();
        }

        private void enrol_search_Click(object sender, EventArgs e)
        {
            string query;
            if (string.IsNullOrWhiteSpace(sear_en_tb.Text))
            {
                LoadUsersData();
                return;
            }
            else
            {
                int searchId = Convert.ToInt32(sear_en_tb.Text);
             
                query = "SELECT EnrollmentID, UserID, CourseID, EnrollmentDate FROM Enrollments WHERE EnrollmentID LIKE @SearchId";
            }

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchId", "%" + sear_en_tb.Text + "%");
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewenrollments.DataSource = dataTable;
            }
        }

        private void dataGridViewenrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewenrollments.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 0)
                {
             
                    enr_idtb.Text = selectedRow.Cells[0].Value.ToString();
                    usid_tb.Text = selectedRow.Cells[1].Value.ToString();
                    cou_id_tb.Text = selectedRow.Cells[2].Value.ToString();
                }
            }
        }
    }
}
