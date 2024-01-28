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

        Form1 form = null;
        public Latte(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }


        int la_total_price = 4000;
        int la_options = 0;
        int la_coldhot_options = 0;
        int la_sizes = 0;
        int la_amounts = 1;

        private void la_hot_CheckedChanged(object sender, EventArgs e)
        {
            if (la_hot.Checked)
            {
                la_hot.BackColor = Color.LightGray;
            }
            else
            {
                la_hot.BackColor = Color.White;
            }
        }

        private void la_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (la_cold.Checked == true)
            {
                la_cold.BackColor = Color.LightGray;
                la_coldhot_options = 500;
                la_UpdatePrice();
            }
            else
            {
                la_cold.BackColor = Color.White;
                la_coldhot_options = 0;
                la_UpdatePrice();
            }
        }


        private void la_option1_CheckedChanged(object sender, EventArgs e)
        {
            if (la_option1.Checked)
            {
                la_option1.BackColor = Color.LightGray;
            }
            else
            {
                la_option1.BackColor = Color.White;
            }
        }

        private void la_option2_CheckedChanged(object sender, EventArgs e)
        {
            if (la_option2.Checked)
            {
                la_option2.BackColor = Color.LightGray;
            }
            else
            {
                la_option2.BackColor = Color.White;
            }
        }

        private void la_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (la_option3.Checked == true)
            {
                la_option3.BackColor = Color.LightGray;
                la_options = 300;
            }
            else
            {
                la_option3.BackColor = Color.White;
                la_options = 0;
            }

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
            ListViewItem order = new ListViewItem(new string[] { "카페라떼 ", Convert.ToString(la_amounts) + "잔 ", Convert.ToString(la_total_value.Text) });
            form.order_list.Items.Add(order);
            form.Reset_info();
            this.Close();
        }

        private void la_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.Reset_info();
                this.Close();
            }
        }
    }
}
