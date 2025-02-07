namespace InterractiveLearningPlatform
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forget_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.email_login_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.pasLogin_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makerdt_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.forget_btn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.email_login_tb);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.pasLogin_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(306, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 375);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(285, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterractiveLearningPlatform.Properties.Resources.projectlogo;
            this.pictureBox1.Location = new System.Drawing.Point(144, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "User :";
            // 
            // forget_btn
            // 
            this.forget_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.forget_btn.FlatAppearance.BorderSize = 0;
            this.forget_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forget_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.forget_btn.Location = new System.Drawing.Point(91, 326);
            this.forget_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forget_btn.Name = "forget_btn";
            this.forget_btn.Size = new System.Drawing.Size(207, 31);
            this.forget_btn.TabIndex = 20;
            this.forget_btn.Text = "Forget Password?";
            this.forget_btn.UseVisualStyleBackColor = false;
            this.forget_btn.Click += new System.EventHandler(this.forget_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Learner",
            "Instructor"});
            this.comboBox1.Location = new System.Drawing.Point(42, 109);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(157)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.add_friend;
            this.signup_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup_btn.Location = new System.Drawing.Point(16, 278);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(166, 44);
            this.signup_btn.TabIndex = 19;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // email_login_tb
            // 
            this.email_login_tb.BackColor = System.Drawing.Color.White;
            this.email_login_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_login_tb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_login_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_login_tb.Location = new System.Drawing.Point(42, 164);
            this.email_login_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_login_tb.Name = "email_login_tb";
            this.email_login_tb.Size = new System.Drawing.Size(300, 27);
            this.email_login_tb.TabIndex = 15;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.user;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_btn.Location = new System.Drawing.Point(188, 278);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(163, 44);
            this.login_btn.TabIndex = 18;
            this.login_btn.Text = "Log In";
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pasLogin_tb
            // 
            this.pasLogin_tb.BackColor = System.Drawing.Color.White;
            this.pasLogin_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pasLogin_tb.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasLogin_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pasLogin_tb.Location = new System.Drawing.Point(42, 218);
            this.pasLogin_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pasLogin_tb.Name = "pasLogin_tb";
            this.pasLogin_tb.Size = new System.Drawing.Size(300, 27);
            this.pasLogin_tb.TabIndex = 17;
            this.pasLogin_tb.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Log In";
            // 
            // makerdt_btn
            // 
            this.makerdt_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.information;
            this.makerdt_btn.Location = new System.Drawing.Point(12, 612);
            this.makerdt_btn.Name = "makerdt_btn";
            this.makerdt_btn.Size = new System.Drawing.Size(48, 37);
            this.makerdt_btn.TabIndex = 24;
            this.makerdt_btn.UseVisualStyleBackColor = true;
            this.makerdt_btn.Click += new System.EventHandler(this.makerdt_btn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.Picture11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.makerdt_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Log In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forget_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox email_login_tb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox pasLogin_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button makerdt_btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}