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
    public partial class WebDevCoureVideo : Form
    {
        private string userName;
        private int userID;
        public WebDevCoureVideo(string name,int id)
        {
            InitializeComponent();
            LoadCourseData();

            userName = name;
            userID = id;

        }
        private async void WebDevCoureVideo_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async(null);
           

        }

        private void LoadCourseData()
        {

         
            lstVideoList.Items.Add("Video 1: Learn HTML");
            lstVideoList.Items.Add("Video 2: Learn CSS");
            lstVideoList.Items.Add("Video 3: Learn JS");
            lstVideoList.Items.Add("Video 4: Learn React");
        }
       
       
       
        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            MyCouse myCouses = new MyCouse(userName, userID);
            myCouses.Show();
            this.Hide();
        }

        private void lstVideoList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstVideoList.SelectedIndex == -1)
                return;

            string selectedVideo = lstVideoList.SelectedItem.ToString();

          
            var videoUrls = new Dictionary<string, string>
            {
                { "Video 1: Learn HTML", "https://www.youtube.com/embed/HD13eq_Pmp8?autohide=1&showinfo=0&modestbranding=1" },
                { "Video 2: Learn CSS", "https://www.youtube.com/embed/wRNinF7YQqQ?autohide=1&showinfo=0&modestbranding=1" },
                { "Video 3: Learn JS", "https://www.youtube.com/embed/PkZNo7MFNFg?autohide=1&showinfo=0&modestbranding=1" },
                { "Video 4: Learn React", "https://www.youtube.com/embed/SqcY0GlETPk?autohide=1&showinfo=0&modestbranding=1" }
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
            WebQuiz webQuiz = new WebQuiz(userName, userID);
            webQuiz.Show();
            this.Hide();
        }
    }
}
