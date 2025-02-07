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

using static System.Net.Mime.MediaTypeNames;

namespace InterractiveLearningPlatform
{
    public partial class CoursesDetails : Form
    {
        public CoursesDetails()
        {
            InitializeComponent();
        }

        private void LoadCoursesData()
        {
            string query = "SELECT CourseID, CourseName, Description, InstructorID FROM Courses";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to DataGridView
                dataGridViewcourse.DataSource = dataTable;
            }
        }

        private void CoursesDetails_Load(object sender, EventArgs e)
        {
            LoadCoursesData();
        }

        private void course_back_btn_Click(object sender, EventArgs e)
        {
            AdminDashboard admind1 = new AdminDashboard();
            admind1.Show();
            this.Hide();
        }

        private void dataGridViewcourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewcourse.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 3)
                {
                    cous_nametb.Text = selectedRow.Cells[1].Value.ToString();
                    descrp_cou_tb.Text = selectedRow.Cells[2].Value.ToString();
                    ins_id_tb.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
        }

        private void couse_cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            cous_nametb.Clear();
            descrp_cou_tb.Clear();
            ins_id_tb.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_cous_btn_Click(object sender, EventArgs e)
        {
            string courseName = cous_nametb.Text;
            string description = descrp_cou_tb.Text;
            string instructorID = ins_id_tb.Text;
            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(instructorID))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string query = "INSERT INTO Courses (CourseName, Description, InstructorID) VALUES (@CourseName, @Description, @InstructorID)";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@InstructorID", instructorID);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadCoursesData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void coursr_updat_btn_Click(object sender, EventArgs e)
        {
            string courseName = cous_nametb.Text;
            string description = descrp_cou_tb.Text;
            string instructorID = ins_id_tb.Text;
            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(instructorID))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string query = "UPDATE Courses SET CourseName = @CourseName, Description = @Description, InstructorID = @InstructorID WHERE CourseID = @CourseID";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@InstructorID", instructorID);
                command.Parameters.AddWithValue("@CourseID", dataGridViewcourse.SelectedRows[0].Cells[0].Value);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadCoursesData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void couse_delete_btn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseID", dataGridViewcourse.SelectedRows[0].Cells[0].Value);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadCoursesData();
                    ClearTextBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void sea_btn_cou_Click(object sender, EventArgs e)
        {
            string search = seach_tb_cou.Text.ToLower();
            string query = "SELECT CourseID, CourseName, Description, InstructorID FROM Courses WHERE CourseName LIKE @Search OR Description LIKE @Search OR InstructorID LIKE @Search";
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + search + "%");
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridViewcourse.DataSource = dataTable;
            }


        }

        private void CoursesDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    
}

