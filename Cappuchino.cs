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
    public partial class Cappuchino : Form
    {
        public Cappuchino()
        {
            InitializeComponent();
        }

        int cap_total_price = 4300;
        int cap_options = 0;
        int cap_sizes = 0;
        int coldhot_cap = 0;
        int cap_amounts = 1;


        private void cap_hot_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void cap_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_cold.Checked == true)
            {
                coldhot_cap = 500;
                cap_UpdatePrice();
            }
            else
            {
                coldhot_cap = 0;
                cap_UpdatePrice();
            }
        }




        private void cap_option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cap_option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cap_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_option3.Checked == true)
            {
                cap_options = 300;
            }
            else
                cap_options = 0;
            cap_UpdatePrice();
        }





        private void cap_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cap_size.SelectedIndex == 0)
                cap_sizes = 0;
            else if (cap_size.SelectedIndex == 1)
                cap_sizes = 500;
            else if (cap_size.SelectedIndex == 2)
                cap_sizes = 1000;
            cap_UpdatePrice();
        }

        private void cap_amount_ValueChanged(object sender, EventArgs e)
        {
            cap_amounts = (int)cap_amount.Value;
            cap_UpdatePrice();
        }


        private void cap_UpdatePrice()
        {

            cap_total_value.Text = Convert.ToString((cap_total_price - cap_options + coldhot_cap + cap_sizes) * cap_amounts);

        }



        private void cap_yes_Click(object sender, EventArgs e)
        {

        }

        private void cap_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }
    }
}
