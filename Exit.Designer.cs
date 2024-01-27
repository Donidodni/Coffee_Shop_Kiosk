namespace Coffee_Shop_Kiosk
{
    partial class Exit
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
            label2 = new System.Windows.Forms.Label();
            exit_no = new System.Windows.Forms.Button();
            exit_yes = new System.Windows.Forms.Button();
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
            label1.Text = "종료하기";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(414, 64);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Pretendard SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(93, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(222, 33);
            label2.TabIndex = 10;
            label2.Text = "종료하시겠습니까?";
            // 
            // exit_no
            // 
            exit_no.BackColor = System.Drawing.Color.White;
            exit_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exit_no.Font = new System.Drawing.Font("Pretendard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            exit_no.Location = new System.Drawing.Point(223, 180);
            exit_no.Margin = new System.Windows.Forms.Padding(4);
            exit_no.Name = "exit_no";
            exit_no.Size = new System.Drawing.Size(109, 45);
            exit_no.TabIndex = 11;
            exit_no.Text = "아니요";
            exit_no.UseVisualStyleBackColor = false;
            exit_no.Click += exit_no_Click;
            // 
            // exit_yes
            // 
            exit_yes.BackColor = System.Drawing.Color.White;
            exit_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exit_yes.Font = new System.Drawing.Font("Pretendard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            exit_yes.Location = new System.Drawing.Point(71, 180);
            exit_yes.Margin = new System.Windows.Forms.Padding(4);
            exit_yes.Name = "exit_yes";
            exit_yes.Size = new System.Drawing.Size(109, 45);
            exit_yes.TabIndex = 12;
            exit_yes.Text = "네";
            exit_yes.UseVisualStyleBackColor = false;
            exit_yes.Click += exit_yes_Click;
            // 
            // Exit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 261);
            Controls.Add(exit_no);
            Controls.Add(exit_yes);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Exit";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Exit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_no;
        private System.Windows.Forms.Button exit_yes;
    }
}