using System;
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

        Form1 f = null;
        public Americano(Form1 form1)
        {
            InitializeComponent();
            f = form1;
        }


        int am_total_price = 4000;
        int am_options = 0;
        int am_options_number = 0;
        int size = 0;
        int coldhot_am = 0;
        int amount = 1;


        public string am_order()
        {
            string order = null;

            if (coldhot_am == 500) order += " 아이스";
            else order += " ";


            order += " 아메리카노";
            order += am_total_price + " 원 ";
            order += Convert.ToString(amount + "개" + "");
            return order+"\n";
            /*
            if (am_options_number == 1) order += " 일회용기,";
            else if (am_options_number == 2) order += " 매장,";
            else order += " 텀블러,";

            
            if (am_numeric.SelectedIndex == 0) order += " 작은컵 \n";
            else if (am_numeric.SelectedIndex == 1) order += " 중간컵 \n";
            else order += " 큰컵, \n";
            */



        }

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


        private void am_UpdatePrice()
        {
            am_total_value.Text = Convert.ToString((am_total_price - am_options + coldhot_am + size) * amount);
        }

        private void am_yes_Click(object sender, EventArgs e)
        {
            f.richTextBox1.Text += am_order();
            this.Close();
        }

        private void am_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }
    }
}
