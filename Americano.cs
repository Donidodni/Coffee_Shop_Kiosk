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
using static System.Windows.Forms.Design.AxImporter;

namespace Coffee_Shop_Kiosk
{
    public partial class Americano : Form
    {
        public Americano()
        {
            InitializeComponent();

        }


        int am_total_price = 4000;
        int am_options = 0;
        int size = 0;
        int coldhot = 0;
        int amount = 1;


        private void am_cold_CheckedChanged(object sender, EventArgs e)
        {
            if (am_cold.Checked == true)
            {
                coldhot = 500;
                am_UpdatePrice();
            }
            else
            {
                coldhot = 0;
                am_UpdatePrice();
            }
              
        }

        private void am_hot_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void am_option1_CheckedChanged(object sender, EventArgs e)
        {
            am_UpdatePrice();
        }

        private void am_option2_CheckedChanged(object sender, EventArgs e)
        {
            am_UpdatePrice();
        }

        private void am_option3_CheckedChanged(object sender, EventArgs e)
        {
            if (am_option3.Checked == true)
            {
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
            else if ( am_numeric.SelectedIndex == 2)
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
            
            am_total_value.Text = Convert.ToString((am_total_price - am_options + coldhot + size) * amount);
            
        }

        private void am_yes_Click(object sender, EventArgs e)
        {
            am_total_price = int.Parse(am_total_value.Text);
            this.Close();
        }

        private void am_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
