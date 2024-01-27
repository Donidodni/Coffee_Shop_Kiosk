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
            es_panel = new System.Windows.Forms.Panel();
            la_coldhot = new System.Windows.Forms.GroupBox();
            es_notice1 = new System.Windows.Forms.Label();
            es_notice = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            es_value = new System.Windows.Forms.Label();
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
            es_panel.SuspendLayout();
            la_coldhot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            es_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)es_amount).BeginInit();
            SuspendLayout();
            // 
            // es_panel
            // 
            es_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            es_panel.Controls.Add(la_coldhot);
            es_panel.Controls.Add(pictureBox2);
            es_panel.Controls.Add(es_value);
            es_panel.Controls.Add(es_cancel);
            es_panel.Controls.Add(es_size);
            es_panel.Controls.Add(es_yes);
            es_panel.Controls.Add(es_option);
            es_panel.Controls.Add(es_amount);
            es_panel.Controls.Add(es_total);
            es_panel.Controls.Add(es_total_value);
            es_panel.Location = new System.Drawing.Point(12, 23);
            es_panel.Name = "es_panel";
            es_panel.Size = new System.Drawing.Size(423, 537);
            es_panel.TabIndex = 16;
            // 
            // la_coldhot
            // 
            la_coldhot.Controls.Add(es_notice1);
            la_coldhot.Controls.Add(es_notice);
            la_coldhot.Location = new System.Drawing.Point(208, 25);
            la_coldhot.Margin = new System.Windows.Forms.Padding(4);
            la_coldhot.Name = "la_coldhot";
            la_coldhot.Padding = new System.Windows.Forms.Padding(4);
            la_coldhot.Size = new System.Drawing.Size(198, 143);
            la_coldhot.TabIndex = 5;
            la_coldhot.TabStop = false;
            // 
            // es_notice1
            // 
            es_notice1.AutoSize = true;
            es_notice1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_notice1.Location = new System.Drawing.Point(8, 79);
            es_notice1.Name = "es_notice1";
            es_notice1.Size = new System.Drawing.Size(183, 23);
            es_notice1.TabIndex = 0;
            es_notice1.Text = "핫(HOT)이 기본입니다.";
            // 
            // es_notice
            // 
            es_notice.AutoSize = true;
            es_notice.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_notice.Location = new System.Drawing.Point(7, 56);
            es_notice.Name = "es_notice";
            es_notice.Size = new System.Drawing.Size(118, 23);
            es_notice.TabIndex = 0;
            es_notice.Text = "에스프레소는 ";
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
            // es_value
            // 
            es_value.AutoSize = true;
            es_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            es_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_value.Location = new System.Drawing.Point(25, 222);
            es_value.Margin = new System.Windows.Forms.Padding(0);
            es_value.Name = "es_value";
            es_value.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            es_value.Size = new System.Drawing.Size(174, 29);
            es_value.TabIndex = 4;
            es_value.Text = "에스프레소";
            // 
            // es_cancel
            // 
            es_cancel.Location = new System.Drawing.Point(232, 444);
            es_cancel.Margin = new System.Windows.Forms.Padding(4);
            es_cancel.Name = "es_cancel";
            es_cancel.Size = new System.Drawing.Size(131, 61);
            es_cancel.TabIndex = 12;
            es_cancel.Text = "취소하기";
            es_cancel.UseVisualStyleBackColor = true;
            es_cancel.Click += es_cancel_Click;
            // 
            // es_size
            // 
            es_size.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_size.FormattingEnabled = true;
            es_size.Items.AddRange(new object[] { "원샷(기본)", "더블샷", "트리플샷" });
            es_size.Location = new System.Drawing.Point(208, 174);
            es_size.Margin = new System.Windows.Forms.Padding(4);
            es_size.Name = "es_size";
            es_size.Size = new System.Drawing.Size(197, 33);
            es_size.TabIndex = 6;
            es_size.Text = "사이즈를 고르세요.";
            es_size.SelectedIndexChanged += es_size_SelectedIndexChanged;
            // 
            // es_yes
            // 
            es_yes.Location = new System.Drawing.Point(52, 444);
            es_yes.Margin = new System.Windows.Forms.Padding(4);
            es_yes.Name = "es_yes";
            es_yes.Size = new System.Drawing.Size(131, 61);
            es_yes.TabIndex = 13;
            es_yes.Text = "주문하기";
            es_yes.UseVisualStyleBackColor = true;
            es_yes.Click += es_yes_Click;
            // 
            // es_option
            // 
            es_option.Controls.Add(es_option3);
            es_option.Controls.Add(es_option2);
            es_option.Controls.Add(es_option1);
            es_option.Location = new System.Drawing.Point(30, 262);
            es_option.Margin = new System.Windows.Forms.Padding(4);
            es_option.Name = "es_option";
            es_option.Padding = new System.Windows.Forms.Padding(4);
            es_option.Size = new System.Drawing.Size(361, 83);
            es_option.TabIndex = 8;
            es_option.TabStop = false;
            // 
            // es_option3
            // 
            es_option3.Appearance = System.Windows.Forms.Appearance.Button;
            es_option3.AutoSize = true;
            es_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_option3.Location = new System.Drawing.Point(253, 25);
            es_option3.Margin = new System.Windows.Forms.Padding(4);
            es_option3.Name = "es_option3";
            es_option3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 4);
            es_option3.Size = new System.Drawing.Size(97, 43);
            es_option3.TabIndex = 2;
            es_option3.TabStop = true;
            es_option3.Text = "텀블러";
            es_option3.UseVisualStyleBackColor = true;
            es_option3.CheckedChanged += es_option3_CheckedChanged;
            // 
            // es_option2
            // 
            es_option2.Appearance = System.Windows.Forms.Appearance.Button;
            es_option2.AutoSize = true;
            es_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_option2.Location = new System.Drawing.Point(138, 25);
            es_option2.Margin = new System.Windows.Forms.Padding(4);
            es_option2.Name = "es_option2";
            es_option2.Padding = new System.Windows.Forms.Padding(4);
            es_option2.Size = new System.Drawing.Size(106, 43);
            es_option2.TabIndex = 1;
            es_option2.TabStop = true;
            es_option2.Text = "매장용컵";
            es_option2.UseVisualStyleBackColor = true;
            es_option2.CheckedChanged += es_option2_CheckedChanged;
            // 
            // es_option1
            // 
            es_option1.Appearance = System.Windows.Forms.Appearance.Button;
            es_option1.AutoSize = true;
            es_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_option1.Location = new System.Drawing.Point(24, 25);
            es_option1.Margin = new System.Windows.Forms.Padding(4);
            es_option1.Name = "es_option1";
            es_option1.Padding = new System.Windows.Forms.Padding(4);
            es_option1.Size = new System.Drawing.Size(106, 43);
            es_option1.TabIndex = 0;
            es_option1.TabStop = true;
            es_option1.Text = "일회용기";
            es_option1.UseVisualStyleBackColor = true;
            es_option1.CheckedChanged += es_option1_CheckedChanged;
            // 
            // es_amount
            // 
            es_amount.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_amount.Location = new System.Drawing.Point(208, 222);
            es_amount.Margin = new System.Windows.Forms.Padding(4);
            es_amount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            es_amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            es_amount.Name = "es_amount";
            es_amount.Size = new System.Drawing.Size(198, 32);
            es_amount.TabIndex = 11;
            es_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            es_amount.ValueChanged += es_amount_ValueChanged;
            // 
            // es_total
            // 
            es_total.AutoSize = true;
            es_total.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            es_total.Location = new System.Drawing.Point(30, 384);
            es_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            es_total.Name = "es_total";
            es_total.Size = new System.Drawing.Size(99, 32);
            es_total.TabIndex = 10;
            es_total.Text = "총 가격:";
            // 
            // es_total_value
            // 
            es_total_value.AutoSize = true;
            es_total_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            es_total_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            es_total_value.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            es_total_value.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            es_total_value.Location = new System.Drawing.Point(141, 384);
            es_total_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            es_total_value.Name = "es_total_value";
            es_total_value.Size = new System.Drawing.Size(26, 33);
            es_total_value.TabIndex = 9;
            es_total_value.Text = "-";
            // 
            // Espresso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 588);
            Controls.Add(es_panel);
            Name = "Espresso";
            Text = "Espresso";
            es_panel.ResumeLayout(false);
            es_panel.PerformLayout();
            la_coldhot.ResumeLayout(false);
            la_coldhot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            es_option.ResumeLayout(false);
            es_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)es_amount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel es_panel;
        private System.Windows.Forms.GroupBox la_coldhot;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label es_value;
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
    }
}