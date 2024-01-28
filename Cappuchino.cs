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
using System.Xml.Linq;

namespace Coffee_Shop_Kiosk
{
    public partial class Cappuchino : Form
    {
        Form1 form = null;
        public Cappuchino(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;  
        }

        int cap_total_price = 4300;
        int cap_options = 0;
        int cap_sizes = 0;
        int coldhot_cap = 0;
        int cap_amounts = 1;


        private void cap_hot_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_hot.Checked)
            {
                cap_hot.BackColor = Color.LightGray;
            }
            else
            {
                cap_hot.BackColor = Color.White;
            }
        }

        private void cap_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_cold.Checked == true)
            {
                cap_cold.BackColor = Color.LightGray;
                coldhot_cap = 500;
                cap_UpdatePrice();
            }
            else
            {
                cap_cold.BackColor = Color.White;
                coldhot_cap = 0;
                cap_UpdatePrice();
            }
        }




        private void cap_option1_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_option1.Checked)
            {
                cap_option1.BackColor = Color.LightGray;
            }
            else
            {
                cap_option1.BackColor = Color.White;
            }
        }

        private void cap_option2_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_option2.Checked)
            {
                cap_option2.BackColor = Color.LightGray;
            }
            else
            {
                cap_option2.BackColor = Color.White;
            }
        }

        private void cap_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (cap_option3.Checked == true)
            {
                cap_option3.BackColor = Color.LightGray;
                cap_options = 300;
            }
            else
            {
                cap_option3.BackColor = Color.White;
                cap_options = 0;
            }

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
            ListViewItem order = new ListViewItem(new string[] { "카푸치노 ", Convert.ToString(cap_amounts) + "잔 ", Convert.ToString(cap_total_value.Text) });
            form.order_list.Items.Add(order);
            form.Reset_info();
            this.Close();
        }

        private void cap_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.Reset_info();
                this.Close();
            }
        }
    }
}
