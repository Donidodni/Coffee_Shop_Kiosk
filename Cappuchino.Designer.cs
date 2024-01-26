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
            cap_amount = new System.Windows.Forms.NumericUpDown();
            am_option = new System.Windows.Forms.GroupBox();
            cap_option3 = new System.Windows.Forms.RadioButton();
            cap_option2 = new System.Windows.Forms.RadioButton();
            cap_option1 = new System.Windows.Forms.RadioButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cap_numeric = new System.Windows.Forms.ComboBox();
            am_coldhot = new System.Windows.Forms.GroupBox();
            cap_hot = new System.Windows.Forms.RadioButton();
            cap_cold = new System.Windows.Forms.RadioButton();
            button3_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)cap_amount).BeginInit();
            am_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            am_coldhot.SuspendLayout();
            SuspendLayout();
            // 
            // cap_amount
            // 
            cap_amount.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_amount.Location = new System.Drawing.Point(173, 166);
            cap_amount.Name = "cap_amount";
            cap_amount.Size = new System.Drawing.Size(154, 27);
            cap_amount.TabIndex = 11;
            cap_amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // am_option
            // 
            am_option.Controls.Add(cap_option3);
            am_option.Controls.Add(cap_option2);
            am_option.Controls.Add(cap_option1);
            am_option.Location = new System.Drawing.Point(35, 196);
            am_option.Name = "am_option";
            am_option.Size = new System.Drawing.Size(281, 62);
            am_option.TabIndex = 9;
            am_option.TabStop = false;
            // 
            // cap_option3
            // 
            cap_option3.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option3.AutoSize = true;
            cap_option3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option3.Location = new System.Drawing.Point(195, 17);
            cap_option3.Name = "cap_option3";
            cap_option3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            cap_option3.Size = new System.Drawing.Size(78, 36);
            cap_option3.TabIndex = 2;
            cap_option3.TabStop = true;
            cap_option3.Text = "텀블러";
            cap_option3.UseVisualStyleBackColor = true;
            // 
            // cap_option2
            // 
            cap_option2.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option2.AutoSize = true;
            cap_option2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option2.Location = new System.Drawing.Point(106, 17);
            cap_option2.Name = "cap_option2";
            cap_option2.Padding = new System.Windows.Forms.Padding(3);
            cap_option2.Size = new System.Drawing.Size(85, 36);
            cap_option2.TabIndex = 1;
            cap_option2.TabStop = true;
            cap_option2.Text = "매장용컵";
            cap_option2.UseVisualStyleBackColor = true;
            // 
            // cap_option1
            // 
            cap_option1.Appearance = System.Windows.Forms.Appearance.Button;
            cap_option1.AutoSize = true;
            cap_option1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_option1.Location = new System.Drawing.Point(17, 17);
            cap_option1.Name = "cap_option1";
            cap_option1.Padding = new System.Windows.Forms.Padding(3);
            cap_option1.Size = new System.Drawing.Size(85, 36);
            cap_option1.TabIndex = 0;
            cap_option1.TabStop = true;
            cap_option1.Text = "일회용기";
            cap_option1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(25, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(142, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cap_numeric
            // 
            cap_numeric.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_numeric.FormattingEnabled = true;
            cap_numeric.Items.AddRange(new object[] { "작은컵", "중간컵", "큰컵" });
            cap_numeric.Location = new System.Drawing.Point(173, 130);
            cap_numeric.Name = "cap_numeric";
            cap_numeric.Size = new System.Drawing.Size(154, 28);
            cap_numeric.TabIndex = 8;
            cap_numeric.Text = "사이즈를 고르세요.";
            // 
            // am_coldhot
            // 
            am_coldhot.Controls.Add(cap_hot);
            am_coldhot.Controls.Add(cap_cold);
            am_coldhot.Location = new System.Drawing.Point(173, 18);
            am_coldhot.Name = "am_coldhot";
            am_coldhot.Size = new System.Drawing.Size(154, 107);
            am_coldhot.TabIndex = 7;
            am_coldhot.TabStop = false;
            // 
            // cap_hot
            // 
            cap_hot.Appearance = System.Windows.Forms.Appearance.Button;
            cap_hot.AutoSize = true;
            cap_hot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_hot.Location = new System.Drawing.Point(19, 62);
            cap_hot.Name = "cap_hot";
            cap_hot.Size = new System.Drawing.Size(111, 31);
            cap_hot.TabIndex = 1;
            cap_hot.TabStop = true;
            cap_hot.Text = "아이스(ICED)";
            cap_hot.UseVisualStyleBackColor = true;
            // 
            // cap_cold
            // 
            cap_cold.Appearance = System.Windows.Forms.Appearance.Button;
            cap_cold.AutoSize = true;
            cap_cold.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cap_cold.Location = new System.Drawing.Point(19, 26);
            cap_cold.Name = "cap_cold";
            cap_cold.Padding = new System.Windows.Forms.Padding(0, 0, 32, 0);
            cap_cold.Size = new System.Drawing.Size(111, 31);
            cap_cold.TabIndex = 0;
            cap_cold.TabStop = true;
            cap_cold.Text = "핫(HOT)";
            cap_cold.UseVisualStyleBackColor = true;
            // 
            // button3_value
            // 
            button3_value.AutoSize = true;
            button3_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button3_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3_value.Location = new System.Drawing.Point(25, 167);
            button3_value.Name = "button3_value";
            button3_value.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            button3_value.Size = new System.Drawing.Size(144, 25);
            button3_value.TabIndex = 12;
            button3_value.Text = "카푸치노";
            // 
            // Cappuchino
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(356, 561);
            Controls.Add(button3_value);
            Controls.Add(cap_amount);
            Controls.Add(am_option);
            Controls.Add(pictureBox1);
            Controls.Add(cap_numeric);
            Controls.Add(am_coldhot);
            Name = "Cappuchino";
            Text = "Cappuchino";
            ((System.ComponentModel.ISupportInitialize)cap_amount).EndInit();
            am_option.ResumeLayout(false);
            am_option.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            am_coldhot.ResumeLayout(false);
            am_coldhot.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown cap_amount;
        private System.Windows.Forms.GroupBox am_option;
        private System.Windows.Forms.RadioButton cap_option3;
        private System.Windows.Forms.RadioButton cap_option2;
        private System.Windows.Forms.RadioButton cap_option1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ComboBox cap_numeric;
        private System.Windows.Forms.GroupBox am_coldhot;
        private System.Windows.Forms.RadioButton cap_hot;
        private System.Windows.Forms.RadioButton cap_cold;
        private System.Windows.Forms.Label button3_value;
    }
}