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
    public partial class Congratulations : Form
    {
        private string userName;
        private int userID;
        public Congratulations(string userName, int userID)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = userID;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCouse course = new MyCouse(userName, userID);
            course.Show();
            this.Hide();

        }
    }
}
