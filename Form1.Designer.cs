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
            button10 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            time_value = new System.Windows.Forms.Label();
            label_time = new System.Windows.Forms.Label();
            Current_time = new System.Windows.Forms.Timer(components);
            Main_info = new System.Windows.Forms.Label();
            Choose_No = new System.Windows.Forms.Button();
            Choose_Yes = new System.Windows.Forms.Button();
            coffee_menu = new System.Windows.Forms.ImageList(components);
            panel2 = new System.Windows.Forms.Panel();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(0, 14);
            label1.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(129, 0, 129, 0);
            label1.Size = new System.Drawing.Size(573, 57);
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
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(time_value);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_time);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1514, 89);
            panel1.TabIndex = 5;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.MediumTurquoise;
            button10.BackgroundImage = (System.Drawing.Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Location = new System.Drawing.Point(851, 29);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(30, 30);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.MediumTurquoise;
            button9.BackgroundImage = (System.Drawing.Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Location = new System.Drawing.Point(806, 29);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(30, 30);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            // 
            // time_value
            // 
            time_value.AutoSize = true;
            time_value.BackColor = System.Drawing.Color.Transparent;
            time_value.Font = new System.Drawing.Font("Pretendard SemiBold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            time_value.ForeColor = System.Drawing.Color.Transparent;
            time_value.Location = new System.Drawing.Point(1064, 24);
            time_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            time_value.Name = "time_value";
            time_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            time_value.Size = new System.Drawing.Size(33, 41);
            time_value.TabIndex = 2;
            time_value.Text = "-";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.BackColor = System.Drawing.Color.Transparent;
            label_time.Font = new System.Drawing.Font("Pretendard SemiBold", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_time.ForeColor = System.Drawing.Color.Transparent;
            label_time.Location = new System.Drawing.Point(899, 24);
            label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_time.Name = "label_time";
            label_time.Size = new System.Drawing.Size(142, 41);
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
            Main_info.BackColor = System.Drawing.Color.Transparent;
            Main_info.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Main_info.Location = new System.Drawing.Point(67, 80);
            Main_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Main_info.Name = "Main_info";
            Main_info.Size = new System.Drawing.Size(153, 36);
            Main_info.TabIndex = 0;
            Main_info.Text = "Main_info";
            Main_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Main_info.Click += Main_info_Click;
            // 
            // Choose_No
            // 
            Choose_No.BackColor = System.Drawing.Color.White;
            Choose_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Choose_No.Font = new System.Drawing.Font("Pretendard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_No.Location = new System.Drawing.Point(199, 309);
            Choose_No.Margin = new System.Windows.Forms.Padding(4);
            Choose_No.Name = "Choose_No";
            Choose_No.Size = new System.Drawing.Size(109, 45);
            Choose_No.TabIndex = 8;
            Choose_No.Text = "아니요";
            Choose_No.UseVisualStyleBackColor = false;
            Choose_No.Click += Choose_No_Click;
            // 
            // Choose_Yes
            // 
            Choose_Yes.BackColor = System.Drawing.Color.White;
            Choose_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Choose_Yes.Font = new System.Drawing.Font("Pretendard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_Yes.Location = new System.Drawing.Point(47, 309);
            Choose_Yes.Margin = new System.Windows.Forms.Padding(4);
            Choose_Yes.Name = "Choose_Yes";
            Choose_Yes.Size = new System.Drawing.Size(109, 45);
            Choose_Yes.TabIndex = 8;
            Choose_Yes.Text = "네";
            Choose_Yes.UseVisualStyleBackColor = false;
            Choose_Yes.Click += Choose_Yes_Click;
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(Choose_No);
            panel2.Controls.Add(Choose_Yes);
            panel2.Controls.Add(Main_info);
            panel2.Location = new System.Drawing.Point(1001, 129);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(364, 382);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button6.ImageIndex = 5;
            button6.ImageList = coffee_menu;
            button6.Location = new System.Drawing.Point(384, 210);
            button6.Margin = new System.Windows.Forms.Padding(4);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(373, 187);
            button6.TabIndex = 2;
            button6.Text = "돌체라떼     ";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.ImageIndex = 4;
            button5.ImageList = coffee_menu;
            button5.Location = new System.Drawing.Point(765, 210);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(373, 187);
            button5.TabIndex = 2;
            button5.Text = "카페모카     ";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.ImageIndex = 1;
            button3.ImageList = coffee_menu;
            button3.Location = new System.Drawing.Point(765, 15);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(373, 187);
            button3.TabIndex = 2;
            button3.Text = "카푸치노    ";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.ImageIndex = 2;
            button4.ImageList = coffee_menu;
            button4.Location = new System.Drawing.Point(3, 210);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(373, 187);
            button4.TabIndex = 2;
            button4.Text = "에스프레소   ";
            button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = coffee_menu;
            button1.Location = new System.Drawing.Point(3, 15);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(373, 187);
            button1.TabIndex = 2;
            button1.Text = "아메리카노    ";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Pretendard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.ImageIndex = 3;
            button2.ImageList = coffee_menu;
            button2.Location = new System.Drawing.Point(384, 15);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(373, 187);
            button2.TabIndex = 2;
            button2.Text = "카페라떼      ";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Location = new System.Drawing.Point(41, 114);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(943, 440);
            panel3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1514, 841);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button8);
            Controls.Add(button7);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome to the Coffee Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList coffee_menu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
    }
}
