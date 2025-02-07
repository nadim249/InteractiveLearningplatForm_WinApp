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
    public partial class DsaCourseVideo : Form
    {
        private string userName;
        private int userID;
        public DsaCourseVideo(string name,int id)
        {
            InitializeComponent();
            LoadCourseData();
            userName = name;
            userID = id;
        }
        private async void DsaCourseVideo_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async(null);

        }
        private void LoadCourseData()
        {

            // Add YouTube video titles
            lstVideoList.Items.Add("C++ Basics in One Shot");
            lstVideoList.Items.Add("Time and Space Complexity");
            lstVideoList.Items.Add("Complete C++ STL");
            lstVideoList.Items.Add("Introduction to Recursion");
            lstVideoList.Items.Add("Merge Sort");
        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            MyCouse myCouses = new MyCouse(userName, userID);
            myCouses.Show();
            this.Hide();
        }

        private void lstVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideoList.SelectedIndex == -1)
                return;

            string selectedVideo = lstVideoList.SelectedItem.ToString();

            var videoUrls = new Dictionary<string, string>
            {
                { "C++ Basics in One Shot", "https://www.youtube.com/embed/EAR7De6Goz4?autohide=1&showinfo=0&modestbranding=1" },
                { "Time and Space Complexity", "https://www.youtube.com/embed/FPu9Uld7W-E?autohide=1&showinfo=0&modestbranding=1" },
                { "Complete C++ STL", "https://www.youtube.com/embed/RRVYpIET_RU?autohide=1&showinfo=0&modestbranding=1" },
                { "Introduction to Recursion", "https://www.youtube.com/embed/yVdKa8dnKiE?autohide=1&showinfo=0&modestbranding=1" },
                {
                "Merge Sort", "https://www.youtube.com/embed/ogjf7ORKfd8?autohide=1&showinfo=0&modestbranding=1"}

            };
            if (videoUrls.TryGetValue(selectedVideo, out string videoUrl))
            {
                if (!string.IsNullOrEmpty(videoUrl))
                {
                    webView2.Source = new Uri(videoUrl);

                    this.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                MessageBox.Show("Video URL not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DsaQuiz dsaQuiz = new DsaQuiz(userName, userID);
            dsaQuiz.Show();
            this.Hide();
        }
    }
}
