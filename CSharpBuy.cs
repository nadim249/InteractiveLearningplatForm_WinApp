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
    public partial class CSharpBuy : Form
    {
        private int userID;
        private string userName;
        private int courseId = 3;
        private string price = "5000";

        public CSharpBuy(string usernName,int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = usernName;
        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName, userID);
            courseBuy.Show();
            this.Hide();
        }

        private void cs_buy_btn_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage(userName, userID, courseId, price);
            paymentPage.Show();
            this.Hide();


        }


        
    }
}
