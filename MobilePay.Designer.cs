namespace InterractiveLearningPlatform
{
    partial class MobilePay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobilePay));
            this.pin_tb = new System.Windows.Forms.TextBox();
            this.mobile_num_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_label = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.cmplte_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pin_tb
            // 
            this.pin_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_tb.Location = new System.Drawing.Point(217, 308);
            this.pin_tb.Margin = new System.Windows.Forms.Padding(6);
            this.pin_tb.Name = "pin_tb";
            this.pin_tb.Size = new System.Drawing.Size(388, 31);
            this.pin_tb.TabIndex = 19;
            // 
            // mobile_num_tb
            // 
            this.mobile_num_tb.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_num_tb.Location = new System.Drawing.Point(217, 231);
            this.mobile_num_tb.Margin = new System.Windows.Forms.Padding(6);
            this.mobile_num_tb.Name = "mobile_num_tb";
            this.mobile_num_tb.Size = new System.Drawing.Size(388, 31);
            this.mobile_num_tb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "MOBILE NUMBER:";
            // 
            // pay_label
            // 
            this.pay_label.AutoSize = true;
            this.pay_label.BackColor = System.Drawing.Color.AliceBlue;
            this.pay_label.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_label.Location = new System.Drawing.Point(216, 162);
            this.pay_label.Name = "pay_label";
            this.pay_label.Size = new System.Drawing.Size(53, 23);
            this.pay_label.TabIndex = 22;
            this.pay_label.Text = "Pay ";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.cancel;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_btn.Location = new System.Drawing.Point(472, 363);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(133, 44);
            this.cancel_btn.TabIndex = 21;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // cmplte_btn
            // 
            this.cmplte_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmplte_btn.FlatAppearance.BorderSize = 0;
            this.cmplte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmplte_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmplte_btn.ForeColor = System.Drawing.Color.White;
            this.cmplte_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.card__1_;
            this.cmplte_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmplte_btn.Location = new System.Drawing.Point(217, 363);
            this.cmplte_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cmplte_btn.Name = "cmplte_btn";
            this.cmplte_btn.Size = new System.Drawing.Size(205, 44);
            this.cmplte_btn.TabIndex = 20;
            this.cmplte_btn.Text = "Complete Pay";
            this.cmplte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmplte_btn.UseVisualStyleBackColor = false;
            this.cmplte_btn.Click += new System.EventHandler(this.cmplte_btn_Click);
            // 
            // MobilePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 600);
            this.Controls.Add(this.pay_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.cmplte_btn);
            this.Controls.Add(this.pin_tb);
            this.Controls.Add(this.mobile_num_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MobilePay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobilePay";
            this.Load += new System.EventHandler(this.MobilePay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button cmplte_btn;
        private System.Windows.Forms.TextBox pin_tb;
        private System.Windows.Forms.TextBox mobile_num_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pay_label;
    }
}