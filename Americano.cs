﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coffee_Shop_Kiosk
{
    public partial class Americano : Form
    {

        Form1? form = null;
        public Americano(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        
        int am_total_price = 4000;
        static int am_options , am_options_number,size, coldhot_am ;
        static int amount = 1;
        

        private void am_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (am_cold.Checked == true)
            {
                coldhot_am = 500;
                am_UpdatePrice();
            }
            else
            {
                coldhot_am = 0;
                am_UpdatePrice();
            }

        }

        private void am_hot_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void am_option1_CheckedChanged(object sender, EventArgs e)
        {
            am_options_number = 1;
            am_UpdatePrice();
        }

        private void am_option2_CheckedChanged(object sender, EventArgs e)
        {
            am_options_number = 2;
            am_UpdatePrice();
        }

        private void am_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (am_option3.Checked == true)
            {
                am_options_number = 3;
                am_options = 300;
            }
            else
                am_options = 0;
            am_UpdatePrice();
        }


        private void am_numeric_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (am_numeric.SelectedIndex == 0)
                size = 0;
            else if (am_numeric.SelectedIndex == 1)
                size = 500;
            else if (am_numeric.SelectedIndex == 2)
                size = 1000;
            am_UpdatePrice();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            amount = (int)numericUpDown1.Value;
            am_UpdatePrice();
        }


        
        public void am_UpdatePrice()
        {
            am_total_value.Text = Convert.ToString((am_total_price - am_options + coldhot_am + size) * amount);
        }
       
        private void am_yes_Click(object sender, EventArgs e)
        {

            ListViewItem order = new ListViewItem(new string[] { "아메리카노 ", Convert.ToString(amount) + "잔 ", Convert.ToString(am_total_value.Text)  });
            form.order_list.Items.Add(order);
            form.Reset_info();
            this.Close();
        }

        private void am_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.Reset_info();
                this.Close();
            }
        }
    }
}
