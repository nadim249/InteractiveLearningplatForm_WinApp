using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterractiveLearningPlatform
{
    public partial class MLBuyPage : Form
    {
        private string userName;
        private int userID;
        private int courseId = 1;
        private string price = "10000";
        public MLBuyPage(string userName,int UserID)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = UserID;
        }

        private void MLBuyPage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }

        private void ml_buy_btn_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage(userName, userID,courseId,price);
            paymentPage.Show();
            this.Hide();
        }
    }
}
