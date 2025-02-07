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
    
    public partial class CshrapCourseVideo : Form
    {
        private string userName;
        private int userID;
        public CshrapCourseVideo(string name,int id)
        {
            InitializeComponent();
            LoadCourseData();

            userName = name;
            userID = id;
        }

        private void enr_back_btn_Click(object sender, EventArgs e)
        {
            MyCouse myCouses = new MyCouse(userName, userID);
            myCouses.Show();
            this.Hide();
        }

        private async void CshrapCourseVideo_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async(null);
        }
        private void LoadCourseData()
        {
            lstVideoList.Items.Add("Learn C# Basics");
            lstVideoList.Items.Add("Debugging C# Code in Visual Studio");
            lstVideoList.Items.Add("C# Classes Tutorial");
            lstVideoList.Items.Add("C# Constructors Tutorial");
            lstVideoList.Items.Add("C# Methods Tutorial");
        }

        private void lstVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideoList.SelectedIndex == -1)
                return;

            string selectedVideo = lstVideoList.SelectedItem.ToString();
            var videoUrls = new Dictionary<string, string>
            {
                { "Learn C# Basics", "https://www.youtube.com/embed/gfkTfcpWqAY?autohide=1&showinfo=0&modestbranding=1" },
                { "Debugging C# Code in Visual Studio", "https://www.youtube.com/embed/u-HdLtqEOog?autohide=1&showinfo=0&modestbranding=1" },
                { "C# Classes Tutorial", "https://www.youtube.com/embed/ZqDtPFrUonQ?autohide=1&showinfo=0&modestbranding=1" },
                { "C# Constructors Tutorial", "https://www.youtube.com/embed/q7aWkjH3UUI?autohide=1&showinfo=0&modestbranding=1" },
                { "C# Methods Tutorial", "https://www.youtube.com/embed/56bbjE4assU?autohide=1&showinfo=0&modestbranding=1" }

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
           CssharpQuiz csharpQuiz = new CssharpQuiz(userName, userID);
            csharpQuiz.Show();
            this.Hide();
        }
    }
}
