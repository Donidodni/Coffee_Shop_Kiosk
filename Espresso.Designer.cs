namespace Coffee_Shop_Kiosk
{
    partial class Espresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Espresso));
            es_notice1 = new System.Windows.Forms.Label();
            es_notice = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            es_cancel = new System.Windows.Forms.Button();
            es_size = new System.Windows.Forms.ComboBox();
            es_yes = new System.Windows.Forms.Button();
            es_option = new System.Windows.Forms.GroupBox();
            es_option3 = new System.Windows.Forms.RadioButton();
            es_option2 = new System.Windows.Forms.RadioButton();
            es_option1 = new System.Windows.Forms.RadioButton();
            es_amount = new System.Windows.Forms.NumericUpDown();
            es_total = new System.Windows.Forms.Label();
            es_total_value = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            es_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)es_amount).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // es_notice1
            // 
            es_notice1.AutoSize = true;
            es_notice1.Font = new System.Drawing.Font("Pretendard SemiBold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_notice1.Location = new System.Drawing.Point(9, 49);
            es_notice1.Margin = new System.Windows.Forms.Padding(0);
            es_notice1.Name = "es_notice1";
            es_notice1.Size = new System.Drawing.Size(185, 23);
            es_notice1.TabIndex = 0;
            es_notice1.Text = "핫(HOT)이 기본입니다.";
            // 
            // es_notice
            // 
            es_notice.AutoSize = true;
            es_notice.Font = new System.Drawing.Font("Pretendard SemiBold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_notice.Location = new System.Drawing.Point(46, 24);
            es_notice.Name = "es_notice";
            es_notice.Size = new System.Drawing.Size(111, 23);
            es_notice.TabIndex = 0;
            es_notice.Text = "에스프레소는 ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(21, 115);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(183, 169);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // es_cancel
            // 
            es_cancel.BackColor = System.Drawing.Color.White;
            es_cancel.FlatAppearance.BorderSize = 0;
            es_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            es_cancel.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_cancel.Location = new System.Drawing.Point(253, 522);
            es_cancel.Margin = new System.Windows.Forms.Padding(4);
            es_cancel.Name = "es_cancel";
            es_cancel.Size = new System.Drawing.Size(131, 61);
            es_cancel.TabIndex = 12;
            es_cancel.Text = "취소하기";
            es_cancel.UseVisualStyleBackColor = false;
            es_cancel.Click += es_cancel_Click;
            // 
            // es_size
            // 
            es_size.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_size.FormattingEnabled = true;
            es_size.Items.AddRange(new object[] { "원샷(기본)", "더블샷", "트리플샷" });
            es_size.Location = new System.Drawing.Point(228, 213);
            es_size.Margin = new System.Windows.Forms.Padding(4);
            es_size.Name = "es_size";
            es_size.Size = new System.Drawing.Size(197, 35);
            es_size.TabIndex = 6;
            es_size.Text = "사이즈를 고르세요.";
            es_size.SelectedIndexChanged += es_size_SelectedIndexChanged;
            // 
            // es_yes
            // 
            es_yes.BackColor = System.Drawing.Color.White;
            es_yes.FlatAppearance.BorderSize = 0;
            es_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            es_yes.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_yes.Location = new System.Drawing.Point(73, 522);
            es_yes.Margin = new System.Windows.Forms.Padding(4);
            es_yes.Name = "es_yes";
            es_yes.Size = new System.Drawing.Size(131, 61);
            es_yes.TabIndex = 13;
            es_yes.Text = "주문하기";
            es_yes.UseVisualStyleBackColor = false;
            es_yes.Click += es_yes_Click;
            // 
            // es_option
            // 
            es_option.Controls.Add(es_option3);
            es_option.Controls.Add(es_option2);
            es_option.Controls.Add(es_option1);
            es_option.Location = new System.Drawing.Point(21, 311);
            es_option.Margin = new System.Windows.Forms.Padding(4);
            es_option.Name = "es_option";
            es_option.Padding = new System.Windows.Forms.Padding(4);
            es_option.Size = new System.Drawing.Size(405, 83);
            es_option.TabIndex = 8;
            es_option.TabStop = false;
            // 
            // es_option3
            // 
            es_option3.Appearance = System.Windows.Forms.Appearance.Button;
            es_option3.AutoSize = true;
            es_option3.BackColor = System.Drawing.Color.White;
            es_option3.FlatAppearance.BorderSize = 0;
            es_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            es_option3.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_option3.Location = new System.Drawing.Point(281, 24);
            es_option3.Margin = new System.Windows.Forms.Padding(4);
            es_option3.Name = "es_option3";
            es_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            es_option3.Size = new System.Drawing.Size(104, 47);
            es_option3.TabIndex = 2;
            es_option3.TabStop = true;
            es_option3.Text = "텀블러";
            es_option3.UseVisualStyleBackColor = false;
            es_option3.CheckedChanged += es_option3_CheckedChanged;
            // 
            // es_option2
            // 
            es_option2.Appearance = System.Windows.Forms.Appearance.Button;
            es_option2.AutoSize = true;
            es_option2.BackColor = System.Drawing.Color.White;
            es_option2.FlatAppearance.BorderSize = 0;
            es_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            es_option2.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_option2.Location = new System.Drawing.Point(153, 24);
            es_option2.Margin = new System.Windows.Forms.Padding(4);
            es_option2.Name = "es_option2";
            es_option2.Padding = new System.Windows.Forms.Padding(4);
            es_option2.Size = new System.Drawing.Size(115, 47);
            es_option2.TabIndex = 1;
            es_option2.TabStop = true;
            es_option2.Text = "매장용컵";
            es_option2.UseVisualStyleBackColor = false;
            es_option2.CheckedChanged += es_option2_CheckedChanged;
            // 
            // es_option1
            // 
            es_option1.Appearance = System.Windows.Forms.Appearance.Button;
            es_option1.AutoSize = true;
            es_option1.BackColor = System.Drawing.Color.White;
            es_option1.FlatAppearance.BorderSize = 0;
            es_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            es_option1.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_option1.Location = new System.Drawing.Point(24, 25);
            es_option1.Margin = new System.Windows.Forms.Padding(4);
            es_option1.Name = "es_option1";
            es_option1.Padding = new System.Windows.Forms.Padding(4);
            es_option1.Size = new System.Drawing.Size(115, 47);
            es_option1.TabIndex = 0;
            es_option1.TabStop = true;
            es_option1.Text = "일회용기";
            es_option1.UseVisualStyleBackColor = false;
            es_option1.CheckedChanged += es_option1_CheckedChanged;
            // 
            // es_amount
            // 
            es_amount.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_amount.Location = new System.Drawing.Point(228, 256);
            es_amount.Margin = new System.Windows.Forms.Padding(4);
            es_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            es_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            es_amount.Name = "es_amount";
            es_amount.Size = new System.Drawing.Size(198, 35);
            es_amount.TabIndex = 11;
            es_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            es_amount.ValueChanged += es_amount_ValueChanged;
            // 
            // es_total
            // 
            es_total.AutoSize = true;
            es_total.BackColor = System.Drawing.Color.Transparent;
            es_total.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_total.Location = new System.Drawing.Point(15, 22);
            es_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            es_total.Name = "es_total";
            es_total.Size = new System.Drawing.Size(89, 29);
            es_total.TabIndex = 10;
            es_total.Text = "총 가격:";
            // 
            // es_total_value
            // 
            es_total_value.AutoSize = true;
            es_total_value.BackColor = System.Drawing.Color.Transparent;
            es_total_value.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            es_total_value.Location = new System.Drawing.Point(110, 22);
            es_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            es_total_value.Name = "es_total_value";
            es_total_value.Size = new System.Drawing.Size(24, 29);
            es_total_value.TabIndex = 9;
            es_total_value.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(476, 64);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Pretendard SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(21, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 33);
            label1.TabIndex = 9;
            label1.Text = "에스프레소";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(es_notice);
            panel2.Controls.Add(es_notice1);
            panel2.Location = new System.Drawing.Point(228, 116);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(198, 90);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(es_total);
            panel3.Controls.Add(es_total_value);
            panel3.Location = new System.Drawing.Point(21, 415);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(404, 66);
            panel3.TabIndex = 24;
            // 
            // Espresso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 635);
            Controls.Add(panel3);
            Controls.Add(es_cancel);
            Controls.Add(es_yes);
            Controls.Add(panel2);
            Controls.Add(es_size);
            Controls.Add(es_option);
            Controls.Add(panel1);
            Controls.Add(es_amount);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Espresso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Espresso";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            es_option.ResumeLayout(false);
            es_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)es_amount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button es_cancel;
        internal System.Windows.Forms.ComboBox es_size;
        private System.Windows.Forms.Button es_yes;
        private System.Windows.Forms.GroupBox es_option;
        private System.Windows.Forms.RadioButton es_option3;
        private System.Windows.Forms.RadioButton es_option2;
        private System.Windows.Forms.RadioButton es_option1;
        private System.Windows.Forms.NumericUpDown es_amount;
        private System.Windows.Forms.Label es_total;
        private System.Windows.Forms.Label es_total_value;
        private System.Windows.Forms.Label es_notice1;
        private System.Windows.Forms.Label es_notice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}