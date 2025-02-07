namespace InterractiveLearningPlatform
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.confrim_pass_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.otp_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backbtn = new System.Windows.Forms.Button();
            this.passcng_btn = new System.Windows.Forms.Button();
            this.usr_avail_chk_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pass_tb
            // 
            this.pass_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.Location = new System.Drawing.Point(602, 369);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass_tb.Multiline = true;
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(310, 30);
            this.pass_tb.TabIndex = 71;
            // 
            // confrim_pass_tb
            // 
            this.confrim_pass_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confrim_pass_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim_pass_tb.Location = new System.Drawing.Point(602, 432);
            this.confrim_pass_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.confrim_pass_tb.Multiline = true;
            this.confrim_pass_tb.Name = "confrim_pass_tb";
            this.confrim_pass_tb.Size = new System.Drawing.Size(310, 30);
            this.confrim_pass_tb.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 58);
            this.panel1.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(173)))));
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Forget Password Page";
            // 
            // email_tb
            // 
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tb.Location = new System.Drawing.Point(604, 114);
            this.email_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.email_tb.Multiline = true;
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(310, 30);
            this.email_tb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label8.Location = new System.Drawing.Point(435, 432);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(434, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 58;
            this.label5.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label10.Location = new System.Drawing.Point(444, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 26);
            this.label10.TabIndex = 60;
            this.label10.Text = "Email:";
            // 
            // otp_tb
            // 
            this.otp_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otp_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otp_tb.Location = new System.Drawing.Point(602, 304);
            this.otp_tb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otp_tb.Multiline = true;
            this.otp_tb.Name = "otp_tb";
            this.otp_tb.Size = new System.Drawing.Size(310, 30);
            this.otp_tb.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(444, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "OTP:";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadingLabel.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.Green;
            this.loadingLabel.Location = new System.Drawing.Point(610, 232);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(96, 19);
            this.loadingLabel.TabIndex = 74;
            this.loadingLabel.Text = "Laoding........";
            this.loadingLabel.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.backbtn.Image = global::InterractiveLearningPlatform.Properties.Resources.back_button;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.Location = new System.Drawing.Point(594, 491);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(131, 43);
            this.backbtn.TabIndex = 73;
            this.backbtn.Text = "Back";
            this.backbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // passcng_btn
            // 
            this.passcng_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(173)))));
            this.passcng_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passcng_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passcng_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcng_btn.ForeColor = System.Drawing.Color.White;
            this.passcng_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.changes;
            this.passcng_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passcng_btn.Location = new System.Drawing.Point(731, 491);
            this.passcng_btn.Name = "passcng_btn";
            this.passcng_btn.Size = new System.Drawing.Size(181, 43);
            this.passcng_btn.TabIndex = 65;
            this.passcng_btn.Text = "Change Password";
            this.passcng_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.passcng_btn.UseVisualStyleBackColor = false;
            this.passcng_btn.Click += new System.EventHandler(this.passcng_btn_Click);
            // 
            // usr_avail_chk_btn
            // 
            this.usr_avail_chk_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(173)))));
            this.usr_avail_chk_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usr_avail_chk_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usr_avail_chk_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_avail_chk_btn.ForeColor = System.Drawing.Color.White;
            this.usr_avail_chk_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.password;
            this.usr_avail_chk_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usr_avail_chk_btn.Location = new System.Drawing.Point(763, 161);
            this.usr_avail_chk_btn.Name = "usr_avail_chk_btn";
            this.usr_avail_chk_btn.Size = new System.Drawing.Size(151, 40);
            this.usr_avail_chk_btn.TabIndex = 65;
            this.usr_avail_chk_btn.Text = "OTP";
            this.usr_avail_chk_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usr_avail_chk_btn.UseVisualStyleBackColor = false;
            this.usr_avail_chk_btn.Click += new System.EventHandler(this.usr_avail_chk_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(89)))), ((int)(((byte)(173)))));
            this.panel2.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.key;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 614);
            this.panel2.TabIndex = 72;
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.confrim_pass_tb);
            this.Controls.Add(this.usr_avail_chk_btn);
            this.Controls.Add(this.passcng_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.otp_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox confrim_pass_tb;
        private System.Windows.Forms.Button passcng_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox otp_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usr_avail_chk_btn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label loadingLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}