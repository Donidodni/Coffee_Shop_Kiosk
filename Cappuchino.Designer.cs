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
            cap_value = new System.Windows.Forms.Label();
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
            am_coldhot = new System.Windows.Forms.GroupBox();
            cap_hot = new System.Windows.Forms.RadioButton();
            cap_cold = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cap_amount).BeginInit();
            am_option.SuspendLayout();
            am_coldhot.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(33, 55);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(183, 169);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cap_value
            // 
            cap_value.AutoSize = true;
            cap_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cap_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cap_value.Location = new System.Drawing.Point(44, 237);
            cap_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cap_value.Name = "cap_value";
            cap_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            cap_value.Size = new System.Drawing.Size(167, 29);
            cap_value.TabIndex = 12;
            cap_value.Text = "카푸치노";
            // 
            // cap_cancel
            // 
            cap_cancel.Location = new System.Drawing.Point(248, 459);
            cap_cancel.Margin = new System.Windows.Forms.Padding(4);
            cap_cancel.Name = "cap_cancel";
            cap_cancel.Size = new System.Drawing.Size(131, 61);
            cap_cancel.TabIndex = 19;
            cap_cancel.Text = "취소하기";
            cap_cancel.UseVisualStyleBackColor = true;
            cap_cancel.Click += cap_cancel_Click;
            // 
            // cap_yes
            // 
            cap_yes.Location = new System.Drawing.Point(68, 459);
            cap_yes.Margin = new System.Windows.Forms.Padding(4);
            cap_yes.Name = "cap_yes";
            cap_yes.Size = new System.Drawing.Size(131, 61);
            cap_yes.TabIndex = 20;
            cap_yes.Text = "주문하기";
            cap_yes.UseVisualStyleBackColor = true;
            cap_yes.Click += cap_yes_Click;
            // 
            // cap_amount
            // 
            cap_amount.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_amount.Location = new System.Drawing.Point(224, 237);
            cap_amount.Margin = new System.Windows.Forms.Padding(4);
            cap_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cap_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cap_amount.Name = "cap_amount";
            cap_amount.Size = new System.Drawing.Size(198, 32);
            cap_amount.TabIndex = 18;
            cap_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cap_amount.ValueChanged += cap_amount_ValueChanged;
            // 
            // cap_total_value
            // 
            cap_total_value.AutoSize = true;
            cap_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cap_total_value.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_total_value.ForeColor = System.Drawing.Color.Red;
            cap_total_value.Location = new System.Drawing.Point(157, 399);
            cap_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cap_total_value.Name = "cap_total_value";
            cap_total_value.Size = new System.Drawing.Size(24, 32);
            cap_total_value.TabIndex = 16;
            cap_total_value.Text = "-";
            // 
            // cap_total
            // 
            cap_total.AutoSize = true;
            cap_total.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_total.Location = new System.Drawing.Point(46, 399);
            cap_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cap_total.Name = "cap_total";
            cap_total.Size = new System.Drawing.Size(99, 32);
            cap_total.TabIndex = 17;
            cap_total.Text = "총 가격:";
            // 
            // am_option
            // 
            am_option.Controls.Add(cap_option3);
            am_option.Controls.Add(cap_option2);
            am_option.Controls.Add(cap_option1);
            am_option.Location = new System.Drawing.Point(46, 277);
            am_option.Margin = new System.Windows.Forms.Padding(4);
            am_option.Name = "am_option";
            am_option.Padding = new System.Windows.Forms.Padding(4);
            am_option.Size = new System.Drawing.Size(361, 83);
            am_option.TabIndex = 15;
            am_option.TabStop = false;
            // 
            // cap_option3
            // 
            cap_option3.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option3.AutoSize = true;
            cap_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option3.Location = new System.Drawing.Point(252, 24);
            cap_option3.Margin = new System.Windows.Forms.Padding(4);
            cap_option3.Name = "cap_option3";
            cap_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            cap_option3.Size = new System.Drawing.Size(97, 43);
            cap_option3.TabIndex = 2;
            cap_option3.TabStop = true;
            cap_option3.Text = "텀블러";
            cap_option3.UseVisualStyleBackColor = true;
            cap_option3.CheckedChanged += cap_option3_CheckedChanged;
            // 
            // cap_option2
            // 
            cap_option2.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option2.AutoSize = true;
            cap_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option2.Location = new System.Drawing.Point(137, 24);
            cap_option2.Margin = new System.Windows.Forms.Padding(4);
            cap_option2.Name = "cap_option2";
            cap_option2.Padding = new System.Windows.Forms.Padding(4);
            cap_option2.Size = new System.Drawing.Size(106, 43);
            cap_option2.TabIndex = 1;
            cap_option2.TabStop = true;
            cap_option2.Text = "매장용컵";
            cap_option2.UseVisualStyleBackColor = true;
            cap_option2.CheckedChanged += cap_option2_CheckedChanged;
            // 
            // cap_option1
            // 
            cap_option1.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option1.AutoSize = true;
            cap_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option1.Location = new System.Drawing.Point(23, 24);
            cap_option1.Margin = new System.Windows.Forms.Padding(4);
            cap_option1.Name = "cap_option1";
            cap_option1.Padding = new System.Windows.Forms.Padding(4);
            cap_option1.Size = new System.Drawing.Size(106, 43);
            cap_option1.TabIndex = 0;
            cap_option1.TabStop = true;
            cap_option1.Text = "일회용기";
            cap_option1.UseVisualStyleBackColor = true;
            cap_option1.CheckedChanged += cap_option1_CheckedChanged;
            // 
            // cap_size
            // 
            cap_size.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_size.FormattingEnabled = true;
            cap_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            cap_size.Location = new System.Drawing.Point(224, 189);
            cap_size.Margin = new System.Windows.Forms.Padding(4);
            cap_size.Name = "cap_size";
            cap_size.Size = new System.Drawing.Size(197, 33);
            cap_size.TabIndex = 14;
            cap_size.Text = "사이즈를 고르세요.";
            cap_size.SelectedIndexChanged += cap_size_SelectedIndexChanged;
            // 
            // am_coldhot
            // 
            am_coldhot.Controls.Add(cap_hot);
            am_coldhot.Controls.Add(cap_cold);
            am_coldhot.Location = new System.Drawing.Point(224, 40);
            am_coldhot.Margin = new System.Windows.Forms.Padding(4);
            am_coldhot.Name = "am_coldhot";
            am_coldhot.Padding = new System.Windows.Forms.Padding(4);
            am_coldhot.Size = new System.Drawing.Size(198, 143);
            am_coldhot.TabIndex = 13;
            am_coldhot.TabStop = false;
            // 
            // cap_hot
            // 
            cap_hot.Appearance = System.Windows.Forms.Appearance.Button;
            cap_hot.AutoSize = true;
            cap_hot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_hot.Location = new System.Drawing.Point(25, 37);
            cap_hot.Margin = new System.Windows.Forms.Padding(4);
            cap_hot.Name = "cap_hot";
            cap_hot.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            cap_hot.Size = new System.Drawing.Size(136, 38);
            cap_hot.TabIndex = 1;
            cap_hot.TabStop = true;
            cap_hot.Text = "핫(HOT)";
            cap_hot.UseVisualStyleBackColor = true;
            cap_hot.CheckedChanged += cap_hot_CheckedChanged;
            // 
            // cap_cold
            // 
            cap_cold.Appearance = System.Windows.Forms.Appearance.Button;
            cap_cold.AutoSize = true;
            cap_cold.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_cold.Location = new System.Drawing.Point(25, 86);
            cap_cold.Margin = new System.Windows.Forms.Padding(4);
            cap_cold.Name = "cap_cold";
            cap_cold.Size = new System.Drawing.Size(136, 38);
            cap_cold.TabIndex = 0;
            cap_cold.TabStop = true;
            cap_cold.Text = "아이스(ICED)";
            cap_cold.UseVisualStyleBackColor = true;
            cap_cold.CheckedChanged += cap_cold_CheckedChanged;
            // 
            // Cappuchino
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 588);
            Controls.Add(cap_cancel);
            Controls.Add(cap_yes);
            Controls.Add(cap_amount);
            Controls.Add(cap_total_value);
            Controls.Add(cap_total);
            Controls.Add(am_option);
            Controls.Add(cap_size);
            Controls.Add(am_coldhot);
            Controls.Add(cap_value);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Cappuchino";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cappuchino";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cap_amount).EndInit();
            am_option.ResumeLayout(false);
            am_option.PerformLayout();
            am_coldhot.ResumeLayout(false);
            am_coldhot.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cap_value;
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
        private System.Windows.Forms.GroupBox am_coldhot;
        private System.Windows.Forms.RadioButton cap_hot;
        private System.Windows.Forms.RadioButton cap_cold;
    }
}