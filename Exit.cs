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
    public partial class Exit : Form
    {
        Form1 main = new Form1();
        public Exit(Form1 form1)
        {
            InitializeComponent();
            main = form1;
        }

        private void exit_yes_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Close();
        }

        private void exit_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
