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
            soy_panel = new System.Windows.Forms.Panel();
            la_coldhot = new System.Windows.Forms.GroupBox();
            soy_hot = new System.Windows.Forms.RadioButton();
            soy_cold = new System.Windows.Forms.RadioButton();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            soy_value = new System.Windows.Forms.Label();
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
            soy_panel.SuspendLayout();
            la_coldhot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            soy_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soy_amount).BeginInit();
            SuspendLayout();
            // 
            // soy_panel
            // 
            soy_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            soy_panel.Controls.Add(la_coldhot);
            soy_panel.Controls.Add(pictureBox2);
            soy_panel.Controls.Add(soy_value);
            soy_panel.Controls.Add(soy_cancel);
            soy_panel.Controls.Add(soy_size);
            soy_panel.Controls.Add(soy_yes);
            soy_panel.Controls.Add(soy_option);
            soy_panel.Controls.Add(soy_amount);
            soy_panel.Controls.Add(soy_total);
            soy_panel.Controls.Add(soy_total_value);
            soy_panel.Location = new System.Drawing.Point(12, 23);
            soy_panel.Name = "soy_panel";
            soy_panel.Size = new System.Drawing.Size(423, 537);
            soy_panel.TabIndex = 16;
            // 
            // la_coldhot
            // 
            la_coldhot.Controls.Add(soy_hot);
            la_coldhot.Controls.Add(soy_cold);
            la_coldhot.Location = new System.Drawing.Point(208, 25);
            la_coldhot.Margin = new System.Windows.Forms.Padding(4);
            la_coldhot.Name = "la_coldhot";
            la_coldhot.Padding = new System.Windows.Forms.Padding(4);
            la_coldhot.Size = new System.Drawing.Size(198, 143);
            la_coldhot.TabIndex = 5;
            la_coldhot.TabStop = false;
            // 
            // soy_hot
            // 
            soy_hot.Appearance = System.Windows.Forms.Appearance.Button;
            soy_hot.AutoSize = true;
            soy_hot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_hot.Location = new System.Drawing.Point(25, 37);
            soy_hot.Margin = new System.Windows.Forms.Padding(4);
            soy_hot.Name = "soy_hot";
            soy_hot.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            soy_hot.Size = new System.Drawing.Size(136, 38);
            soy_hot.TabIndex = 1;
            soy_hot.TabStop = true;
            soy_hot.Text = "핫(HOT)";
            soy_hot.UseVisualStyleBackColor = true;
            soy_hot.CheckedChanged += soy_hot_CheckedChanged;
            // 
            // soy_cold
            // 
            soy_cold.Appearance = System.Windows.Forms.Appearance.Button;
            soy_cold.AutoSize = true;
            soy_cold.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_cold.Location = new System.Drawing.Point(25, 86);
            soy_cold.Margin = new System.Windows.Forms.Padding(4);
            soy_cold.Name = "soy_cold";
            soy_cold.Size = new System.Drawing.Size(136, 38);
            soy_cold.TabIndex = 0;
            soy_cold.TabStop = true;
            soy_cold.Text = "아이스(ICED)";
            soy_cold.UseVisualStyleBackColor = true;
            soy_cold.CheckedChanged += soy_cold_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(17, 40);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(183, 169);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // soy_value
            // 
            soy_value.AutoSize = true;
            soy_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            soy_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_value.Location = new System.Drawing.Point(25, 222);
            soy_value.Margin = new System.Windows.Forms.Padding(0);
            soy_value.Name = "soy_value";
            soy_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            soy_value.Size = new System.Drawing.Size(167, 29);
            soy_value.TabIndex = 4;
            soy_value.Text = "연유라떼";
            // 
            // soy_cancel
            // 
            soy_cancel.Location = new System.Drawing.Point(232, 444);
            soy_cancel.Margin = new System.Windows.Forms.Padding(4);
            soy_cancel.Name = "soy_cancel";
            soy_cancel.Size = new System.Drawing.Size(131, 61);
            soy_cancel.TabIndex = 12;
            soy_cancel.Text = "취소하기";
            soy_cancel.UseVisualStyleBackColor = true;
            soy_cancel.Click += soy_cancel_Click;
            // 
            // soy_size
            // 
            soy_size.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_size.FormattingEnabled = true;
            soy_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            soy_size.Location = new System.Drawing.Point(208, 174);
            soy_size.Margin = new System.Windows.Forms.Padding(4);
            soy_size.Name = "soy_size";
            soy_size.Size = new System.Drawing.Size(197, 33);
            soy_size.TabIndex = 6;
            soy_size.Text = "사이즈를 고르세요.";
            soy_size.SelectedIndexChanged += soy_size_SelectedIndexChanged;
            // 
            // soy_yes
            // 
            soy_yes.Location = new System.Drawing.Point(52, 444);
            soy_yes.Margin = new System.Windows.Forms.Padding(4);
            soy_yes.Name = "soy_yes";
            soy_yes.Size = new System.Drawing.Size(131, 61);
            soy_yes.TabIndex = 13;
            soy_yes.Text = "주문하기";
            soy_yes.UseVisualStyleBackColor = true;
            soy_yes.Click += soy_yes_Click;
            // 
            // soy_option
            // 
            soy_option.Controls.Add(soy_option3);
            soy_option.Controls.Add(soy_option2);
            soy_option.Controls.Add(soy_option1);
            soy_option.Location = new System.Drawing.Point(30, 262);
            soy_option.Margin = new System.Windows.Forms.Padding(4);
            soy_option.Name = "soy_option";
            soy_option.Padding = new System.Windows.Forms.Padding(4);
            soy_option.Size = new System.Drawing.Size(361, 83);
            soy_option.TabIndex = 8;
            soy_option.TabStop = false;
            // 
            // soy_option3
            // 
            soy_option3.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option3.AutoSize = true;
            soy_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_option3.Location = new System.Drawing.Point(253, 25);
            soy_option3.Margin = new System.Windows.Forms.Padding(4);
            soy_option3.Name = "soy_option3";
            soy_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            soy_option3.Size = new System.Drawing.Size(97, 43);
            soy_option3.TabIndex = 2;
            soy_option3.TabStop = true;
            soy_option3.Text = "텀블러";
            soy_option3.UseVisualStyleBackColor = true;
            soy_option3.CheckedChanged += soy_option3_CheckedChanged;
            // 
            // soy_option2
            // 
            soy_option2.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option2.AutoSize = true;
            soy_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_option2.Location = new System.Drawing.Point(138, 25);
            soy_option2.Margin = new System.Windows.Forms.Padding(4);
            soy_option2.Name = "soy_option2";
            soy_option2.Padding = new System.Windows.Forms.Padding(4);
            soy_option2.Size = new System.Drawing.Size(106, 43);
            soy_option2.TabIndex = 1;
            soy_option2.TabStop = true;
            soy_option2.Text = "매장용컵";
            soy_option2.UseVisualStyleBackColor = true;
            soy_option2.CheckedChanged += soy_option2_CheckedChanged;
            // 
            // soy_option1
            // 
            soy_option1.Appearance = System.Windows.Forms.Appearance.Button;
            soy_option1.AutoSize = true;
            soy_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_option1.Location = new System.Drawing.Point(24, 25);
            soy_option1.Margin = new System.Windows.Forms.Padding(4);
            soy_option1.Name = "soy_option1";
            soy_option1.Padding = new System.Windows.Forms.Padding(4);
            soy_option1.Size = new System.Drawing.Size(106, 43);
            soy_option1.TabIndex = 0;
            soy_option1.TabStop = true;
            soy_option1.Text = "일회용기";
            soy_option1.UseVisualStyleBackColor = true;
            soy_option1.CheckedChanged += soy_option1_CheckedChanged;
            // 
            // soy_amount
            // 
            soy_amount.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_amount.Location = new System.Drawing.Point(208, 222);
            soy_amount.Margin = new System.Windows.Forms.Padding(4);
            soy_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            soy_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soy_amount.Name = "soy_amount";
            soy_amount.Size = new System.Drawing.Size(198, 32);
            soy_amount.TabIndex = 11;
            soy_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soy_amount.ValueChanged += soy_amount_ValueChanged;
            // 
            // soy_total
            // 
            soy_total.AutoSize = true;
            soy_total.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            soy_total.Location = new System.Drawing.Point(30, 384);
            soy_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soy_total.Name = "soy_total";
            soy_total.Size = new System.Drawing.Size(99, 32);
            soy_total.TabIndex = 10;
            soy_total.Text = "총 가격:";
            // 
            // soy_total_value
            // 
            soy_total_value.AutoSize = true;
            soy_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            soy_total_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            soy_total_value.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            soy_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            soy_total_value.Location = new System.Drawing.Point(141, 384);
            soy_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soy_total_value.Name = "soy_total_value";
            soy_total_value.Size = new System.Drawing.Size(26, 33);
            soy_total_value.TabIndex = 9;
            soy_total_value.Text = "-";
            // 
            // SoyLatte
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 588);
            Controls.Add(soy_panel);
            Name = "SoyLatte";
            Text = "SoyLatte";
            soy_panel.ResumeLayout(false);
            soy_panel.PerformLayout();
            la_coldhot.ResumeLayout(false);
            la_coldhot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            soy_option.ResumeLayout(false);
            soy_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soy_amount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel soy_panel;
        private System.Windows.Forms.GroupBox la_coldhot;
        private System.Windows.Forms.RadioButton soy_hot;
        private System.Windows.Forms.RadioButton soy_cold;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label soy_value;
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
    }
}