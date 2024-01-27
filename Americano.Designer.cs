namespace Coffee_Shop_Kiosk
{
    partial class Americano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Americano));
            am_hot = new System.Windows.Forms.RadioButton();
            am_cold = new System.Windows.Forms.RadioButton();
            am_numeric = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            am_option = new System.Windows.Forms.GroupBox();
            am_option3 = new System.Windows.Forms.RadioButton();
            am_option2 = new System.Windows.Forms.RadioButton();
            am_option1 = new System.Windows.Forms.RadioButton();
            am_total = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            am_yes = new System.Windows.Forms.Button();
            am_cancel = new System.Windows.Forms.Button();
            am_total_value = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            am_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // am_hot
            // 
            am_hot.Appearance = System.Windows.Forms.Appearance.Button;
            am_hot.AutoSize = true;
            am_hot.BackColor = System.Drawing.Color.White;
            am_hot.FlatAppearance.BorderSize = 0;
            am_hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_hot.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_hot.Location = new System.Drawing.Point(250, 115);
            am_hot.Margin = new System.Windows.Forms.Padding(4);
            am_hot.Name = "am_hot";
            am_hot.Padding = new System.Windows.Forms.Padding(21, 0, 25, 0);
            am_hot.Size = new System.Drawing.Size(157, 39);
            am_hot.TabIndex = 1;
            am_hot.TabStop = true;
            am_hot.Text = "핫(HOT)";
            am_hot.UseVisualStyleBackColor = false;
            am_hot.CheckedChanged += am_hot_CheckedChanged;
            // 
            // am_cold
            // 
            am_cold.Appearance = System.Windows.Forms.Appearance.Button;
            am_cold.AutoSize = true;
            am_cold.BackColor = System.Drawing.Color.White;
            am_cold.FlatAppearance.BorderSize = 0;
            am_cold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_cold.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_cold.Location = new System.Drawing.Point(250, 160);
            am_cold.Margin = new System.Windows.Forms.Padding(4);
            am_cold.Name = "am_cold";
            am_cold.Size = new System.Drawing.Size(158, 39);
            am_cold.TabIndex = 0;
            am_cold.TabStop = true;
            am_cold.Text = "아이스(ICED)";
            am_cold.UseVisualStyleBackColor = false;
            am_cold.CheckedChanged += am_cold_CheckedChanged;
            // 
            // am_numeric
            // 
            am_numeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_numeric.Font = new System.Drawing.Font("Pretendard SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_numeric.FormattingEnabled = true;
            am_numeric.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            am_numeric.Location = new System.Drawing.Point(228, 213);
            am_numeric.Margin = new System.Windows.Forms.Padding(4);
            am_numeric.Name = "am_numeric";
            am_numeric.Size = new System.Drawing.Size(197, 35);
            am_numeric.TabIndex = 1;
            am_numeric.Text = "사이즈를 고르세요.";
            am_numeric.SelectedIndexChanged += am_numeric_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(21, 115);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(183, 169);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // am_option
            // 
            am_option.Controls.Add(am_option3);
            am_option.Controls.Add(am_option2);
            am_option.Controls.Add(am_option1);
            am_option.Location = new System.Drawing.Point(21, 311);
            am_option.Margin = new System.Windows.Forms.Padding(4);
            am_option.Name = "am_option";
            am_option.Padding = new System.Windows.Forms.Padding(4);
            am_option.Size = new System.Drawing.Size(404, 83);
            am_option.TabIndex = 2;
            am_option.TabStop = false;
            // 
            // am_option3
            // 
            am_option3.Appearance = System.Windows.Forms.Appearance.Button;
            am_option3.AutoSize = true;
            am_option3.BackColor = System.Drawing.Color.White;
            am_option3.FlatAppearance.BorderSize = 0;
            am_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_option3.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_option3.Location = new System.Drawing.Point(281, 24);
            am_option3.Margin = new System.Windows.Forms.Padding(4);
            am_option3.Name = "am_option3";
            am_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            am_option3.Size = new System.Drawing.Size(104, 47);
            am_option3.TabIndex = 2;
            am_option3.TabStop = true;
            am_option3.Text = "텀블러";
            am_option3.UseVisualStyleBackColor = false;
            am_option3.CheckedChanged += am_option3_CheckedChanged;
            // 
            // am_option2
            // 
            am_option2.Appearance = System.Windows.Forms.Appearance.Button;
            am_option2.AutoSize = true;
            am_option2.BackColor = System.Drawing.Color.White;
            am_option2.FlatAppearance.BorderSize = 0;
            am_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_option2.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_option2.Location = new System.Drawing.Point(153, 24);
            am_option2.Margin = new System.Windows.Forms.Padding(4);
            am_option2.Name = "am_option2";
            am_option2.Padding = new System.Windows.Forms.Padding(4);
            am_option2.Size = new System.Drawing.Size(115, 47);
            am_option2.TabIndex = 1;
            am_option2.TabStop = true;
            am_option2.Text = "매장용컵";
            am_option2.UseVisualStyleBackColor = false;
            am_option2.CheckedChanged += am_option2_CheckedChanged;
            // 
            // am_option1
            // 
            am_option1.Appearance = System.Windows.Forms.Appearance.Button;
            am_option1.AutoSize = true;
            am_option1.BackColor = System.Drawing.Color.White;
            am_option1.FlatAppearance.BorderSize = 0;
            am_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_option1.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_option1.Location = new System.Drawing.Point(22, 24);
            am_option1.Margin = new System.Windows.Forms.Padding(4);
            am_option1.Name = "am_option1";
            am_option1.Padding = new System.Windows.Forms.Padding(4);
            am_option1.Size = new System.Drawing.Size(115, 47);
            am_option1.TabIndex = 0;
            am_option1.TabStop = true;
            am_option1.Text = "일회용기";
            am_option1.UseVisualStyleBackColor = false;
            am_option1.CheckedChanged += am_option1_CheckedChanged;
            // 
            // am_total
            // 
            am_total.AutoSize = true;
            am_total.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_total.Location = new System.Drawing.Point(15, 22);
            am_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            am_total.Name = "am_total";
            am_total.Size = new System.Drawing.Size(89, 29);
            am_total.TabIndex = 5;
            am_total.Text = "총 가격:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            numericUpDown1.Font = new System.Drawing.Font("Pretendard SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Location = new System.Drawing.Point(228, 256);
            numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(197, 31);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // am_yes
            // 
            am_yes.BackColor = System.Drawing.Color.White;
            am_yes.FlatAppearance.BorderSize = 0;
            am_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_yes.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_yes.Location = new System.Drawing.Point(73, 522);
            am_yes.Margin = new System.Windows.Forms.Padding(4);
            am_yes.Name = "am_yes";
            am_yes.Size = new System.Drawing.Size(131, 61);
            am_yes.TabIndex = 7;
            am_yes.Text = "주문하기";
            am_yes.UseVisualStyleBackColor = false;
            am_yes.Click += am_yes_Click;
            // 
            // am_cancel
            // 
            am_cancel.BackColor = System.Drawing.Color.White;
            am_cancel.FlatAppearance.BorderSize = 0;
            am_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            am_cancel.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_cancel.Location = new System.Drawing.Point(253, 522);
            am_cancel.Margin = new System.Windows.Forms.Padding(4);
            am_cancel.Name = "am_cancel";
            am_cancel.Size = new System.Drawing.Size(131, 61);
            am_cancel.TabIndex = 7;
            am_cancel.Text = "취소하기";
            am_cancel.UseVisualStyleBackColor = false;
            am_cancel.Click += am_cancel_Click;
            // 
            // am_total_value
            // 
            am_total_value.AutoSize = true;
            am_total_value.BackColor = System.Drawing.Color.Transparent;
            am_total_value.Font = new System.Drawing.Font("Pretendard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            am_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            am_total_value.Location = new System.Drawing.Point(106, 21);
            am_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            am_total_value.Name = "am_total_value";
            am_total_value.Size = new System.Drawing.Size(24, 29);
            am_total_value.TabIndex = 5;
            am_total_value.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(476, 64);
            panel1.TabIndex = 8;
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
            label1.Text = "아메리카노";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(am_total);
            panel2.Controls.Add(am_total_value);
            panel2.Location = new System.Drawing.Point(21, 418);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(404, 66);
            panel2.TabIndex = 9;
            // 
            // Americano
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(476, 635);
            Controls.Add(panel2);
            Controls.Add(am_cold);
            Controls.Add(am_hot);
            Controls.Add(panel1);
            Controls.Add(am_cancel);
            Controls.Add(am_yes);
            Controls.Add(numericUpDown1);
            Controls.Add(am_option);
            Controls.Add(pictureBox1);
            Controls.Add(am_numeric);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Americano";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Americano";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            am_option.ResumeLayout(false);
            am_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ComboBox am_numeric;
        private System.Windows.Forms.GroupBox am_option;
        private System.Windows.Forms.Label am_total;
        private System.Windows.Forms.RadioButton am_hot;
        private System.Windows.Forms.RadioButton am_cold;
        private System.Windows.Forms.RadioButton am_option1;
        private System.Windows.Forms.RadioButton am_option3;
        private System.Windows.Forms.RadioButton am_option2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button am_yes;
        private System.Windows.Forms.Button am_cancel;
        private System.Windows.Forms.Label am_total_value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}