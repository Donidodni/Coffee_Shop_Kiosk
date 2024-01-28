using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Kiosk
{
    public partial class Mocha : Form
    {
        Form1 form = null;
        public Mocha(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        int mo_total_price = 4500;
        int mo_options = 0;
        int mo_sizes = 0;
        int coldhot_mo = 0;
        int mo_amounts = 1;


        private void mo_hot_CheckedChanged(object sender, EventArgs e)
        {
            if (mo_hot.Checked)
            {
                mo_hot.BackColor = Color.LightGray;
            }
            else
            {
                mo_hot.BackColor = Color.White;
            }
        }

        private void mo_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (mo_cold.Checked == true)
            {
                mo_cold.BackColor = Color.LightGray;
                coldhot_mo = 500;
                mo_UpdatePrice();
            }
            else
            {
                mo_cold.BackColor = Color.White;
                coldhot_mo = 0;
                mo_UpdatePrice();
            }
        }

        private void mo_option1_CheckedChanged(object sender, EventArgs e)
        {
            if (mo_option1.Checked == true)
            {
                mo_option1.BackColor = Color.LightGray;

            }
            else
                mo_option1.BackColor = Color.White;
        }

        private void mo_option2_CheckedChanged(object sender, EventArgs e)
        {
            if(mo_option2.Checked == true)
            {
                mo_option2.BackColor = Color.LightGray;

            }
            else
                mo_option2.BackColor = Color.White;

        }

        private void mo_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (mo_option3.Checked == true)
            {
                mo_option3.BackColor = Color.LightGray;
                mo_options = 300;
            }
            else
            {
                mo_option3.BackColor = Color.White;
                mo_options = 0;
            }
                
            mo_UpdatePrice();
        }


        private void mo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mo_size.SelectedIndex == 0)
                mo_sizes = 0;
            else if (mo_size.SelectedIndex == 1)
                mo_sizes = 500;
            else if (mo_size.SelectedIndex == 2)
                mo_sizes = 1000;
            mo_UpdatePrice();
        }

        private void mo_amount_ValueChanged(object sender, EventArgs e)
        {
            mo_amounts = (int)mo_amount.Value;
            mo_UpdatePrice();
        }


        private void mo_UpdatePrice()
        {

            mo_total_value.Text = Convert.ToString((mo_total_price - mo_options + coldhot_mo + mo_sizes) * mo_amounts);

        }

        public string mo_order()
        {
            string order = null;

            if (coldhot_mo == 500) order += " 아이스";
            else order += " ";


            order += " 모카치노"+ mo_total_price + " 원 "+ mo_amounts + "개";

            return order + "\n";
            /*
            if (am_options_number == 1) order += " 일회용기,";
            else if (am_options_number == 2) order += " 매장,";
            else order += " 텀블러,";

            
            if (am_numeric.SelectedIndex == 0) order += " 작은컵 \n";
            else if (am_numeric.SelectedIndex == 1) order += " 중간컵 \n";
            else order += " 큰컵, \n";
            */

        }

        private void mo_yes_Click(object sender, EventArgs e)
        {
            form.richTextBox1.Text += mo_order();
            this.Close();
        }

        private void mo_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }


    }
}
