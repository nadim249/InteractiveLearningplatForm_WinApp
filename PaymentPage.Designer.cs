namespace InterractiveLearningPlatform
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.card_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mobile_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.card_btn);
            this.panel4.Location = new System.Drawing.Point(529, 146);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(280, 323);
            this.panel4.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.bankcardcover;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 170);
            this.panel2.TabIndex = 40;
            // 
            // card_btn
            // 
            this.card_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.card_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.card_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_btn.ForeColor = System.Drawing.Color.White;
            this.card_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.card__1_;
            this.card_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.card_btn.Location = new System.Drawing.Point(35, 240);
            this.card_btn.Name = "card_btn";
            this.card_btn.Size = new System.Drawing.Size(212, 54);
            this.card_btn.TabIndex = 28;
            this.card_btn.Text = "Card Pay";
            this.card_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.card_btn.UseVisualStyleBackColor = false;
            this.card_btn.Click += new System.EventHandler(this.card_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(390, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Payment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.mobile_btn);
            this.panel3.Location = new System.Drawing.Point(172, 146);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(280, 323);
            this.panel3.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.BackgroundImage = global::InterractiveLearningPlatform.Properties.Resources.credit_card;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 170);
            this.panel1.TabIndex = 39;
            // 
            // mobile_btn
            // 
            this.mobile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mobile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mobile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_btn.ForeColor = System.Drawing.Color.White;
            this.mobile_btn.Image = global::InterractiveLearningPlatform.Properties.Resources.accept;
            this.mobile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mobile_btn.Location = new System.Drawing.Point(44, 240);
            this.mobile_btn.Name = "mobile_btn";
            this.mobile_btn.Size = new System.Drawing.Size(203, 54);
            this.mobile_btn.TabIndex = 27;
            this.mobile_btn.Text = "Mobile Bank";
            this.mobile_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mobile_btn.UseVisualStyleBackColor = false;
            this.mobile_btn.Click += new System.EventHandler(this.mobile_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(983, 54);
            this.panel5.TabIndex = 47;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Snow;
            this.button8.Image = global::InterractiveLearningPlatform.Properties.Resources.back_button;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(406, 557);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(176, 42);
            this.button8.TabIndex = 44;
            this.button8.Text = "Back";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentPage";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button card_btn;
        private System.Windows.Forms.Button mobile_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}