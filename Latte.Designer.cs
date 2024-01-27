namespace Coffee_Shop_Kiosk
{
    partial class Latte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Latte));
            la_hot = new System.Windows.Forms.RadioButton();
            la_cold = new System.Windows.Forms.RadioButton();
            la_size = new System.Windows.Forms.ComboBox();
            la_cancel = new System.Windows.Forms.Button();
            la_yes = new System.Windows.Forms.Button();
            la_amount = new System.Windows.Forms.NumericUpDown();
            la_total_value = new System.Windows.Forms.Label();
            la_total = new System.Windows.Forms.Label();
            la_option = new System.Windows.Forms.GroupBox();
            la_option3 = new System.Windows.Forms.RadioButton();
            la_option2 = new System.Windows.Forms.RadioButton();
            la_option1 = new System.Windows.Forms.RadioButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)la_amount).BeginInit();
            la_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // la_hot
            // 
            la_hot.Appearance = System.Windows.Forms.Appearance.Button;
            la_hot.AutoSize = true;
            la_hot.BackColor = System.Drawing.Color.White;
            la_hot.FlatAppearance.BorderSize = 0;
            la_hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_hot.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_hot.Location = new System.Drawing.Point(250, 115);
            la_hot.Margin = new System.Windows.Forms.Padding(4);
            la_hot.Name = "la_hot";
            la_hot.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            la_hot.Size = new System.Drawing.Size(153, 39);
            la_hot.TabIndex = 1;
            la_hot.TabStop = true;
            la_hot.Text = "핫(HOT)";
            la_hot.UseVisualStyleBackColor = false;
            la_hot.CheckedChanged += la_hot_CheckedChanged;
            // 
            // la_cold
            // 
            la_cold.Appearance = System.Windows.Forms.Appearance.Button;
            la_cold.AutoSize = true;
            la_cold.BackColor = System.Drawing.Color.White;
            la_cold.FlatAppearance.BorderSize = 0;
            la_cold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_cold.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_cold.Location = new System.Drawing.Point(250, 160);
            la_cold.Margin = new System.Windows.Forms.Padding(4);
            la_cold.Name = "la_cold";
            la_cold.Size = new System.Drawing.Size(158, 39);
            la_cold.TabIndex = 0;
            la_cold.TabStop = true;
            la_cold.Text = "아이스(ICED)";
            la_cold.UseVisualStyleBackColor = false;
            la_cold.CheckedChanged += la_cold_CheckedChanged;
            // 
            // la_size
            // 
            la_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_size.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_size.FormattingEnabled = true;
            la_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            la_size.Location = new System.Drawing.Point(228, 213);
            la_size.Margin = new System.Windows.Forms.Padding(4);
            la_size.Name = "la_size";
            la_size.Size = new System.Drawing.Size(197, 35);
            la_size.TabIndex = 6;
            la_size.Text = "사이즈를 고르세요.";
            la_size.SelectedIndexChanged += la_size_SelectedIndexChanged;
            // 
            // la_cancel
            // 
            la_cancel.BackColor = System.Drawing.Color.White;
            la_cancel.FlatAppearance.BorderSize = 0;
            la_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_cancel.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_cancel.Location = new System.Drawing.Point(253, 522);
            la_cancel.Margin = new System.Windows.Forms.Padding(4);
            la_cancel.Name = "la_cancel";
            la_cancel.Size = new System.Drawing.Size(131, 61);
            la_cancel.TabIndex = 12;
            la_cancel.Text = "취소하기";
            la_cancel.UseVisualStyleBackColor = false;
            la_cancel.Click += la_cancel_Click;
            // 
            // la_yes
            // 
            la_yes.BackColor = System.Drawing.Color.White;
            la_yes.FlatAppearance.BorderSize = 0;
            la_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_yes.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_yes.Location = new System.Drawing.Point(73, 522);
            la_yes.Margin = new System.Windows.Forms.Padding(4);
            la_yes.Name = "la_yes";
            la_yes.Size = new System.Drawing.Size(131, 61);
            la_yes.TabIndex = 13;
            la_yes.Text = "주문하기";
            la_yes.UseVisualStyleBackColor = false;
            la_yes.Click += la_yes_Click;
            // 
            // la_amount
            // 
            la_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            la_amount.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_amount.Location = new System.Drawing.Point(228, 257);
            la_amount.Margin = new System.Windows.Forms.Padding(4);
            la_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            la_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            la_amount.Name = "la_amount";
            la_amount.Size = new System.Drawing.Size(198, 31);
            la_amount.TabIndex = 11;
            la_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            la_amount.ValueChanged += la_amount_ValueChanged;
            // 
            // la_total_value
            // 
            la_total_value.AutoSize = true;
            la_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            la_total_value.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            la_total_value.Location = new System.Drawing.Point(109, 19);
            la_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            la_total_value.Name = "la_total_value";
            la_total_value.Size = new System.Drawing.Size(24, 29);
            la_total_value.TabIndex = 9;
            la_total_value.Text = "-";
            // 
            // la_total
            // 
            la_total.AutoSize = true;
            la_total.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_total.Location = new System.Drawing.Point(18, 21);
            la_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            la_total.Name = "la_total";
            la_total.Size = new System.Drawing.Size(89, 29);
            la_total.TabIndex = 10;
            la_total.Text = "총 가격:";
            // 
            // la_option
            // 
            la_option.Controls.Add(la_option3);
            la_option.Controls.Add(la_option2);
            la_option.Controls.Add(la_option1);
            la_option.Location = new System.Drawing.Point(21, 311);
            la_option.Margin = new System.Windows.Forms.Padding(4);
            la_option.Name = "la_option";
            la_option.Padding = new System.Windows.Forms.Padding(4);
            la_option.Size = new System.Drawing.Size(405, 83);
            la_option.TabIndex = 8;
            la_option.TabStop = false;
            // 
            // la_option3
            // 
            la_option3.Appearance = System.Windows.Forms.Appearance.Button;
            la_option3.AutoSize = true;
            la_option3.BackColor = System.Drawing.Color.White;
            la_option3.FlatAppearance.BorderSize = 0;
            la_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_option3.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_option3.Location = new System.Drawing.Point(281, 24);
            la_option3.Margin = new System.Windows.Forms.Padding(4);
            la_option3.Name = "la_option3";
            la_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            la_option3.Size = new System.Drawing.Size(104, 47);
            la_option3.TabIndex = 2;
            la_option3.TabStop = true;
            la_option3.Text = "텀블러";
            la_option3.UseVisualStyleBackColor = false;
            la_option3.CheckedChanged += la_option3_CheckedChanged;
            // 
            // la_option2
            // 
            la_option2.Appearance = System.Windows.Forms.Appearance.Button;
            la_option2.AutoSize = true;
            la_option2.BackColor = System.Drawing.Color.White;
            la_option2.FlatAppearance.BorderSize = 0;
            la_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_option2.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_option2.Location = new System.Drawing.Point(153, 24);
            la_option2.Margin = new System.Windows.Forms.Padding(4);
            la_option2.Name = "la_option2";
            la_option2.Padding = new System.Windows.Forms.Padding(4);
            la_option2.Size = new System.Drawing.Size(115, 47);
            la_option2.TabIndex = 1;
            la_option2.TabStop = true;
            la_option2.Text = "매장용컵";
            la_option2.UseVisualStyleBackColor = false;
            la_option2.CheckedChanged += la_option2_CheckedChanged;
            // 
            // la_option1
            // 
            la_option1.Appearance = System.Windows.Forms.Appearance.Button;
            la_option1.AutoSize = true;
            la_option1.BackColor = System.Drawing.Color.White;
            la_option1.FlatAppearance.BorderSize = 0;
            la_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            la_option1.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_option1.Location = new System.Drawing.Point(23, 24);
            la_option1.Margin = new System.Windows.Forms.Padding(4);
            la_option1.Name = "la_option1";
            la_option1.Padding = new System.Windows.Forms.Padding(4);
            la_option1.Size = new System.Drawing.Size(115, 47);
            la_option1.TabIndex = 0;
            la_option1.TabStop = true;
            la_option1.Text = "일회용기";
            la_option1.UseVisualStyleBackColor = false;
            la_option1.CheckedChanged += la_option1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(21, 107);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(183, 169);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Pretendard SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(21, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 33);
            label1.TabIndex = 9;
            label1.Text = "카페라떼";
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(la_total);
            panel2.Controls.Add(la_total_value);
            panel2.Location = new System.Drawing.Point(21, 418);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(404, 66);
            panel2.TabIndex = 23;
            // 
            // Latte
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 635);
            Controls.Add(panel2);
            Controls.Add(la_hot);
            Controls.Add(la_cold);
            Controls.Add(la_cancel);
            Controls.Add(la_yes);
            Controls.Add(la_size);
            Controls.Add(la_option);
            Controls.Add(panel1);
            Controls.Add(la_amount);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Latte";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Latte";
            ((System.ComponentModel.ISupportInitialize)la_amount).EndInit();
            la_option.ResumeLayout(false);
            la_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton la_hot;
        private System.Windows.Forms.RadioButton la_cold;
        internal System.Windows.Forms.ComboBox la_size;
        private System.Windows.Forms.Button la_cancel;
        private System.Windows.Forms.Button la_yes;
        private System.Windows.Forms.NumericUpDown la_amount;
        private System.Windows.Forms.Label la_total_value;
        private System.Windows.Forms.Label la_total;
        private System.Windows.Forms.GroupBox la_option;
        private System.Windows.Forms.RadioButton la_option3;
        private System.Windows.Forms.RadioButton la_option2;
        private System.Windows.Forms.RadioButton la_option1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}