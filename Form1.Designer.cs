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
            ad_box = new System.Windows.Forms.PictureBox();
            ad_images = new System.Windows.Forms.ImageList(components);
            pay_button = new System.Windows.Forms.Button();
            order_list = new System.Windows.Forms.ListView();
            menu = new System.Windows.Forms.ColumnHeader();
            amount = new System.Windows.Forms.ColumnHeader();
            price = new System.Windows.Forms.ColumnHeader();
            cancel_button = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            custom_pay_button = new System.Windows.Forms.Button();
            base_button = new System.Windows.Forms.ComboBox();
            coffee_box = new System.Windows.Forms.ComboBox();
            toping_box = new System.Windows.Forms.ComboBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ad_box).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cascadia Code", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(0, 8);
            label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            label1.Size = new System.Drawing.Size(452, 51);
            label1.TabIndex = 1;
            label1.Text = "MOBLE CAFE";
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
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1178, 67);
            panel1.TabIndex = 5;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.MediumTurquoise;
            button10.BackgroundImage = (System.Drawing.Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button10.Cursor = System.Windows.Forms.Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Location = new System.Drawing.Point(1132, 25);
            button10.Margin = new System.Windows.Forms.Padding(2);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(23, 22);
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
            button9.Location = new System.Drawing.Point(1097, 25);
            button9.Margin = new System.Windows.Forms.Padding(2);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(23, 22);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            // 
            // time_value
            // 
            time_value.AutoSize = true;
            time_value.BackColor = System.Drawing.Color.Transparent;
            time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            time_value.ForeColor = System.Drawing.Color.Transparent;
            time_value.Location = new System.Drawing.Point(580, 19);
            time_value.Name = "time_value";
            time_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            time_value.Size = new System.Drawing.Size(24, 31);
            time_value.TabIndex = 2;
            time_value.Text = "-";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.BackColor = System.Drawing.Color.Transparent;
            label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_time.ForeColor = System.Drawing.Color.Transparent;
            label_time.Location = new System.Drawing.Point(452, 19);
            label_time.Name = "label_time";
            label_time.Size = new System.Drawing.Size(106, 31);
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
            Main_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Main_info.Location = new System.Drawing.Point(59, 60);
            Main_info.Name = "Main_info";
            Main_info.Size = new System.Drawing.Size(126, 29);
            Main_info.TabIndex = 0;
            Main_info.Text = "Main_info";
            Main_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Main_info.Click += Main_info_Click;
            // 
            // Choose_No
            // 
            Choose_No.BackColor = System.Drawing.Color.White;
            Choose_No.Cursor = System.Windows.Forms.Cursors.Hand;
            Choose_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Choose_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_No.Location = new System.Drawing.Point(155, 232);
            Choose_No.Name = "Choose_No";
            Choose_No.Size = new System.Drawing.Size(85, 34);
            Choose_No.TabIndex = 8;
            Choose_No.Text = "아니요";
            Choose_No.UseVisualStyleBackColor = false;
            Choose_No.Click += Choose_No_Click;
            // 
            // Choose_Yes
            // 
            Choose_Yes.BackColor = System.Drawing.Color.White;
            Choose_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            Choose_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Choose_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Choose_Yes.Location = new System.Drawing.Point(37, 232);
            Choose_Yes.Name = "Choose_Yes";
            Choose_Yes.Size = new System.Drawing.Size(85, 34);
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
            coffee_menu.Images.SetKeyName(1, "Latte.png");
            coffee_menu.Images.SetKeyName(2, "cappuccino.png");
            coffee_menu.Images.SetKeyName(3, "espresso.png");
            coffee_menu.Images.SetKeyName(4, "soylattepng.png");
            coffee_menu.Images.SetKeyName(5, "mocha.png");
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(Choose_No);
            panel2.Controls.Add(Choose_Yes);
            panel2.Controls.Add(Main_info);
            panel2.Location = new System.Drawing.Point(839, 97);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(283, 302);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.White;
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button6.ImageIndex = 4;
            button6.ImageList = coffee_menu;
            button6.Location = new System.Drawing.Point(303, 153);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(290, 140);
            button6.TabIndex = 2;
            button6.Text = "돌체라떼     ";
            button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.White;
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.ImageIndex = 5;
            button5.ImageList = coffee_menu;
            button5.Location = new System.Drawing.Point(599, 153);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(290, 140);
            button5.TabIndex = 2;
            button5.Text = "카페모카     ";
            button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.ImageIndex = 2;
            button3.ImageList = coffee_menu;
            button3.Location = new System.Drawing.Point(599, 6);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(290, 140);
            button3.TabIndex = 2;
            button3.Text = "카푸치노    ";
            button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.White;
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.ImageList = coffee_menu;
            button4.Location = new System.Drawing.Point(6, 153);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(290, 140);
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
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.ImageIndex = 0;
            button1.ImageList = coffee_menu;
            button1.Location = new System.Drawing.Point(6, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(290, 140);
            button1.TabIndex = 2;
            button1.Text = "아메리카노    ";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.ImageList = coffee_menu;
            button2.Location = new System.Drawing.Point(303, 6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(290, 140);
            button2.TabIndex = 2;
            button2.Text = "카페라떼      ";
            button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ad_box
            // 
            ad_box.Location = new System.Drawing.Point(839, 422);
            ad_box.Margin = new System.Windows.Forms.Padding(2);
            ad_box.Name = "ad_box";
            ad_box.Size = new System.Drawing.Size(283, 171);
            ad_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ad_box.TabIndex = 11;
            ad_box.TabStop = false;
            // 
            // ad_images
            // 
            ad_images.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ad_images.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ad_images.ImageStream");
            ad_images.TransparentColor = System.Drawing.Color.Transparent;
            ad_images.Images.SetKeyName(0, "ad1.png");
            ad_images.Images.SetKeyName(1, "ad2.png");
            // 
            // pay_button
            // 
            pay_button.BackColor = System.Drawing.Color.White;
            pay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            pay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pay_button.Location = new System.Drawing.Point(681, 440);
            pay_button.Margin = new System.Windows.Forms.Padding(2);
            pay_button.Name = "pay_button";
            pay_button.Size = new System.Drawing.Size(134, 62);
            pay_button.TabIndex = 12;
            pay_button.Text = "결제하기";
            pay_button.UseVisualStyleBackColor = false;
            pay_button.Click += pay_button_Click;
            // 
            // order_list
            // 
            order_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { menu, amount, price });
            order_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            order_list.FullRowSelect = true;
            order_list.HideSelection = false;
            order_list.Location = new System.Drawing.Point(34, 430);
            order_list.Margin = new System.Windows.Forms.Padding(2);
            order_list.Name = "order_list";
            order_list.Size = new System.Drawing.Size(622, 163);
            order_list.TabIndex = 13;
            order_list.UseCompatibleStateImageBehavior = false;
            // 
            // menu
            // 
            menu.Text = "메뉴";
            menu.Width = 241;
            // 
            // amount
            // 
            amount.Text = "개수";
            amount.Width = 190;
            // 
            // price
            // 
            price.Text = "가격";
            price.Width = 190;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = System.Drawing.Color.White;
            cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cancel_button.Location = new System.Drawing.Point(681, 523);
            cancel_button.Margin = new System.Windows.Forms.Padding(2);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new System.Drawing.Size(134, 62);
            cancel_button.TabIndex = 12;
            cancel_button.Text = "취소하기";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(16, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new System.Drawing.Size(799, 347);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button5);
            tabPage1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tabPage1.Location = new System.Drawing.Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(791, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "간편 주문";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(custom_pay_button);
            tabPage2.Controls.Add(base_button);
            tabPage2.Controls.Add(coffee_box);
            tabPage2.Controls.Add(toping_box);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tabPage2.Location = new System.Drawing.Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(791, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "커스텀 주문";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(361, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 25);
            label4.TabIndex = 2;
            label4.Text = "토핑 선택";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(361, 122);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "커피 선택";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(373, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "베이스";
            // 
            // custom_pay_button
            // 
            custom_pay_button.BackColor = System.Drawing.Color.White;
            custom_pay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            custom_pay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            custom_pay_button.Location = new System.Drawing.Point(600, 128);
            custom_pay_button.Margin = new System.Windows.Forms.Padding(2);
            custom_pay_button.Name = "custom_pay_button";
            custom_pay_button.Size = new System.Drawing.Size(147, 72);
            custom_pay_button.TabIndex = 12;
            custom_pay_button.Text = "주문하기";
            custom_pay_button.UseVisualStyleBackColor = false;
            custom_pay_button.Click += custom_pay_button_Click;
            // 
            // base_button
            // 
            base_button.FormattingEnabled = true;
            base_button.Items.AddRange(new object[] { "따듯한 물", "차가운 물", "따듯한 우유", "차가운 우유" });
            base_button.Location = new System.Drawing.Point(300, 234);
            base_button.Name = "base_button";
            base_button.Size = new System.Drawing.Size(217, 31);
            base_button.TabIndex = 1;
            // 
            // coffee_box
            // 
            coffee_box.FormattingEnabled = true;
            coffee_box.Items.AddRange(new object[] { "기본 샷", "더블 샷", "기본샷 + 우유 거품" });
            coffee_box.Location = new System.Drawing.Point(300, 149);
            coffee_box.Name = "coffee_box";
            coffee_box.Size = new System.Drawing.Size(217, 31);
            coffee_box.TabIndex = 1;
            // 
            // toping_box
            // 
            toping_box.FormattingEnabled = true;
            toping_box.Items.AddRange(new object[] { "토피넛 가루", "휘핑 크림", "계피 가루", "카카오 가루", "없음" });
            toping_box.Location = new System.Drawing.Point(300, 67);
            toping_box.Name = "toping_box";
            toping_box.Size = new System.Drawing.Size(217, 31);
            toping_box.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(96, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(150, 145);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(24, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(291, 266);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(1178, 624);
            Controls.Add(tabControl1);
            Controls.Add(order_list);
            Controls.Add(cancel_button);
            Controls.Add(pay_button);
            Controls.Add(ad_box);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome to the Coffee Shop";
            Load += Form1_Load;
            Click += Form1_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ad_box).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox ad_box;
        private System.Windows.Forms.ImageList ad_images;
        private System.Windows.Forms.Button pay_button;
        public System.Windows.Forms.ListView order_list;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button custom_pay_button;
        public System.Windows.Forms.ComboBox base_button;
        public System.Windows.Forms.ComboBox coffee_box;
        public System.Windows.Forms.ComboBox toping_box;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
