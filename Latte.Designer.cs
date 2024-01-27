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
            button2_value = new System.Windows.Forms.Label();
            la_coldhot = new System.Windows.Forms.GroupBox();
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
            la_panel = new System.Windows.Forms.Panel();
            la_coldhot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)la_amount).BeginInit();
            la_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            la_panel.SuspendLayout();
            SuspendLayout();
            // 
            // button2_value
            // 
            button2_value.AutoSize = true;
            button2_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button2_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2_value.Location = new System.Drawing.Point(25, 222);
            button2_value.Margin = new System.Windows.Forms.Padding(0);
            button2_value.Name = "button2_value";
            button2_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            button2_value.Size = new System.Drawing.Size(167, 29);
            button2_value.TabIndex = 4;
            button2_value.Text = "카페라떼";
            // 
            // la_coldhot
            // 
            la_coldhot.Controls.Add(la_hot);
            la_coldhot.Controls.Add(la_cold);
            la_coldhot.Location = new System.Drawing.Point(208, 25);
            la_coldhot.Margin = new System.Windows.Forms.Padding(4);
            la_coldhot.Name = "la_coldhot";
            la_coldhot.Padding = new System.Windows.Forms.Padding(4);
            la_coldhot.Size = new System.Drawing.Size(198, 143);
            la_coldhot.TabIndex = 5;
            la_coldhot.TabStop = false;
            // 
            // la_hot
            // 
            la_hot.Appearance = System.Windows.Forms.Appearance.Button;
            la_hot.AutoSize = true;
            la_hot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_hot.Location = new System.Drawing.Point(24, 36);
            la_hot.Margin = new System.Windows.Forms.Padding(4);
            la_hot.Name = "la_hot";
            la_hot.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            la_hot.Size = new System.Drawing.Size(136, 38);
            la_hot.TabIndex = 1;
            la_hot.TabStop = true;
            la_hot.Text = "핫(HOT)";
            la_hot.UseVisualStyleBackColor = true;
            la_hot.CheckedChanged += la_hot_CheckedChanged;
            // 
            // la_cold
            // 
            la_cold.Appearance = System.Windows.Forms.Appearance.Button;
            la_cold.AutoSize = true;
            la_cold.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_cold.Location = new System.Drawing.Point(24, 85);
            la_cold.Margin = new System.Windows.Forms.Padding(4);
            la_cold.Name = "la_cold";
            la_cold.Size = new System.Drawing.Size(136, 38);
            la_cold.TabIndex = 0;
            la_cold.TabStop = true;
            la_cold.Text = "아이스(ICED)";
            la_cold.UseVisualStyleBackColor = true;
            la_cold.CheckedChanged += la_cold_CheckedChanged;
            // 
            // la_size
            // 
            la_size.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_size.FormattingEnabled = true;
            la_size.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            la_size.Location = new System.Drawing.Point(208, 174);
            la_size.Margin = new System.Windows.Forms.Padding(4);
            la_size.Name = "la_size";
            la_size.Size = new System.Drawing.Size(197, 33);
            la_size.TabIndex = 6;
            la_size.Text = "사이즈를 고르세요.";
            la_size.SelectedIndexChanged += la_size_SelectedIndexChanged;
            // 
            // la_cancel
            // 
            la_cancel.Location = new System.Drawing.Point(232, 444);
            la_cancel.Margin = new System.Windows.Forms.Padding(4);
            la_cancel.Name = "la_cancel";
            la_cancel.Size = new System.Drawing.Size(131, 61);
            la_cancel.TabIndex = 12;
            la_cancel.Text = "취소하기";
            la_cancel.UseVisualStyleBackColor = true;
            la_cancel.Click += la_cancel_Click;
            // 
            // la_yes
            // 
            la_yes.Location = new System.Drawing.Point(52, 444);
            la_yes.Margin = new System.Windows.Forms.Padding(4);
            la_yes.Name = "la_yes";
            la_yes.Size = new System.Drawing.Size(131, 61);
            la_yes.TabIndex = 13;
            la_yes.Text = "주문하기";
            la_yes.UseVisualStyleBackColor = true;
            la_yes.Click += la_yes_Click;
            // 
            // la_amount
            // 
            la_amount.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_amount.Location = new System.Drawing.Point(208, 222);
            la_amount.Margin = new System.Windows.Forms.Padding(4);
            la_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            la_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            la_amount.Name = "la_amount";
            la_amount.Size = new System.Drawing.Size(198, 32);
            la_amount.TabIndex = 11;
            la_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            la_amount.ValueChanged += la_amount_ValueChanged;
            // 
            // la_total_value
            // 
            la_total_value.AutoSize = true;
            la_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            la_total_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            la_total_value.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            la_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            la_total_value.Location = new System.Drawing.Point(141, 384);
            la_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            la_total_value.Name = "la_total_value";
            la_total_value.Size = new System.Drawing.Size(26, 33);
            la_total_value.TabIndex = 9;
            la_total_value.Text = "-";
            // 
            // la_total
            // 
            la_total.AutoSize = true;
            la_total.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_total.Location = new System.Drawing.Point(30, 384);
            la_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            la_total.Name = "la_total";
            la_total.Size = new System.Drawing.Size(99, 32);
            la_total.TabIndex = 10;
            la_total.Text = "총 가격:";
            // 
            // la_option
            // 
            la_option.Controls.Add(la_option3);
            la_option.Controls.Add(la_option2);
            la_option.Controls.Add(la_option1);
            la_option.Location = new System.Drawing.Point(30, 262);
            la_option.Margin = new System.Windows.Forms.Padding(4);
            la_option.Name = "la_option";
            la_option.Padding = new System.Windows.Forms.Padding(4);
            la_option.Size = new System.Drawing.Size(361, 83);
            la_option.TabIndex = 8;
            la_option.TabStop = false;
            // 
            // la_option3
            // 
            la_option3.Appearance = System.Windows.Forms.Appearance.Button;
            la_option3.AutoSize = true;
            la_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_option3.Location = new System.Drawing.Point(252, 24);
            la_option3.Margin = new System.Windows.Forms.Padding(4);
            la_option3.Name = "la_option3";
            la_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            la_option3.Size = new System.Drawing.Size(97, 43);
            la_option3.TabIndex = 2;
            la_option3.TabStop = true;
            la_option3.Text = "텀블러";
            la_option3.UseVisualStyleBackColor = true;
            la_option3.CheckedChanged += la_option3_CheckedChanged;
            // 
            // la_option2
            // 
            la_option2.Appearance = System.Windows.Forms.Appearance.Button;
            la_option2.AutoSize = true;
            la_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_option2.Location = new System.Drawing.Point(137, 24);
            la_option2.Margin = new System.Windows.Forms.Padding(4);
            la_option2.Name = "la_option2";
            la_option2.Padding = new System.Windows.Forms.Padding(4);
            la_option2.Size = new System.Drawing.Size(106, 43);
            la_option2.TabIndex = 1;
            la_option2.TabStop = true;
            la_option2.Text = "매장용컵";
            la_option2.UseVisualStyleBackColor = true;
            la_option2.CheckedChanged += la_option2_CheckedChanged;
            // 
            // la_option1
            // 
            la_option1.Appearance = System.Windows.Forms.Appearance.Button;
            la_option1.AutoSize = true;
            la_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            la_option1.Location = new System.Drawing.Point(23, 24);
            la_option1.Margin = new System.Windows.Forms.Padding(4);
            la_option1.Name = "la_option1";
            la_option1.Padding = new System.Windows.Forms.Padding(4);
            la_option1.Size = new System.Drawing.Size(106, 43);
            la_option1.TabIndex = 0;
            la_option1.TabStop = true;
            la_option1.Text = "일회용기";
            la_option1.UseVisualStyleBackColor = true;
            la_option1.CheckedChanged += la_option1_CheckedChanged;
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
            // la_panel
            // 
            la_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            la_panel.Controls.Add(la_coldhot);
            la_panel.Controls.Add(pictureBox2);
            la_panel.Controls.Add(button2_value);
            la_panel.Controls.Add(la_cancel);
            la_panel.Controls.Add(la_size);
            la_panel.Controls.Add(la_yes);
            la_panel.Controls.Add(la_option);
            la_panel.Controls.Add(la_amount);
            la_panel.Controls.Add(la_total);
            la_panel.Controls.Add(la_total_value);
            la_panel.Location = new System.Drawing.Point(12, 23);
            la_panel.Name = "la_panel";
            la_panel.Size = new System.Drawing.Size(423, 537);
            la_panel.TabIndex = 15;
            // 
            // Latte
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 588);
            Controls.Add(la_panel);
            Name = "Latte";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Latte";
            la_coldhot.ResumeLayout(false);
            la_coldhot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)la_amount).EndInit();
            la_option.ResumeLayout(false);
            la_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            la_panel.ResumeLayout(false);
            la_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label button2_value;
        private System.Windows.Forms.GroupBox la_coldhot;
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
        private System.Windows.Forms.Panel la_panel;
    }
}