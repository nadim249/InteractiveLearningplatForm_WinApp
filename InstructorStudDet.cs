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
   
    public partial class InstructorStudDet : Form
    {
        private string insName;
        private int insId;
        public InstructorStudDet(string insName, int insId)
        {
            InitializeComponent();
            this.insName = insName;
            this.insId = insId;
        }

        private void ins_home_btn_Click(object sender, EventArgs e)
        {
            InstructorStudDet instructorStudDet = new InstructorStudDet(insName,insId);
            instructorStudDet.Show();
            this.Hide();
        }

        private void stu_pro_btn_Click(object sender, EventArgs e)
        {
            InstructorStudInfo instructorStudInfo = new InstructorStudInfo(insName,insId);
            instructorStudInfo.Show();
            this.Hide();
        }

        private void ins_stu_perf_btn_Click(object sender, EventArgs e)
        {
            InstructorStudPerf instructorStudPerf = new InstructorStudPerf(insName,insId);
            instructorStudPerf.Show();
            this.Hide();
        }

        private void ins_back_btn_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(insName,insId);
            instructorDashboard.Show();
            this.Hide();
        }
    }
}
