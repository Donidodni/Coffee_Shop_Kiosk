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
            am_coldhot = new System.Windows.Forms.GroupBox();
            am_hot = new System.Windows.Forms.RadioButton();
            am_cold = new System.Windows.Forms.RadioButton();
            am_numeric = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1_value = new System.Windows.Forms.Label();
            am_option = new System.Windows.Forms.GroupBox();
            am_option3 = new System.Windows.Forms.RadioButton();
            am_option2 = new System.Windows.Forms.RadioButton();
            am_option1 = new System.Windows.Forms.RadioButton();
            am_total = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            am_yes = new System.Windows.Forms.Button();
            am_cancel = new System.Windows.Forms.Button();
            am_total_value = new System.Windows.Forms.Label();
            am_coldhot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            am_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // am_coldhot
            // 
            am_coldhot.Controls.Add(am_hot);
            am_coldhot.Controls.Add(am_cold);
            am_coldhot.Location = new System.Drawing.Point(174, 30);
            am_coldhot.Name = "am_coldhot";
            am_coldhot.Size = new System.Drawing.Size(154, 107);
            am_coldhot.TabIndex = 0;
            am_coldhot.TabStop = false;
            // 
            // am_hot
            // 
            am_hot.Appearance = System.Windows.Forms.Appearance.Button;
            am_hot.AutoSize = true;
            am_hot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_hot.Location = new System.Drawing.Point(19, 27);
            am_hot.Name = "am_hot";
            am_hot.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            am_hot.Size = new System.Drawing.Size(111, 31);
            am_hot.TabIndex = 1;
            am_hot.TabStop = true;
            am_hot.Text = "핫(HOT)";
            am_hot.UseVisualStyleBackColor = true;
            am_hot.CheckedChanged += am_hot_CheckedChanged;
            // 
            // am_cold
            // 
            am_cold.Appearance = System.Windows.Forms.Appearance.Button;
            am_cold.AutoSize = true;
            am_cold.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_cold.Location = new System.Drawing.Point(19, 64);
            am_cold.Name = "am_cold";
            am_cold.Size = new System.Drawing.Size(111, 31);
            am_cold.TabIndex = 0;
            am_cold.TabStop = true;
            am_cold.Text = "아이스(ICED)";
            am_cold.UseVisualStyleBackColor = true;
            am_cold.CheckedChanged += am_cold_CheckedChanged;
            // 
            // am_numeric
            // 
            am_numeric.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_numeric.FormattingEnabled = true;
            am_numeric.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            am_numeric.Location = new System.Drawing.Point(174, 142);
            am_numeric.Name = "am_numeric";
            am_numeric.Size = new System.Drawing.Size(154, 28);
            am_numeric.TabIndex = 1;
            am_numeric.Text = "사이즈를 고르세요.";
            am_numeric.SelectedIndexChanged += am_numeric_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(26, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(142, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1_value
            // 
            button1_value.AutoSize = true;
            button1_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button1_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1_value.Location = new System.Drawing.Point(26, 178);
            button1_value.Name = "button1_value";
            button1_value.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            button1_value.Size = new System.Drawing.Size(142, 25);
            button1_value.TabIndex = 4;
            button1_value.Text = "아메리카노";
            // 
            // am_option
            // 
            am_option.Controls.Add(am_option3);
            am_option.Controls.Add(am_option2);
            am_option.Controls.Add(am_option1);
            am_option.Location = new System.Drawing.Point(36, 208);
            am_option.Name = "am_option";
            am_option.Size = new System.Drawing.Size(281, 62);
            am_option.TabIndex = 2;
            am_option.TabStop = false;
            // 
            // am_option3
            // 
            am_option3.Appearance = System.Windows.Forms.Appearance.Button;
            am_option3.AutoSize = true;
            am_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_option3.Location = new System.Drawing.Point(195, 17);
            am_option3.Name = "am_option3";
            am_option3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            am_option3.Size = new System.Drawing.Size(78, 36);
            am_option3.TabIndex = 2;
            am_option3.TabStop = true;
            am_option3.Text = "텀블러";
            am_option3.UseVisualStyleBackColor = true;
            am_option3.CheckedChanged += am_option3_CheckedChanged;
            // 
            // am_option2
            // 
            am_option2.Appearance = System.Windows.Forms.Appearance.Button;
            am_option2.AutoSize = true;
            am_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_option2.Location = new System.Drawing.Point(106, 17);
            am_option2.Name = "am_option2";
            am_option2.Padding = new System.Windows.Forms.Padding(3);
            am_option2.Size = new System.Drawing.Size(85, 36);
            am_option2.TabIndex = 1;
            am_option2.TabStop = true;
            am_option2.Text = "매장용컵";
            am_option2.UseVisualStyleBackColor = true;
            am_option2.CheckedChanged += am_option2_CheckedChanged;
            // 
            // am_option1
            // 
            am_option1.Appearance = System.Windows.Forms.Appearance.Button;
            am_option1.AutoSize = true;
            am_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_option1.Location = new System.Drawing.Point(17, 17);
            am_option1.Name = "am_option1";
            am_option1.Padding = new System.Windows.Forms.Padding(3);
            am_option1.Size = new System.Drawing.Size(85, 36);
            am_option1.TabIndex = 0;
            am_option1.TabStop = true;
            am_option1.Text = "일회용기";
            am_option1.UseVisualStyleBackColor = true;
            am_option1.CheckedChanged += am_option1_CheckedChanged;
            // 
            // am_total
            // 
            am_total.AutoSize = true;
            am_total.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_total.Location = new System.Drawing.Point(36, 299);
            am_total.Name = "am_total";
            am_total.Size = new System.Drawing.Size(80, 25);
            am_total.TabIndex = 5;
            am_total.Text = "총 가격:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Location = new System.Drawing.Point(174, 178);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(154, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // am_yes
            // 
            am_yes.Location = new System.Drawing.Point(53, 344);
            am_yes.Name = "am_yes";
            am_yes.Size = new System.Drawing.Size(102, 46);
            am_yes.TabIndex = 7;
            am_yes.Text = "주문하기";
            am_yes.UseVisualStyleBackColor = true;
            am_yes.Click += am_yes_Click;
            // 
            // am_cancel
            // 
            am_cancel.Location = new System.Drawing.Point(193, 344);
            am_cancel.Name = "am_cancel";
            am_cancel.Size = new System.Drawing.Size(102, 46);
            am_cancel.TabIndex = 7;
            am_cancel.Text = "취소하기";
            am_cancel.UseVisualStyleBackColor = true;
            am_cancel.Click += am_cancel_Click;
            // 
            // am_total_value
            // 
            am_total_value.AutoSize = true;
            am_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            am_total_value.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            am_total_value.ForeColor = System.Drawing.Color.Red;
            am_total_value.Location = new System.Drawing.Point(122, 299);
            am_total_value.Name = "am_total_value";
            am_total_value.Size = new System.Drawing.Size(20, 25);
            am_total_value.TabIndex = 5;
            am_total_value.Text = "-";
            // 
            // Americano
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(356, 441);
            Controls.Add(am_cancel);
            Controls.Add(am_yes);
            Controls.Add(numericUpDown1);
            Controls.Add(am_total_value);
            Controls.Add(am_total);
            Controls.Add(am_option);
            Controls.Add(button1_value);
            Controls.Add(pictureBox1);
            Controls.Add(am_numeric);
            Controls.Add(am_coldhot);
            Name = "Americano";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Americano";
            am_coldhot.ResumeLayout(false);
            am_coldhot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            am_option.ResumeLayout(false);
            am_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox am_coldhot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label button1_value;
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
    }
}