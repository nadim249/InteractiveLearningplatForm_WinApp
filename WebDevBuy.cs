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
    public partial class WebDevBuy : Form
    {
        private string userName;
        private int userID;
        private int courseId = 2;
        private string price = "6500";
        public WebDevBuy(string name,int id)
        {
            InitializeComponent();
            userName = name;
            userID = id;

        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }

        private void web_buy_btn_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage(userName,userID,courseId,price);
            paymentPage.Show();
            this.Hide();
        }
    }
}
