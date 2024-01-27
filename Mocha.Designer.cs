namespace Coffee_Shop_Kiosk
{
    partial class Mocha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mocha));
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            mo_hot = new System.Windows.Forms.RadioButton();
            mo_cold = new System.Windows.Forms.RadioButton();
            panel2 = new System.Windows.Forms.Panel();
            mo_total = new System.Windows.Forms.Label();
            mo_total_value = new System.Windows.Forms.Label();
            mo_cancel = new System.Windows.Forms.Button();
            mo_yes = new System.Windows.Forms.Button();
            mo_size = new System.Windows.Forms.ComboBox();
            mo_option = new System.Windows.Forms.GroupBox();
            mo_option3 = new System.Windows.Forms.RadioButton();
            mo_option2 = new System.Windows.Forms.RadioButton();
            mo_option1 = new System.Windows.Forms.RadioButton();
            mo_amount = new System.Windows.Forms.NumericUpDown();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mo_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mo_amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            label1.Text = "까페모카";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(476, 64);
            panel1.TabIndex = 24;
            // 
            // mo_hot
            // 
            mo_hot.Appearance = System.Windows.Forms.Appearance.Button;
            mo_hot.AutoSize = true;
            mo_hot.BackColor = System.Drawing.Color.White;
            mo_hot.Checked = true;
            mo_hot.FlatAppearance.BorderSize = 0;
            mo_hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_hot.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_hot.Location = new System.Drawing.Point(250, 115);
            mo_hot.Margin = new System.Windows.Forms.Padding(4);
            mo_hot.Name = "mo_hot";
            mo_hot.Padding = new System.Windows.Forms.Padding(21, 0, 25, 0);
            mo_hot.Size = new System.Drawing.Size(157, 39);
            mo_hot.TabIndex = 26;
            mo_hot.TabStop = true;
            mo_hot.Text = "핫(HOT)";
            mo_hot.UseVisualStyleBackColor = false;
            mo_hot.CheckedChanged += mo_hot_CheckedChanged;
            // 
            // mo_cold
            // 
            mo_cold.Appearance = System.Windows.Forms.Appearance.Button;
            mo_cold.AutoSize = true;
            mo_cold.BackColor = System.Drawing.Color.White;
            mo_cold.FlatAppearance.BorderSize = 0;
            mo_cold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_cold.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_cold.Location = new System.Drawing.Point(250, 160);
            mo_cold.Margin = new System.Windows.Forms.Padding(4);
            mo_cold.Name = "mo_cold";
            mo_cold.Size = new System.Drawing.Size(158, 39);
            mo_cold.TabIndex = 25;
            mo_cold.Text = "아이스(ICED)";
            mo_cold.UseVisualStyleBackColor = false;
            mo_cold.CheckedChanged += mo_cold_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(mo_total);
            panel2.Controls.Add(mo_total_value);
            panel2.Location = new System.Drawing.Point(24, 417);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(404, 66);
            panel2.TabIndex = 33;
            // 
            // mo_total
            // 
            mo_total.AutoSize = true;
            mo_total.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_total.Location = new System.Drawing.Point(18, 21);
            mo_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mo_total.Name = "mo_total";
            mo_total.Size = new System.Drawing.Size(89, 29);
            mo_total.TabIndex = 10;
            mo_total.Text = "총 가격:";
            // 
            // mo_total_value
            // 
            mo_total_value.AutoSize = true;
            mo_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            mo_total_value.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            mo_total_value.Location = new System.Drawing.Point(109, 19);
            mo_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mo_total_value.Name = "mo_total_value";
            mo_total_value.Size = new System.Drawing.Size(24, 29);
            mo_total_value.TabIndex = 9;
            mo_total_value.Text = "-";
            // 
            // mo_cancel
            // 
            mo_cancel.BackColor = System.Drawing.Color.White;
            mo_cancel.FlatAppearance.BorderSize = 0;
            mo_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_cancel.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_cancel.Location = new System.Drawing.Point(256, 521);
            mo_cancel.Margin = new System.Windows.Forms.Padding(4);
            mo_cancel.Name = "mo_cancel";
            mo_cancel.Size = new System.Drawing.Size(131, 61);
            mo_cancel.TabIndex = 30;
            mo_cancel.Text = "취소하기";
            mo_cancel.UseVisualStyleBackColor = false;
            mo_cancel.Click += mo_cancel_Click;
            // 
            // mo_yes
            // 
            mo_yes.BackColor = System.Drawing.Color.White;
            mo_yes.FlatAppearance.BorderSize = 0;
            mo_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_yes.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_yes.Location = new System.Drawing.Point(76, 521);
            mo_yes.Margin = new System.Windows.Forms.Padding(4);
            mo_yes.Name = "mo_yes";
            mo_yes.Size = new System.Drawing.Size(131, 61);
            mo_yes.TabIndex = 31;
            mo_yes.Text = "주문하기";
            mo_yes.UseVisualStyleBackColor = false;
            mo_yes.Click += mo_yes_Click;
            // 
            // mo_size
            // 
            mo_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_size.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_size.FormattingEnabled = true;
            mo_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            mo_size.Location = new System.Drawing.Point(231, 212);
            mo_size.Margin = new System.Windows.Forms.Padding(4);
            mo_size.Name = "mo_size";
            mo_size.Size = new System.Drawing.Size(197, 35);
            mo_size.TabIndex = 27;
            mo_size.Text = "사이즈를 선택하세요.";
            mo_size.SelectedIndexChanged += mo_size_SelectedIndexChanged;
            // 
            // mo_option
            // 
            mo_option.Controls.Add(mo_option3);
            mo_option.Controls.Add(mo_option2);
            mo_option.Controls.Add(mo_option1);
            mo_option.Location = new System.Drawing.Point(24, 310);
            mo_option.Margin = new System.Windows.Forms.Padding(4);
            mo_option.Name = "mo_option";
            mo_option.Padding = new System.Windows.Forms.Padding(4);
            mo_option.Size = new System.Drawing.Size(405, 83);
            mo_option.TabIndex = 28;
            mo_option.TabStop = false;
            // 
            // mo_option3
            // 
            mo_option3.Appearance = System.Windows.Forms.Appearance.Button;
            mo_option3.AutoSize = true;
            mo_option3.BackColor = System.Drawing.Color.White;
            mo_option3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            mo_option3.Checked = true;
            mo_option3.FlatAppearance.BorderSize = 0;
            mo_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_option3.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_option3.Location = new System.Drawing.Point(282, 25);
            mo_option3.Margin = new System.Windows.Forms.Padding(4);
            mo_option3.Name = "mo_option3";
            mo_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            mo_option3.Size = new System.Drawing.Size(104, 47);
            mo_option3.TabIndex = 2;
            mo_option3.TabStop = true;
            mo_option3.Text = "텀블러";
            mo_option3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            mo_option3.UseVisualStyleBackColor = false;
            mo_option3.CheckedChanged += mo_option3_CheckedChanged;
            // 
            // mo_option2
            // 
            mo_option2.Appearance = System.Windows.Forms.Appearance.Button;
            mo_option2.AutoSize = true;
            mo_option2.BackColor = System.Drawing.Color.White;
            mo_option2.FlatAppearance.BorderSize = 0;
            mo_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_option2.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_option2.Location = new System.Drawing.Point(154, 25);
            mo_option2.Margin = new System.Windows.Forms.Padding(4);
            mo_option2.Name = "mo_option2";
            mo_option2.Padding = new System.Windows.Forms.Padding(4);
            mo_option2.Size = new System.Drawing.Size(115, 47);
            mo_option2.TabIndex = 1;
            mo_option2.Text = "매장용컵";
            mo_option2.UseVisualStyleBackColor = false;
            mo_option2.CheckedChanged += mo_option2_CheckedChanged;
            // 
            // mo_option1
            // 
            mo_option1.Appearance = System.Windows.Forms.Appearance.Button;
            mo_option1.AutoSize = true;
            mo_option1.BackColor = System.Drawing.Color.White;
            mo_option1.FlatAppearance.BorderSize = 0;
            mo_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mo_option1.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_option1.Location = new System.Drawing.Point(24, 25);
            mo_option1.Margin = new System.Windows.Forms.Padding(4);
            mo_option1.Name = "mo_option1";
            mo_option1.Padding = new System.Windows.Forms.Padding(4);
            mo_option1.Size = new System.Drawing.Size(115, 47);
            mo_option1.TabIndex = 0;
            mo_option1.Text = "일회용기";
            mo_option1.UseVisualStyleBackColor = false;
            mo_option1.CheckedChanged += mo_option1_CheckedChanged;
            // 
            // mo_amount
            // 
            mo_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            mo_amount.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mo_amount.Location = new System.Drawing.Point(231, 256);
            mo_amount.Margin = new System.Windows.Forms.Padding(4);
            mo_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            mo_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mo_amount.Name = "mo_amount";
            mo_amount.Size = new System.Drawing.Size(198, 31);
            mo_amount.TabIndex = 29;
            mo_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            mo_amount.ValueChanged += mo_amount_ValueChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(24, 106);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(183, 169);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // Mocha
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 635);
            Controls.Add(panel2);
            Controls.Add(mo_cancel);
            Controls.Add(mo_yes);
            Controls.Add(mo_size);
            Controls.Add(mo_option);
            Controls.Add(mo_amount);
            Controls.Add(pictureBox2);
            Controls.Add(mo_hot);
            Controls.Add(mo_cold);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Mocha";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mocha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mo_option.ResumeLayout(false);
            mo_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mo_amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton mo_hot;
        private System.Windows.Forms.RadioButton mo_cold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mo_total;
        private System.Windows.Forms.Label mo_total_value;
        private System.Windows.Forms.Button mo_cancel;
        private System.Windows.Forms.Button mo_yes;
        internal System.Windows.Forms.ComboBox mo_size;
        private System.Windows.Forms.GroupBox mo_option;
        private System.Windows.Forms.RadioButton mo_option3;
        private System.Windows.Forms.RadioButton mo_option2;
        private System.Windows.Forms.RadioButton mo_option1;
        private System.Windows.Forms.NumericUpDown mo_amount;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}