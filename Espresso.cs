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
        Form1 form = null;
        public Espresso(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }


        int es_total_price = 3000;
        int es_options = 0;
        int es_sizes = 0;
        int es_amounts = 1;
        int es_alert = 0;


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
            else
                es_alert = 1;
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
        public string es_order()
        {
            string order = null;

            order += Convert.ToString(es_size.SelectedItem) + " 에스프레소" + es_total_price + " 원 "+ es_amounts + "개\n";
            return order ;

            /*
            if (am_options_number == 1) order += " 일회용기,";
            else if (am_options_number == 2) order += " 매장,";
            else order += " 텀블러,";

            
            if (am_numeric.SelectedIndex == 0) order += " 작은컵 \n";
            else if (am_numeric.SelectedIndex == 1) order += " 중간컵 \n";
            else order += " 큰컵, \n";
            */

        }
        private void es_yes_Click(object sender, EventArgs e)
        {
            

            if (es_alert == 1)
            {
                MessageBox.Show("사이즈를 선택해주세요.");
            }
            form.richTextBox1.Text += es_order();
            this.Close();
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
