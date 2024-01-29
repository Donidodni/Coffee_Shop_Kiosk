using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Kiosk
{
    internal class Custom_menu
    {

        public Custom_menu(Form1 form)
        {
            Form1 form1 = form;
            int toping = form.toping_box.SelectedIndex;
            int coffee = form.coffee_box.SelectedIndex;
            int coffee_base = form.base_button.SelectedIndex;

            form.custom_menu = menu_select(toping, coffee, coffee_base);
            form.custom_price = menu_select1(toping, coffee, coffee_base);

        }
        public string menu_select(int toping, int coffee, int coffee_base)
        {
            Form1 form1 = new Form1();
            string str = string.Empty;
            
            switch (toping)
            {
                case 0: //토피넛 가루      
                    str += "토피넛 ";
                    form1.custom_price += 1000;
                    break;
                case 1: // 휘핑 크림
                    str += "(휘핑) ";
                    form1.custom_price += 500;
                    break;
                case 2: // 계피 가루
                    str += "진저 ";
                    form1.custom_price += 1000;
                    break;
                case 3: // 카카오 가루 
                    str += "카카오 ";
                    form1.custom_price += 1200;
                    break;
                case 4:
                    str += "";
                    break;
            }

            switch (coffee_base)
            {
                case 0: // 따듯한 물 
                    if (coffee == 0) // 기본샷
                    {
                        str += "아메리카노";
                        form1.custom_price += 2000;
                    }
                    else if (coffee == 1)
                    {
                        str += "더블샷 아메리카노";
                        form1.custom_price += 2300;
                    }
                    break;

                case 1: // 차가운 물
                    if (coffee == 0) // 기본샷
                    {
                        str += "아이스 아메리카노";
                        form1.custom_price += 2500;
                    }
                    else if (coffee == 1)
                    {
                        str += "더블샷 아이스 아메리카노";
                        form1.custom_price += 2800;
                    }
                    break;

                case 2: // 따듯한 우유
                    if (coffee == 0) // 기본샷
                    {
                        str += "카페라떼";
                        form1.custom_price += 3000;
                    }
                    else if (coffee == 1)
                    {
                        str += "더블샷 카페라떼";
                        form1.custom_price += 3300;
                    }
                    else if (coffee == 2)
                    {
                        str += "카푸치노";
                        form1.custom_price += 3000;
                    }
                    break;
                case 3: // 차가운 우유
                    if (coffee == 0) // 기본샷
                    {
                        str += "아이스 카페라떼";
                        form1.custom_price += 3500;
                    }
                    else if (coffee == 1)
                    {
                        str += "더블샷 아이스 카페라떼";
                        form1.custom_price += 3800;
                    }
                    else if (coffee == 2)
                    { 
                        str += "아이스 카푸치노";
                        form1.custom_price += 3500;
                    }
                    break;
                default:
                    str += "test";
                    break;
            }
            return str;

        }
        public int menu_select1(int toping, int coffee, int coffee_base)
        {

            int price = 0;

            switch (toping)
            {
                case 0: //토피넛 가루      
                    price += 1000;
                    break;
                case 1: // 휘핑 크림
                    price += 500;
                    break;
                case 2: // 계피 가루
                    price += 1000;
                    break;
                case 3: // 카카오 가루 
                    price += 1200;
                    break;
                case 4:
                    break;
            }

            switch (coffee_base)
            {
                case 0: // 따듯한 물 
                    if (coffee == 0) // 기본샷
                    {
                        price += 2000;
                    }
                    else if (coffee == 1)
                    {
                        price += 2300;
                    }
                    break;

                case 1: // 차가운 물
                    if (coffee == 0) // 기본샷
                    {
                        price += 2500;
                    }
                    else if (coffee == 1)
                    {
                        price += 2800;
                    }
                    break;

                case 2: // 따듯한 우유
                    if (coffee == 0) // 기본샷
                    {
                        price += 3000;
                    }
                    else if (coffee == 1)
                    {
                        price += 3300;
                    }
                    else if (coffee == 2)
                    {
                        price += 3000;
                    }
                    break;
                case 3: // 차가운 우유
                    if (coffee == 0) // 기본샷
                    {
                        price += 3500;
                    }
                    else if (coffee == 1)
                    {
                        price += 3800;
                    }
                    else if (coffee == 2)
                    {
                        price += 3500;
                    }
                    break;
                default:
                    price += 123;
                    break;
            }
            return price;

        }
    }
}
