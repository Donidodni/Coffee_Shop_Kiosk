using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Kiosk
{
    public partial class Latte : Form
    {
        public Latte(Form1 form1)
        {
            InitializeComponent();
        }
        int la_total_price = 4500;
        int la_options = 0;
        int la_coldhot_options = 0;
        int la_sizes = 0;
        int la_amounts = 1;

        private void la_hot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void la_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (la_cold.Checked == true)
            {
                la_coldhot_options = 500;
                la_UpdatePrice();
            }
            else
            {
                la_coldhot_options = 0;
                la_UpdatePrice();
            }
        }


        private void la_option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void la_option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void la_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (la_option3.Checked == true)
            {
                la_options = 300;
            }
            else
                la_options = 0;
            la_UpdatePrice();
        }




        private void la_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (la_size.SelectedIndex == 0)
                la_sizes = 0;
            else if (la_size.SelectedIndex == 1)
                la_sizes = 500;
            else if (la_size.SelectedIndex == 2)
                la_sizes = 1000;
            la_UpdatePrice();
        }
        private void la_amount_ValueChanged(object sender, EventArgs e)
        {
            la_amounts = (int)la_amount.Value;
            la_UpdatePrice();
        }

        private void la_UpdatePrice()
        {

            la_total_value.Text = Convert.ToString((la_total_price - la_options + la_coldhot_options + la_sizes) * la_amounts);

        }

        private void la_yes_Click(object sender, EventArgs e)
        {

        }

        private void la_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }
    }
}
