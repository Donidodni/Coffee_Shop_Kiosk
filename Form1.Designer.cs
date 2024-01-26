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
            button1 = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button6_value = new System.Windows.Forms.Label();
            button5_value = new System.Windows.Forms.Label();
            button3_value = new System.Windows.Forms.Label();
            button4_value = new System.Windows.Forms.Label();
            button2_value = new System.Windows.Forms.Label();
            button1_value = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            time_value = new System.Windows.Forms.Label();
            label_time = new System.Windows.Forms.Label();
            Current_time = new System.Windows.Forms.Timer(components);
            Main_info = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            Choose_No = new System.Windows.Forms.Button();
            Choose_Yes = new System.Windows.Forms.Button();
            Order_list = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 13);
            label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            label1.Size = new System.Drawing.Size(392, 45);
            label1.TabIndex = 1;
            label1.Text = "MOBLE CAFE";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new System.Drawing.Point(84, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 150);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Americano.png");
            imageList1.Images.SetKeyName(1, "Cappuchino.png");
            imageList1.Images.SetKeyName(2, "Coffee1.png");
            imageList1.Images.SetKeyName(3, "Espresso.png");
            imageList1.Images.SetKeyName(4, "Latte.png");
            imageList1.Images.SetKeyName(5, "Mocha.png");
            // 
            // button2
            // 
            button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.ImageIndex = 1;
            button2.ImageList = imageList1;
            button2.Location = new System.Drawing.Point(256, 32);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 150);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageIndex = 4;
            button3.ImageList = imageList1;
            button3.Location = new System.Drawing.Point(422, 32);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 150);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new System.Drawing.Point(84, 218);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 150);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ImageIndex = 5;
            button5.ImageList = imageList1;
            button5.Location = new System.Drawing.Point(422, 218);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(150, 150);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ImageIndex = 2;
            button6.ImageList = imageList1;
            button6.Location = new System.Drawing.Point(256, 218);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(150, 150);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(382, 835);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(152, 47);
            button7.TabIndex = 3;
            button7.Text = "결제하기";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button8.Location = new System.Drawing.Point(540, 835);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(152, 47);
            button8.TabIndex = 3;
            button8.Text = "취소하기";
            button8.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            groupBox1.Controls.Add(button6_value);
            groupBox1.Controls.Add(button5_value);
            groupBox1.Controls.Add(button3_value);
            groupBox1.Controls.Add(button4_value);
            groupBox1.Controls.Add(button2_value);
            groupBox1.Controls.Add(button1_value);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new System.Drawing.Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(680, 420);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button6_value
            // 
            button6_value.AutoSize = true;
            button6_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button6_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6_value.Location = new System.Drawing.Point(424, 371);
            button6_value.Name = "button6_value";
            button6_value.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            button6_value.Size = new System.Drawing.Size(144, 25);
            button6_value.TabIndex = 3;
            button6_value.Text = "모카치노";
            // 
            // button5_value
            // 
            button5_value.AutoSize = true;
            button5_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button5_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5_value.Location = new System.Drawing.Point(258, 371);
            button5_value.Margin = new System.Windows.Forms.Padding(0);
            button5_value.Name = "button5_value";
            button5_value.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            button5_value.Size = new System.Drawing.Size(144, 25);
            button5_value.TabIndex = 3;
            button5_value.Text = "연유라떼";
            // 
            // button3_value
            // 
            button3_value.AutoSize = true;
            button3_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button3_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3_value.Location = new System.Drawing.Point(425, 185);
            button3_value.Name = "button3_value";
            button3_value.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            button3_value.Size = new System.Drawing.Size(144, 25);
            button3_value.TabIndex = 3;
            button3_value.Text = "카푸치노";
            // 
            // button4_value
            // 
            button4_value.AutoSize = true;
            button4_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button4_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4_value.Location = new System.Drawing.Point(89, 371);
            button4_value.Name = "button4_value";
            button4_value.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            button4_value.Size = new System.Drawing.Size(142, 25);
            button4_value.TabIndex = 3;
            button4_value.Text = "에스프레소";
            // 
            // button2_value
            // 
            button2_value.AutoSize = true;
            button2_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button2_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2_value.Location = new System.Drawing.Point(258, 185);
            button2_value.Margin = new System.Windows.Forms.Padding(0);
            button2_value.Name = "button2_value";
            button2_value.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            button2_value.Size = new System.Drawing.Size(144, 25);
            button2_value.TabIndex = 3;
            button2_value.Text = "카페라떼";
            // 
            // button1_value
            // 
            button1_value.AutoSize = true;
            button1_value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button1_value.Font = new System.Drawing.Font("한컴산뜻돋움", 14.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1_value.Location = new System.Drawing.Point(88, 185);
            button1_value.Name = "button1_value";
            button1_value.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            button1_value.Size = new System.Drawing.Size(142, 25);
            button1_value.TabIndex = 3;
            button1_value.Text = "아메리카노";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(time_value);
            panel1.Controls.Add(label_time);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(680, 67);
            panel1.TabIndex = 5;
            // 
            // time_value
            // 
            time_value.AutoSize = true;
            time_value.BackColor = System.Drawing.SystemColors.ActiveCaption;
            time_value.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            time_value.Location = new System.Drawing.Point(488, 37);
            time_value.Name = "time_value";
            time_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            time_value.Size = new System.Drawing.Size(17, 21);
            time_value.TabIndex = 2;
            time_value.Text = "-";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_time.Location = new System.Drawing.Point(538, 13);
            label_time.Name = "label_time";
            label_time.Size = new System.Drawing.Size(19, 21);
            label_time.TabIndex = 2;
            label_time.Text = "1";
            // 
            // Current_time
            // 
            Current_time.Tick += Current_time_Tick;
            // 
            // Main_info
            // 
            Main_info.AutoSize = true;
            Main_info.BackColor = System.Drawing.SystemColors.ButtonFace;
            Main_info.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Main_info.Location = new System.Drawing.Point(181, 26);
            Main_info.Name = "Main_info";
            Main_info.Size = new System.Drawing.Size(101, 28);
            Main_info.TabIndex = 0;
            Main_info.Text = "Main_info";
            Main_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            groupBox2.Controls.Add(Choose_No);
            groupBox2.Controls.Add(Choose_Yes);
            groupBox2.Controls.Add(Main_info);
            groupBox2.Location = new System.Drawing.Point(12, 516);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(680, 76);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // Choose_No
            // 
            Choose_No.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_No.Location = new System.Drawing.Point(502, 24);
            Choose_No.Name = "Choose_No";
            Choose_No.Size = new System.Drawing.Size(85, 34);
            Choose_No.TabIndex = 8;
            Choose_No.Text = "아니요";
            Choose_No.UseVisualStyleBackColor = true;
            Choose_No.Click += Choose_No_Click;
            // 
            // Choose_Yes
            // 
            Choose_Yes.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_Yes.Location = new System.Drawing.Point(409, 24);
            Choose_Yes.Name = "Choose_Yes";
            Choose_Yes.Size = new System.Drawing.Size(85, 34);
            Choose_Yes.TabIndex = 8;
            Choose_Yes.Text = "네";
            Choose_Yes.UseVisualStyleBackColor = true;
            Choose_Yes.Click += Choose_Yes_Click;
            // 
            // Order_list
            // 
            Order_list.Location = new System.Drawing.Point(12, 628);
            Order_list.Name = "Order_list";
            Order_list.Size = new System.Drawing.Size(680, 201);
            Order_list.TabIndex = 8;
            Order_list.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(704, 961);
            Controls.Add(Order_list);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Form1";
            Text = "Welcome to the Coffee Shop";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label button6_value;
        private System.Windows.Forms.Label button5_value;
        private System.Windows.Forms.Label button3_value;
        private System.Windows.Forms.Label button4_value;
        private System.Windows.Forms.Label button2_value;
        private System.Windows.Forms.Label button1_value;
        private System.Windows.Forms.Label time_value;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer Current_time;
        private System.Windows.Forms.Label Main_info;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Choose_Yes;
        private System.Windows.Forms.Button Choose_No;
        private System.Windows.Forms.GroupBox Order_list;
    }
}
