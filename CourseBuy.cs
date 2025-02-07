using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InterractiveLearningPlatform
{
    public partial class CourseBuy : Form
    {
        private string userName;
        private int userID;

        public CourseBuy(string name, int id) 
        {
            InitializeComponent();
            userName = name;
            userID = id;
        }

        private void CourseBuy_Load(object sender, EventArgs e)
        {
            welcomelabe.Text = $"Welcome, {userName}!";
            //id_label.Text=$" Your ID is {userID}.";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LogIn log1 = new LogIn();

            log1.Show();
            this.Hide();
        }

        private void coubuy_btn_Click(object sender, EventArgs e)
        {
            CourseBuy cb1 = new CourseBuy(userName, userID);
            cb1.Show();
            this.Hide();
        }

        private void mycou_btn_Click(object sender, EventArgs e)
        {
            MyCouse mc1 = new MyCouse(userName, userID);
            mc1.Show();
            this.Hide();
        }

        private void assign_btn_Click(object sender, EventArgs e)
        {
            SAssUpl sa1 = new SAssUpl(userName, userID);
            sa1.Show();
            this.Hide();
        }

        private void ds_details_btn_Click(object sender, EventArgs e)
        {
            DsaBuy ds1 = new DsaBuy(userName, userID);
            ds1.Show();
            this.Hide();
        }

        private void ml_details_btn_Click(object sender, EventArgs e)
        {
            MLBuyPage ml1 = new MLBuyPage(userName, userID);
            ml1.Show();
            this.Hide();
        }

        private void web_details_btn_Click(object sender, EventArgs e)
        {
            WebDevBuy web1 = new WebDevBuy(userName, userID);
            web1.Show();
            this.Hide();
        }

        private void csharp_details_btn_Click(object sender, EventArgs e)
        {
            CSharpBuy csharp1 = new CSharpBuy(userName, userID);
            csharp1.Show();
            this.Hide();
        }

        private void assg_result_btn_Click(object sender, EventArgs e)
        {
            AssignmentResult assignmentResult = new AssignmentResult(userName, userID);
            assignmentResult.Show();
            this.Hide();
        }

        private void annouc_btn_Click(object sender, EventArgs e)
        {
            AnnoucmentStudent annoucmentStudent = new AnnoucmentStudent(userName, userID);
            annoucmentStudent.Show();
            this.Hide();
        }

        private void CourseBuy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
