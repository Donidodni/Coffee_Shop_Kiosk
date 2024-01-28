using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_Shop_Kiosk
{
    public partial class Pay_Form : Form
    {
        Form1 form = null;
        public Pay_Form(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            int to_pay = 0;
            final_order_list.View = View.Details;

            foreach (ListViewItem item in form.order_list.Items)
                final_order_list.Items.Add((ListViewItem)item.Clone());

            for (int i = 0; i < final_order_list.Items.Count; i++)
            {
                to_pay += int.Parse(final_order_list.Items[i].SubItems[2].Text);
            }
            //string str = Convert.ToString(final_order_list.Items[0].SubItems[2].Text);
            final_order_value.Text = Convert.ToString(to_pay) + "원";
        }

        private void pay_yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 완료되었습니다.", "결제 완료");
            form.order_list.Clear();
            this.Close();
        }

        private void pay_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("진행중인 결제을 취소합니다.", "결제 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
