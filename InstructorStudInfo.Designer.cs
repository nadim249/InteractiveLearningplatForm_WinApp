namespace InterractiveLearningPlatform
{
    partial class InstructorStudInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorStudInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.stu_pro_btn = new System.Windows.Forms.Button();
            this.ins_stu_perf_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ins_back_btn = new System.Windows.Forms.Button();
            this.ins_home_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ins_del_btn = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Information";
            // 
            // stu_pro_btn
            // 
            this.stu_pro_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.stu_pro_btn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_pro_btn.ForeColor = System.Drawing.Color.White;
            this.stu_pro_btn.Location = new System.Drawing.Point(706, 31);
            this.stu_pro_btn.Name = "stu_pro_btn";
            this.stu_pro_btn.Size = new System.Drawing.Size(250, 57);
            this.stu_pro_btn.TabIndex = 0;
            this.stu_pro_btn.Text = "Student Proflies";
            this.stu_pro_btn.UseVisualStyleBackColor = false;
            this.stu_pro_btn.Click += new System.EventHandler(this.stu_pro_btn_Click);
            // 
            // ins_stu_perf_btn
            // 
            this.ins_stu_perf_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ins_stu_perf_btn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ins_stu_perf_btn.ForeColor = System.Drawing.Color.White;
            this.ins_stu_perf_btn.Location = new System.Drawing.Point(706, 94);
            this.ins_stu_perf_btn.Name = "ins_stu_perf_btn";
            this.ins_stu_perf_btn.Size = new System.Drawing.Size(250, 61);
            this.ins_stu_perf_btn.TabIndex = 1;
            this.ins_stu_perf_btn.Text = "Student Performamance";
            this.ins_stu_perf_btn.UseVisualStyleBackColor = false;
            this.ins_stu_perf_btn.Click += new System.EventHandler(this.ins_stu_perf_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ins_back_btn);
            this.splitContainer1.Panel1.Controls.Add(this.ins_home_btn);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.stu_pro_btn);
            this.splitContainer1.Panel1.Controls.Add(this.ins_stu_perf_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.school_background_o2wgrgg0za0vovk9;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.ins_del_btn);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssignments);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 661);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 8;
            // 
            // ins_back_btn
            // 
            this.ins_back_btn.BackColor = System.Drawing.Color.Indigo;
            this.ins_back_btn.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.left_removebg_preview;
            this.ins_back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ins_back_btn.Location = new System.Drawing.Point(11, 11);
            this.ins_back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ins_back_btn.Name = "ins_back_btn";
            this.ins_back_btn.Size = new System.Drawing.Size(71, 46);
            this.ins_back_btn.TabIndex = 43;
            this.ins_back_btn.UseVisualStyleBackColor = false;
            this.ins_back_btn.Click += new System.EventHandler(this.ins_back_btn_Click);
            // 
            // ins_home_btn
            // 
            this.ins_home_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ins_home_btn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ins_home_btn.ForeColor = System.Drawing.Color.White;
            this.ins_home_btn.Location = new System.Drawing.Point(421, 43);
            this.ins_home_btn.Name = "ins_home_btn";
            this.ins_home_btn.Size = new System.Drawing.Size(223, 57);
            this.ins_home_btn.TabIndex = 4;
            this.ins_home_btn.Text = "Home";
            this.ins_home_btn.UseVisualStyleBackColor = false;
            this.ins_home_btn.Click += new System.EventHandler(this.ins_home_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterractiveLearningPlatform.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ins_del_btn
            // 
            this.ins_del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.ins_del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ins_del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ins_del_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ins_del_btn.ForeColor = System.Drawing.Color.White;
            this.ins_del_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.delete;
            this.ins_del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ins_del_btn.Location = new System.Drawing.Point(651, 320);
            this.ins_del_btn.Name = "ins_del_btn";
            this.ins_del_btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ins_del_btn.Size = new System.Drawing.Size(172, 43);
            this.ins_del_btn.TabIndex = 44;
            this.ins_del_btn.Text = "Delete";
            this.ins_del_btn.UseVisualStyleBackColor = false;
            this.ins_del_btn.Click += new System.EventHandler(this.ins_del_btn_Click);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.AllowUserToAddRows = false;
            this.dgvAssignments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAssignments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssignments.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvAssignments.Location = new System.Drawing.Point(142, 92);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAssignments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignments.Size = new System.Drawing.Size(681, 222);
            this.dgvAssignments.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Profiles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructorStudInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructorStudInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorStudInfo";
            this.Load += new System.EventHandler(this.InstructorStudInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stu_pro_btn;
        private System.Windows.Forms.Button ins_stu_perf_btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ins_home_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ins_back_btn;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button ins_del_btn;
    }
}