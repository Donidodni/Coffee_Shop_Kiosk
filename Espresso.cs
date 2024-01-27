using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Coffee_Shop_Kiosk
{
    public partial class Espresso : Form
    {
        public Espresso()
        {
            InitializeComponent();
        }


        int es_total_price = 3000;
        int es_options = 0;
        int es_sizes = 0;
        int es_amounts = 1;







        private void es_option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void es_option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void es_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (es_option3.Checked == true)
            {
                es_options = 300;
            }
            else
                es_options = 0;
            es_UpdatePrice();
        }



        private void es_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (es_size.SelectedIndex == 0)
                es_sizes = 0;
            else if (es_size.SelectedIndex == 1)
                es_sizes = 300;
            else if (es_size.SelectedIndex == 2)
                es_sizes = 600;
            es_UpdatePrice();
        }

        private void es_amount_ValueChanged(object sender, EventArgs e)
        {
            es_amounts = (int)es_amount.Value;
            es_UpdatePrice();
        }

        private void es_UpdatePrice()
        {

            es_total_value.Text = Convert.ToString((es_total_price - es_options + es_sizes) * es_amounts);

        }

        private void es_yes_Click(object sender, EventArgs e)
        {

        }

        private void es_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 주문을 취소합니다.", "주문취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }
    }
}
