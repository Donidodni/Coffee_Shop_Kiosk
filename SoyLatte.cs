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
    public partial class SoyLatte : Form
    {
        Form1 form = new Form1();
        public SoyLatte(Form1 form1)
        {
            this.form = form1;
            InitializeComponent();
        }

        int soy_total_price = 4500;
        int soy_options = 0;
        int soy_sizes = 0;
        int coldhot_soy = 0;
        int soy_amounts = 1;



        private void soy_hot_CheckedChanged(object sender, EventArgs e)
        {
            if (soy_hot.Checked)
            {
                soy_hot.BackColor = Color.LightGray;
            }
            else
            {
                soy_hot.BackColor = Color.White;
            }
        }

        private void soy_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (soy_cold.Checked == true)
            {
                soy_cold.BackColor = Color.LightGray;
                coldhot_soy = 500;
                soy_UpdatePrice();
            }
            else
            {
                soy_cold.BackColor = Color.White;
                coldhot_soy = 0;
                soy_UpdatePrice();
            }
        }



        private void soy_option1_CheckedChanged(object sender, EventArgs e)
        {
            if (soy_option1.Checked)
            {
                soy_option1.BackColor = Color.LightGray;
            }
            else
            {
                soy_option1.BackColor = Color.White;
            }
        }

        private void soy_option2_CheckedChanged(object sender, EventArgs e)
        {
            if (soy_option2.Checked)
            {
                soy_option2.BackColor = Color.LightGray;
            }
            else
            {
                soy_option2.BackColor = Color.White;
            }
        }

        private void soy_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (soy_option3.Checked == true)
            {
                soy_option3.BackColor = Color.LightGray;
                soy_options = 300;
            }
            else
            {
                soy_option3.BackColor = Color.LightGray;
                soy_options = 0;
            }
            
            soy_UpdatePrice();
        }



        private void soy_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soy_size.SelectedIndex == 0)
                soy_sizes = 0;
            else if (soy_size.SelectedIndex == 1)
                soy_sizes = 500;
            else if (soy_size.SelectedIndex == 2)
                soy_sizes = 1000;
            soy_UpdatePrice();
        }

        private void soy_amount_ValueChanged(object sender, EventArgs e)
        {
            soy_amounts = (int)soy_amount.Value;
            soy_UpdatePrice();
        }

        private void soy_UpdatePrice()
        {

            soy_total_value.Text = Convert.ToString((soy_total_price - soy_options + coldhot_soy + soy_sizes) * soy_amounts);

        }


        private void soy_yes_Click(object sender, EventArgs e)
        {
            ListViewItem order = new ListViewItem(new string[] { "돌체라떼 ", Convert.ToString(soy_amounts) + "잔 ", Convert.ToString(soy_total_value.Text) });
            form.order_list.Items.Add(order);
            form.Reset_info();
            this.Close();
        }

        private void soy_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.Reset_info();
                this.Close();
            }
        }
    }
}
