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
    public partial class PaymentPage : Form
    {
       private string userName;
        private int userID;
        private int courseId;
        private string price;
        public PaymentPage(string name,int id,int cid,string pr)
        {
            InitializeComponent();
            userName = name;
            userID = id;
            courseId = cid;
            price = pr;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            CourseBuy courseBuy = new CourseBuy(userName,userID);
            courseBuy.Show();
            this.Hide();
        }

        private void mobile_btn_Click(object sender, EventArgs e)
        {
            MobilePay mb=new MobilePay(userName, userID,courseId,price);
            mb.Show();
            this.Hide();

        }

        private void card_btn_Click(object sender, EventArgs e)
        {
            CardPay cardPay = new CardPay(userName, userID,courseId,price);
            cardPay.Show();
            this.Hide();

        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {

        }
    }
}
