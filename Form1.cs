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
    public partial class Form1 : Form
    {
        static int order_count = 0;
        static int coffee_menus ;



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
        public void move_info()
        {
            Main_info.Text = "원하시는 메뉴를 선택해주세요.";
            Point move_point = new Point(91, 24);
            Main_info.Location = move_point;
        }
        public void reset_info()
        {
            Main_info.Text = "원하시는 메뉴를 선택해주세요.";
            Point reset_point = new Point(181, 24);
            Main_info.Location = reset_point;
        }
        public void Coffee_order_info()
        {
            switch (coffee_menus)
            {
                case 1:
                    Americano americano = new Americano();
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
                    break;
                default:
                    break;
            }
        }



        public Form1()
        {
            InitializeComponent();
            Current_time.Enabled = true;
            Choose_Button_off();
            reset_info();

        }
        private void Current_time_Tick(object sender, EventArgs e)
        {
            time_value.Text = DateTime.Now.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 1;
            Main_info.Text = "아메리카노를 주문하시겠습니까?";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 2;
            Main_info.Text = "카페라떼를 주문하시겠습니까?";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 3;
            Main_info.Text = "카푸치노를 주문하시겠습니까?";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 4;
            Main_info.Text = "에스프레소를 주문하시겠습니까?";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 5;
            Main_info.Text = "연유라떼를 주문하시겠습니까?";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            move_info();
            Choose_Button_on();
            coffee_menus = 6;
            Main_info.Text = "모카치노를 주문하시겠습니까?";

        }




        private void Choose_Yes_Click(object sender, EventArgs e)
        {
            reset_info();
            Choose_Button_off();
            Coffee_order_info();
            order_count += 1;
        }

        private void Choose_No_Click(object sender, EventArgs e)
        {
            reset_info();
            coffee_menus = 0;
            Choose_Button_off();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_info_Click(object sender, EventArgs e)
        {

        }
    }
}
