namespace Coffee_Shop_Kiosk
{
    partial class Cappuchino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cappuchino));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cap_cancel = new System.Windows.Forms.Button();
            cap_yes = new System.Windows.Forms.Button();
            cap_amount = new System.Windows.Forms.NumericUpDown();
            cap_total_value = new System.Windows.Forms.Label();
            cap_total = new System.Windows.Forms.Label();
            am_option = new System.Windows.Forms.GroupBox();
            cap_option3 = new System.Windows.Forms.RadioButton();
            cap_option2 = new System.Windows.Forms.RadioButton();
            cap_option1 = new System.Windows.Forms.RadioButton();
            cap_size = new System.Windows.Forms.ComboBox();
            cap_hot = new System.Windows.Forms.RadioButton();
            cap_cold = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cap_amount).BeginInit();
            am_option.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(142, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cap_cancel
            // 
            cap_cancel.BackColor = System.Drawing.Color.White;
            cap_cancel.FlatAppearance.BorderSize = 0;
            cap_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_cancel.Location = new System.Drawing.Point(200, 392);
            cap_cancel.Name = "cap_cancel";
            cap_cancel.Size = new System.Drawing.Size(102, 46);
            cap_cancel.TabIndex = 19;
            cap_cancel.Text = "취소하기";
            cap_cancel.UseVisualStyleBackColor = false;
            cap_cancel.Click += cap_cancel_Click;
            // 
            // cap_yes
            // 
            cap_yes.BackColor = System.Drawing.Color.White;
            cap_yes.FlatAppearance.BorderSize = 0;
            cap_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_yes.Location = new System.Drawing.Point(60, 392);
            cap_yes.Name = "cap_yes";
            cap_yes.Size = new System.Drawing.Size(102, 46);
            cap_yes.TabIndex = 20;
            cap_yes.Text = "주문하기";
            cap_yes.UseVisualStyleBackColor = false;
            cap_yes.Click += cap_yes_Click;
            // 
            // cap_amount
            // 
            cap_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cap_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_amount.Location = new System.Drawing.Point(180, 193);
            cap_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cap_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cap_amount.Name = "cap_amount";
            cap_amount.Size = new System.Drawing.Size(154, 25);
            cap_amount.TabIndex = 18;
            cap_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cap_amount.ValueChanged += cap_amount_ValueChanged;
            // 
            // cap_total_value
            // 
            cap_total_value.AutoSize = true;
            cap_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cap_total_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_total_value.ForeColor = System.Drawing.Color.Black;
            cap_total_value.Location = new System.Drawing.Point(86, 16);
            cap_total_value.Name = "cap_total_value";
            cap_total_value.Size = new System.Drawing.Size(17, 24);
            cap_total_value.TabIndex = 16;
            cap_total_value.Text = "-";
            // 
            // cap_total
            // 
            cap_total.AutoSize = true;
            cap_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_total.Location = new System.Drawing.Point(12, 16);
            cap_total.Name = "cap_total";
            cap_total.Size = new System.Drawing.Size(67, 24);
            cap_total.TabIndex = 17;
            cap_total.Text = "총 가격:";
            // 
            // am_option
            // 
            am_option.Controls.Add(cap_option3);
            am_option.Controls.Add(cap_option2);
            am_option.Controls.Add(cap_option1);
            am_option.Location = new System.Drawing.Point(19, 233);
            am_option.Name = "am_option";
            am_option.Size = new System.Drawing.Size(315, 62);
            am_option.TabIndex = 15;
            am_option.TabStop = false;
            // 
            // cap_option3
            // 
            cap_option3.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option3.AutoSize = true;
            cap_option3.BackColor = System.Drawing.Color.White;
            cap_option3.FlatAppearance.BorderSize = 0;
            cap_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_option3.Location = new System.Drawing.Point(219, 18);
            cap_option3.Name = "cap_option3";
            cap_option3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            cap_option3.Size = new System.Drawing.Size(79, 40);
            cap_option3.TabIndex = 2;
            cap_option3.TabStop = true;
            cap_option3.Text = "텀블러";
            cap_option3.UseVisualStyleBackColor = false;
            cap_option3.CheckedChanged += cap_option3_CheckedChanged;
            // 
            // cap_option2
            // 
            cap_option2.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option2.AutoSize = true;
            cap_option2.BackColor = System.Drawing.Color.White;
            cap_option2.FlatAppearance.BorderSize = 0;
            cap_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_option2.Location = new System.Drawing.Point(119, 18);
            cap_option2.Name = "cap_option2";
            cap_option2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            cap_option2.Size = new System.Drawing.Size(86, 40);
            cap_option2.TabIndex = 1;
            cap_option2.TabStop = true;
            cap_option2.Text = "매장용컵";
            cap_option2.UseVisualStyleBackColor = false;
            cap_option2.CheckedChanged += cap_option2_CheckedChanged;
            // 
            // cap_option1
            // 
            cap_option1.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option1.AutoSize = true;
            cap_option1.BackColor = System.Drawing.Color.White;
            cap_option1.FlatAppearance.BorderSize = 0;
            cap_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_option1.Location = new System.Drawing.Point(18, 18);
            cap_option1.Name = "cap_option1";
            cap_option1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            cap_option1.Size = new System.Drawing.Size(86, 40);
            cap_option1.TabIndex = 0;
            cap_option1.TabStop = true;
            cap_option1.Text = "일회용기";
            cap_option1.UseVisualStyleBackColor = false;
            cap_option1.CheckedChanged += cap_option1_CheckedChanged;
            // 
            // cap_size
            // 
            cap_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_size.FormattingEnabled = true;
            cap_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            cap_size.Location = new System.Drawing.Point(180, 160);
            cap_size.Name = "cap_size";
            cap_size.Size = new System.Drawing.Size(155, 32);
            cap_size.TabIndex = 14;
            cap_size.Text = "사이즈를 고르세요.";
            cap_size.SelectedIndexChanged += cap_size_SelectedIndexChanged;
            // 
            // cap_hot
            // 
            cap_hot.Appearance = System.Windows.Forms.Appearance.Button;
            cap_hot.AutoSize = true;
            cap_hot.BackColor = System.Drawing.Color.White;
            cap_hot.FlatAppearance.BorderSize = 0;
            cap_hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_hot.Location = new System.Drawing.Point(194, 79);
            cap_hot.Name = "cap_hot";
            cap_hot.Padding = new System.Windows.Forms.Padding(16, 0, 19, 0);
            cap_hot.Size = new System.Drawing.Size(128, 34);
            cap_hot.TabIndex = 1;
            cap_hot.TabStop = true;
            cap_hot.Text = "핫(HOT)";
            cap_hot.UseVisualStyleBackColor = false;
            cap_hot.CheckedChanged += cap_hot_CheckedChanged;
            // 
            // cap_cold
            // 
            cap_cold.Appearance = System.Windows.Forms.Appearance.Button;
            cap_cold.AutoSize = true;
            cap_cold.BackColor = System.Drawing.Color.White;
            cap_cold.FlatAppearance.BorderSize = 0;
            cap_cold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cap_cold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_cold.Location = new System.Drawing.Point(194, 120);
            cap_cold.Name = "cap_cold";
            cap_cold.Size = new System.Drawing.Size(126, 34);
            cap_cold.TabIndex = 0;
            cap_cold.TabStop = true;
            cap_cold.Text = "아이스(ICED)";
            cap_cold.UseVisualStyleBackColor = false;
            cap_cold.CheckedChanged += cap_cold_CheckedChanged;
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
            label1.Text = "카푸치노";
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
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(cap_total);
            panel2.Controls.Add(cap_total_value);
            panel2.Location = new System.Drawing.Point(19, 314);
            panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(314, 50);
            panel2.TabIndex = 22;
            // 
            // Cappuchino
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(370, 476);
            Controls.Add(cap_cold);
            Controls.Add(cap_hot);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cap_cancel);
            Controls.Add(cap_yes);
            Controls.Add(cap_amount);
            Controls.Add(am_option);
            Controls.Add(cap_size);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Cappuchino";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cappuchino";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cap_amount).EndInit();
            am_option.ResumeLayout(false);
            am_option.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cap_cancel;
        private System.Windows.Forms.Button cap_yes;
        private System.Windows.Forms.NumericUpDown cap_amount;
        private System.Windows.Forms.Label cap_total_value;
        private System.Windows.Forms.Label cap_total;
        private System.Windows.Forms.GroupBox am_option;
        private System.Windows.Forms.RadioButton cap_option3;
        private System.Windows.Forms.RadioButton cap_option2;
        private System.Windows.Forms.RadioButton cap_option1;
        internal System.Windows.Forms.ComboBox cap_size;
        private System.Windows.Forms.RadioButton cap_hot;
        private System.Windows.Forms.RadioButton cap_cold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}