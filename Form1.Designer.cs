namespace Coffee_Shop_Kiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            time_value = new System.Windows.Forms.Label();
            label_time = new System.Windows.Forms.Label();
            Current_time = new System.Windows.Forms.Timer(components);
            Main_info = new System.Windows.Forms.Label();
            Choose_No = new System.Windows.Forms.Button();
            Choose_Yes = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            coffee_menu = new System.Windows.Forms.ImageList(components);
            button3 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1_value = new System.Windows.Forms.Label();
            button2_value = new System.Windows.Forms.Label();
            button4_value = new System.Windows.Forms.Label();
            button3_value = new System.Windows.Forms.Label();
            button5_value = new System.Windows.Forms.Label();
            button6_value = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 17);
            label1.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(129, 0, 129, 0);
            label1.Size = new System.Drawing.Size(503, 59);
            label1.TabIndex = 1;
            label1.Text = "MOBLE CAFE";
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(491, 1113);
            button7.Margin = new System.Windows.Forms.Padding(4);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(195, 63);
            button7.TabIndex = 3;
            button7.Text = "결제하기";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button8.Location = new System.Drawing.Point(694, 1113);
            button8.Margin = new System.Windows.Forms.Padding(4);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(195, 63);
            button8.TabIndex = 3;
            button8.Text = "취소하기";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(time_value);
            panel1.Controls.Add(label_time);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(15, 23);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(874, 89);
            panel1.TabIndex = 5;
            // 
            // time_value
            // 
            time_value.AutoSize = true;
            time_value.BackColor = System.Drawing.SystemColors.ActiveCaption;
            time_value.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            time_value.Location = new System.Drawing.Point(627, 49);
            time_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            time_value.Name = "time_value";
            time_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            time_value.Size = new System.Drawing.Size(20, 28);
            time_value.TabIndex = 2;
            time_value.Text = "-";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_time.Location = new System.Drawing.Point(692, 17);
            label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_time.Name = "label_time";
            label_time.Size = new System.Drawing.Size(99, 28);
            label_time.TabIndex = 2;
            label_time.Text = "현재 시간";
            // 
            // Current_time
            // 
            Current_time.Tick += Current_time_Tick;
            // 
            // Main_info
            // 
            Main_info.AutoSize = true;
            Main_info.BackColor = System.Drawing.SystemColors.ButtonFace;
            Main_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Main_info.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Main_info.Location = new System.Drawing.Point(210, 29);
            Main_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Main_info.Name = "Main_info";
            Main_info.Size = new System.Drawing.Size(127, 37);
            Main_info.TabIndex = 0;
            Main_info.Text = "Main_info";
            Main_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Main_info.Click += Main_info_Click;
            // 
            // Choose_No
            // 
            Choose_No.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_No.Location = new System.Drawing.Point(635, 27);
            Choose_No.Margin = new System.Windows.Forms.Padding(4);
            Choose_No.Name = "Choose_No";
            Choose_No.Size = new System.Drawing.Size(109, 45);
            Choose_No.TabIndex = 8;
            Choose_No.Text = "아니요";
            Choose_No.UseVisualStyleBackColor = true;
            Choose_No.Click += Choose_No_Click;
            // 
            // Choose_Yes
            // 
            Choose_Yes.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_Yes.Location = new System.Drawing.Point(516, 27);
            Choose_Yes.Margin = new System.Windows.Forms.Padding(4);
            Choose_Yes.Name = "Choose_Yes";
            Choose_Yes.Size = new System.Drawing.Size(109, 45);
            Choose_Yes.TabIndex = 8;
            Choose_Yes.Text = "네";
            Choose_Yes.UseVisualStyleBackColor = true;
            Choose_Yes.Click += Choose_Yes_Click;
            // 
            // button4
            // 
            button4.ImageIndex = 2;
            button4.ImageList = coffee_menu;
            button4.Location = new System.Drawing.Point(112, 288);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(193, 200);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // coffee_menu
            // 
            coffee_menu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            coffee_menu.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("coffee_menu.ImageStream");
            coffee_menu.TransparentColor = System.Drawing.Color.Transparent;
            coffee_menu.Images.SetKeyName(0, "americano.png");
            coffee_menu.Images.SetKeyName(1, "cappuccino.png");
            coffee_menu.Images.SetKeyName(2, "espresso.png");
            coffee_menu.Images.SetKeyName(3, "latte.png");
            coffee_menu.Images.SetKeyName(4, "mocha.png");
            coffee_menu.Images.SetKeyName(5, "soylattepng.png");
            // 
            // button3
            // 
            button3.ImageIndex = 1;
            button3.ImageList = coffee_menu;
            button3.Location = new System.Drawing.Point(546, 40);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(193, 200);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.ImageIndex = 4;
            button5.ImageList = coffee_menu;
            button5.Location = new System.Drawing.Point(546, 288);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(193, 200);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ImageIndex = 5;
            button6.ImageList = coffee_menu;
            button6.Location = new System.Drawing.Point(333, 288);
            button6.Margin = new System.Windows.Forms.Padding(4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(193, 200);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.ImageIndex = 0;
            button1.ImageList = coffee_menu;
            button1.Location = new System.Drawing.Point(112, 40);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(193, 200);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ImageIndex = 3;
            button2.ImageList = coffee_menu;
            button2.Location = new System.Drawing.Point(333, 40);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(193, 200);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1_value
            // 
            button1_value.AutoSize = true;
            button1_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button1_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1_value.Location = new System.Drawing.Point(130, 244);
            button1_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            button1_value.Name = "button1_value";
            button1_value.Padding = new System.Windows.Forms.Padding(26, 0, 26, 0);
            button1_value.Size = new System.Drawing.Size(160, 29);
            button1_value.TabIndex = 3;
            button1_value.Text = "아메리카노";
            // 
            // button2_value
            // 
            button2_value.AutoSize = true;
            button2_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button2_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2_value.Location = new System.Drawing.Point(336, 244);
            button2_value.Margin = new System.Windows.Forms.Padding(0);
            button2_value.Name = "button2_value";
            button2_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            button2_value.Size = new System.Drawing.Size(167, 29);
            button2_value.TabIndex = 3;
            button2_value.Text = "카페라떼";
            // 
            // button4_value
            // 
            button4_value.AutoSize = true;
            button4_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button4_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4_value.Location = new System.Drawing.Point(118, 492);
            button4_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            button4_value.Name = "button4_value";
            button4_value.Padding = new System.Windows.Forms.Padding(26, 0, 26, 0);
            button4_value.Size = new System.Drawing.Size(160, 29);
            button4_value.TabIndex = 3;
            button4_value.Text = "에스프레소";
            // 
            // button3_value
            // 
            button3_value.AutoSize = true;
            button3_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button3_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3_value.Location = new System.Drawing.Point(550, 244);
            button3_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            button3_value.Name = "button3_value";
            button3_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            button3_value.Size = new System.Drawing.Size(167, 29);
            button3_value.TabIndex = 3;
            button3_value.Text = "카푸치노";
            // 
            // button5_value
            // 
            button5_value.AutoSize = true;
            button5_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button5_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5_value.Location = new System.Drawing.Point(336, 492);
            button5_value.Margin = new System.Windows.Forms.Padding(0);
            button5_value.Name = "button5_value";
            button5_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            button5_value.Size = new System.Drawing.Size(167, 29);
            button5_value.TabIndex = 3;
            button5_value.Text = "연유라떼";
            // 
            // button6_value
            // 
            button6_value.AutoSize = true;
            button6_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button6_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6_value.Location = new System.Drawing.Point(549, 492);
            button6_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            button6_value.Name = "button6_value";
            button6_value.Padding = new System.Windows.Forms.Padding(39, 0, 39, 0);
            button6_value.Size = new System.Drawing.Size(167, 29);
            button6_value.TabIndex = 3;
            button6_value.Text = "모카치노";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel2.Controls.Add(Choose_No);
            panel2.Controls.Add(Choose_Yes);
            panel2.Controls.Add(Main_info);
            panel2.Location = new System.Drawing.Point(15, 697);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(874, 101);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel3.Controls.Add(button6_value);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button5_value);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3_value);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4_value);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button2_value);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button1_value);
            panel3.Controls.Add(button1);
            panel3.Location = new System.Drawing.Point(15, 120);
            panel3.Margin = new System.Windows.Forms.Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(874, 560);
            panel3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(905, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button8);
            Controls.Add(button7);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome to the Coffee Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time_value;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer Current_time;
        private System.Windows.Forms.Label Main_info;
        private System.Windows.Forms.Button Choose_Yes;
        private System.Windows.Forms.Button Choose_No;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label button1_value;
        private System.Windows.Forms.Label button2_value;
        private System.Windows.Forms.Label button4_value;
        private System.Windows.Forms.Label button3_value;
        private System.Windows.Forms.Label button5_value;
        private System.Windows.Forms.Label button6_value;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList coffee_menu;
    }
}
