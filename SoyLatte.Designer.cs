namespace Coffee_Shop_Kiosk
{
    partial class SoyLatte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoyLatte));
            soy_hot = new System.Windows.Forms.RadioButton();
            soy_cold = new System.Windows.Forms.RadioButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            soy_cancel = new System.Windows.Forms.Button();
            soy_size = new System.Windows.Forms.ComboBox();
            soy_yes = new System.Windows.Forms.Button();
            soy_option = new System.Windows.Forms.GroupBox();
            soy_option3 = new System.Windows.Forms.RadioButton();
            soy_option2 = new System.Windows.Forms.RadioButton();
            soy_option1 = new System.Windows.Forms.RadioButton();
            soy_amount = new System.Windows.Forms.NumericUpDown();
            soy_total = new System.Windows.Forms.Label();
            soy_total_value = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            soy_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soy_amount).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // soy_hot
            // 
            soy_hot.Appearance = System.Windows.Forms.Appearance.Button;
            soy_hot.AutoSize = true;
            soy_hot.BackColor = System.Drawing.Color.White;
            soy_hot.FlatAppearance.BorderSize = 0;
            soy_hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_hot.Location = new System.Drawing.Point(194, 79);
            soy_hot.Name = "soy_hot";
            soy_hot.Padding = new System.Windows.Forms.Padding(16, 0, 19, 0);
            soy_hot.Size = new System.Drawing.Size(128, 34);
            soy_hot.TabIndex = 1;
            soy_hot.TabStop = true;
            soy_hot.Text = "핫(HOT)";
            soy_hot.UseVisualStyleBackColor = false;
            soy_hot.CheckedChanged += soy_hot_CheckedChanged;
            // 
            // soy_cold
            // 
            soy_cold.Appearance = System.Windows.Forms.Appearance.Button;
            soy_cold.AutoSize = true;
            soy_cold.BackColor = System.Drawing.Color.White;
            soy_cold.FlatAppearance.BorderSize = 0;
            soy_cold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_cold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_cold.Location = new System.Drawing.Point(194, 120);
            soy_cold.Name = "soy_cold";
            soy_cold.Size = new System.Drawing.Size(126, 34);
            soy_cold.TabIndex = 0;
            soy_cold.TabStop = true;
            soy_cold.Text = "아이스(ICED)";
            soy_cold.UseVisualStyleBackColor = false;
            soy_cold.CheckedChanged += soy_cold_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(19, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(142, 127);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // soy_cancel
            // 
            soy_cancel.BackColor = System.Drawing.Color.White;
            soy_cancel.FlatAppearance.BorderSize = 0;
            soy_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_cancel.Location = new System.Drawing.Point(197, 392);
            soy_cancel.Name = "soy_cancel";
            soy_cancel.Size = new System.Drawing.Size(102, 46);
            soy_cancel.TabIndex = 12;
            soy_cancel.Text = "취소하기";
            soy_cancel.UseVisualStyleBackColor = false;
            soy_cancel.Click += soy_cancel_Click;
            // 
            // soy_size
            // 
            soy_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_size.FormattingEnabled = true;
            soy_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            soy_size.Location = new System.Drawing.Point(178, 160);
            soy_size.Name = "soy_size";
            soy_size.Size = new System.Drawing.Size(154, 32);
            soy_size.TabIndex = 6;
            soy_size.Text = "사이즈를 선택하세요.";
            soy_size.SelectedIndexChanged += soy_size_SelectedIndexChanged;
            // 
            // soy_yes
            // 
            soy_yes.BackColor = System.Drawing.Color.White;
            soy_yes.FlatAppearance.BorderSize = 0;
            soy_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_yes.Location = new System.Drawing.Point(57, 392);
            soy_yes.Name = "soy_yes";
            soy_yes.Size = new System.Drawing.Size(102, 46);
            soy_yes.TabIndex = 13;
            soy_yes.Text = "주문하기";
            soy_yes.UseVisualStyleBackColor = false;
            soy_yes.Click += soy_yes_Click;
            // 
            // soy_option
            // 
            soy_option.Controls.Add(soy_option3);
            soy_option.Controls.Add(soy_option2);
            soy_option.Controls.Add(soy_option1);
            soy_option.Location = new System.Drawing.Point(17, 233);
            soy_option.Name = "soy_option";
            soy_option.Size = new System.Drawing.Size(315, 62);
            soy_option.TabIndex = 8;
            soy_option.TabStop = false;
            // 
            // soy_option3
            // 
            soy_option3.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option3.AutoSize = true;
            soy_option3.BackColor = System.Drawing.Color.White;
            soy_option3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            soy_option3.Checked = true;
            soy_option3.FlatAppearance.BorderSize = 0;
            soy_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_option3.Location = new System.Drawing.Point(219, 18);
            soy_option3.Name = "soy_option3";
            soy_option3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            soy_option3.Size = new System.Drawing.Size(79, 40);
            soy_option3.TabIndex = 2;
            soy_option3.TabStop = true;
            soy_option3.Text = "텀블러";
            soy_option3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            soy_option3.UseVisualStyleBackColor = false;
            soy_option3.CheckedChanged += soy_option3_CheckedChanged;
            // 
            // soy_option2
            // 
            soy_option2.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option2.AutoSize = true;
            soy_option2.BackColor = System.Drawing.Color.White;
            soy_option2.FlatAppearance.BorderSize = 0;
            soy_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_option2.Location = new System.Drawing.Point(119, 18);
            soy_option2.Name = "soy_option2";
            soy_option2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            soy_option2.Size = new System.Drawing.Size(86, 40);
            soy_option2.TabIndex = 1;
            soy_option2.Text = "매장용컵";
            soy_option2.UseVisualStyleBackColor = false;
            soy_option2.CheckedChanged += soy_option2_CheckedChanged;
            // 
            // soy_option1
            // 
            soy_option1.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option1.AutoSize = true;
            soy_option1.BackColor = System.Drawing.Color.White;
            soy_option1.FlatAppearance.BorderSize = 0;
            soy_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soy_option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_option1.Location = new System.Drawing.Point(18, 18);
            soy_option1.Name = "soy_option1";
            soy_option1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            soy_option1.Size = new System.Drawing.Size(86, 40);
            soy_option1.TabIndex = 0;
            soy_option1.Text = "일회용기";
            soy_option1.UseVisualStyleBackColor = false;
            soy_option1.CheckedChanged += soy_option1_CheckedChanged;
            // 
            // soy_amount
            // 
            soy_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            soy_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_amount.Location = new System.Drawing.Point(178, 193);
            soy_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            soy_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soy_amount.Name = "soy_amount";
            soy_amount.Size = new System.Drawing.Size(154, 25);
            soy_amount.TabIndex = 11;
            soy_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soy_amount.ValueChanged += soy_amount_ValueChanged;
            // 
            // soy_total
            // 
            soy_total.AutoSize = true;
            soy_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_total.Location = new System.Drawing.Point(14, 16);
            soy_total.Name = "soy_total";
            soy_total.Size = new System.Drawing.Size(67, 24);
            soy_total.TabIndex = 10;
            soy_total.Text = "총 가격:";
            // 
            // soy_total_value
            // 
            soy_total_value.AutoSize = true;
            soy_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            soy_total_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            soy_total_value.Location = new System.Drawing.Point(85, 14);
            soy_total_value.Name = "soy_total_value";
            soy_total_value.Size = new System.Drawing.Size(17, 24);
            soy_total_value.TabIndex = 9;
            soy_total_value.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(16, 14);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 26);
            label1.TabIndex = 9;
            label1.Text = "돌체라떼";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(370, 48);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(soy_total);
            panel2.Controls.Add(soy_total_value);
            panel2.Location = new System.Drawing.Point(17, 314);
            panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(314, 50);
            panel2.TabIndex = 24;
            // 
            // SoyLatte
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(370, 476);
            Controls.Add(panel2);
            Controls.Add(soy_cancel);
            Controls.Add(soy_hot);
            Controls.Add(soy_yes);
            Controls.Add(soy_size);
            Controls.Add(soy_option);
            Controls.Add(soy_cold);
            Controls.Add(soy_amount);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "SoyLatte";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SoyLatte";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            soy_option.ResumeLayout(false);
            soy_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soy_amount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton soy_hot;
        private System.Windows.Forms.RadioButton soy_cold;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button soy_cancel;
        internal System.Windows.Forms.ComboBox soy_size;
        private System.Windows.Forms.Button soy_yes;
        private System.Windows.Forms.GroupBox soy_option;
        private System.Windows.Forms.RadioButton soy_option3;
        private System.Windows.Forms.RadioButton soy_option2;
        private System.Windows.Forms.RadioButton soy_option1;
        private System.Windows.Forms.NumericUpDown soy_amount;
        private System.Windows.Forms.Label soy_total;
        private System.Windows.Forms.Label soy_total_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}