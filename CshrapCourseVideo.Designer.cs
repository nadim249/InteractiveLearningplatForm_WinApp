namespace InterractiveLearningPlatform
{
    partial class CshrapCourseVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CshrapCourseVideo));
            this.labelCourseName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstVideoList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.enr_back_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCourseName.Location = new System.Drawing.Point(25, 21);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(431, 33);
            this.labelCourseName.TabIndex = 4;
            this.labelCourseName.Text = "Object-Oriented Programming in C#";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.labelCourseName);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 76);
            this.panel2.TabIndex = 63;
            // 
            // lstVideoList
            // 
            this.lstVideoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lstVideoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVideoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstVideoList.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideoList.ForeColor = System.Drawing.Color.Black;
            this.lstVideoList.FormattingEnabled = true;
            this.lstVideoList.ItemHeight = 22;
            this.lstVideoList.Location = new System.Drawing.Point(0, 0);
            this.lstVideoList.Margin = new System.Windows.Forms.Padding(20);
            this.lstVideoList.Name = "lstVideoList";
            this.lstVideoList.Size = new System.Drawing.Size(371, 354);
            this.lstVideoList.TabIndex = 5;
            this.lstVideoList.SelectedIndexChanged += new System.EventHandler(this.lstVideoList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Image = global::InterractiveLearningPlatform.Properties.Resources.ideas;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(44, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 62;
            this.button1.Text = "Start Quiz";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.lstVideoList);
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 590);
            this.panel3.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.webView2);
            this.panel1.Location = new System.Drawing.Point(391, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 448);
            this.panel1.TabIndex = 65;
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(19, 14);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(529, 405);
            this.webView2.TabIndex = 56;
            this.webView2.ZoomFactor = 1D;
            // 
            // enr_back_btn
            // 
            this.enr_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.enr_back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enr_back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enr_back_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enr_back_btn.ForeColor = System.Drawing.Color.GhostWhite;
            this.enr_back_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.back_button;
            this.enr_back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enr_back_btn.Location = new System.Drawing.Point(198, 497);
            this.enr_back_btn.Name = "enr_back_btn";
            this.enr_back_btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.enr_back_btn.Size = new System.Drawing.Size(146, 41);
            this.enr_back_btn.TabIndex = 61;
            this.enr_back_btn.Text = "Back";
            this.enr_back_btn.UseVisualStyleBackColor = false;
            this.enr_back_btn.Click += new System.EventHandler(this.enr_back_btn_Click);
            // 
            // CshrapCourseVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enr_back_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CshrapCourseVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CshrapCourseVideo";
            this.Load += new System.EventHandler(this.CshrapCourseVideo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstVideoList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button enr_back_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}