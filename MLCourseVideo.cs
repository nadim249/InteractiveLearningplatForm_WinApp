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
    public partial class MLCourseVideo : Form
    {
        private string userName;
        private int userID;
        public MLCourseVideo(string name,int id)
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

        private async void MLCourseVideo_Load(object sender, EventArgs e)
        {
         
            await webView2.EnsureCoreWebView2Async(null); 
        }

        private void LoadCourseData()
        {

           
            lstVideoList.Items.Add("Machine Learning Introduction");
            lstVideoList.Items.Add("Natural language processing (NLP)");
            lstVideoList.Items.Add("ALL IN ONE ML");
            lstVideoList.Items.Add("Perceptron & Generalized Linear Model");
            lstVideoList.Items.Add("GDA & Naive Bayes");
        }

        private void lstVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideoList.SelectedIndex == -1)
                return;

            string selectedVideo = lstVideoList.SelectedItem.ToString();

    
            var videoUrls = new Dictionary<string, string>
            {
                { "Machine Learning Introduction", "https://www.youtube.com/embed/i_LwzRVP7bg?autohide=1&showinfo=0&modestbranding=1" },
                { "Natural language processing (NLP)", "https://www.youtube.com/embed/ENLEjGozrio?autohide=1&showinfo=0&modestbranding=1" },
                { "ALL IN ONE ML", "https://www.youtube.com/embed/GwIo3gDZCVQ?autohide=1&showinfo=0&modestbranding=1" },
                { "Perceptron & Generalized Linear Model", "https://www.youtube.com/embed/ENLEjGozrio?autohide=1&showinfo=0&modestbranding=1" },
                { "GDA & Naive Bayes", "https://www.youtube.com/embed/i_LwzRVP7bg?autohide=1&showinfo=0&modestbranding=1" }

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
            MLQuiz mlQuiz = new MLQuiz(userName, userID);
            mlQuiz.Show();
            this.Hide();
        }
    }
}
