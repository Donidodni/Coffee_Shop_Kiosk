using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Coffee_Shop_Kiosk
{
    public partial class Form1 : Form
    { 
        static int coffee_menus;

        public void Form2(string data)
        {
            InitializeComponent();
            richTextBox1.Text = data;
        }

        public void Choose_Button_on()
        {
            Choose_Yes.Visible = true;
            Choose_No.Visible = true;
            Choose_Yes.Enabled = true;
            Choose_No.Enabled = true;
        }

        public void Choose_Button_off()
        {
            Choose_Yes.Visible = false;
            Choose_No.Visible = false;
            Choose_Yes.Enabled = false;
            Choose_No.Enabled = false;
        }

   
        public void Coffee_order_info()
        {
            switch (coffee_menus)
            {
                case 1:
                    Americano americano = new Americano(this);
                    americano.Show();
                    break;
                case 2:
                    Latte latte = new Latte();
                    latte.Show();
                    break;
                case 3:
                    Cappuchino cappuchino = new Cappuchino();
                    cappuchino.Show();
                    break;
                case 4:
                    Espresso espresso = new Espresso();
                    espresso.Show();
                    break;
                case 5:
                    SoyLatte soyLatte = new SoyLatte();
                    soyLatte.Show();
                    break;
                case 6:
                    Mocha mocha = new Mocha();
                    mocha.Show();
                    break;
                default:
                    break;
            }
        }
        public void Reset_info()
        {
            Main_info.Text = "원하시는 메뉴를 \n선택해주세요.";
        }




        public Form1()
        {
            InitializeComponent();
            Current_time.Enabled = true;
            Choose_Button_off();
            

            Main_info.Text = "원하시는 메뉴를 \n선택해주세요.";

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("PretendardVariable.ttf");

        }
        private void Current_time_Tick(object sender, EventArgs e)
        {
            time_value.Text = DateTime.Now.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 1;
            Main_info.Text = "아메리카노를 \n주문하시겠습니까?";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 2;
            Main_info.Text = "카페라떼를 \n주문하시겠습니까?";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 3;
            Main_info.Text = "카푸치노를 \n주문하시겠습니까?";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 4;
            Main_info.Text = "에스프레소를 \n주문하시겠습니까?";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 5;
            Main_info.Text = "연유라떼를 \n주문하시겠습니까?";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Choose_Button_on();
            coffee_menus = 6;
            Main_info.Text = "모카치노를 \n주문하시겠습니까?";

        }




        private void Choose_Yes_Click(object sender, EventArgs e)
        {
            Choose_Button_off();
            Coffee_order_info();
        }

        private void Choose_No_Click(object sender, EventArgs e)
        {
            coffee_menus = 0;
            Choose_Button_off();
            Reset_info();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_info_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //확인시 내용
                this.Close();
            }
        }
    }
}
