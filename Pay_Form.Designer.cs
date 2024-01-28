namespace Coffee_Shop_Kiosk
{
    partial class Pay_Form
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
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            final_order_list = new System.Windows.Forms.ListView();
            menu = new System.Windows.Forms.ColumnHeader();
            amount = new System.Windows.Forms.ColumnHeader();
            price = new System.Windows.Forms.ColumnHeader();
            pay_yes = new System.Windows.Forms.Button();
            pay_cancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            final_order_value = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Pretendard SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(21, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 33);
            label1.TabIndex = 9;
            label1.Text = "결재하기";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(732, 64);
            panel1.TabIndex = 9;
            // 
            // final_order_list
            // 
            final_order_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { menu, amount, price });
            final_order_list.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            final_order_list.HideSelection = false;
            final_order_list.Location = new System.Drawing.Point(74, 114);
            final_order_list.Name = "final_order_list";
            final_order_list.Size = new System.Drawing.Size(561, 337);
            final_order_list.TabIndex = 14;
            final_order_list.UseCompatibleStateImageBehavior = false;
            // 
            // menu
            // 
            menu.Text = "메뉴";
            menu.Width = 227;
            // 
            // amount
            // 
            amount.Text = "개수";
            amount.Width = 167;
            // 
            // price
            // 
            price.Text = "가격";
            price.Width = 167;
            // 
            // pay_yes
            // 
            pay_yes.BackColor = System.Drawing.Color.White;
            pay_yes.FlatAppearance.BorderSize = 0;
            pay_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            pay_yes.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pay_yes.Location = new System.Drawing.Point(141, 531);
            pay_yes.Name = "pay_yes";
            pay_yes.Size = new System.Drawing.Size(193, 66);
            pay_yes.TabIndex = 15;
            pay_yes.TabStop = false;
            pay_yes.Text = "결제하기";
            pay_yes.UseVisualStyleBackColor = false;
            pay_yes.Click += pay_yes_Click;
            // 
            // pay_cancel
            // 
            pay_cancel.BackColor = System.Drawing.Color.White;
            pay_cancel.FlatAppearance.BorderSize = 0;
            pay_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            pay_cancel.Font = new System.Drawing.Font("Pretendard SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            pay_cancel.Location = new System.Drawing.Point(387, 531);
            pay_cancel.Name = "pay_cancel";
            pay_cancel.Size = new System.Drawing.Size(193, 66);
            pay_cancel.TabIndex = 15;
            pay_cancel.Text = "취소하기";
            pay_cancel.UseVisualStyleBackColor = false;
            pay_cancel.Click += pay_cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Pretendard SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(178, 480);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 32);
            label2.TabIndex = 16;
            label2.Text = "총 결제가격 :";
            // 
            // final_order_value
            // 
            final_order_value.AutoSize = true;
            final_order_value.Font = new System.Drawing.Font("Pretendard SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            final_order_value.Location = new System.Drawing.Point(361, 480);
            final_order_value.Name = "final_order_value";
            final_order_value.Size = new System.Drawing.Size(90, 32);
            final_order_value.TabIndex = 16;
            final_order_value.Text = "label2";
            // 
            // Pay_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(732, 652);
            Controls.Add(final_order_value);
            Controls.Add(label2);
            Controls.Add(pay_cancel);
            Controls.Add(pay_yes);
            Controls.Add(final_order_list);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Pay_Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Pay_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView final_order_list;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button pay_yes;
        private System.Windows.Forms.Button pay_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label final_order_value;
    }
}