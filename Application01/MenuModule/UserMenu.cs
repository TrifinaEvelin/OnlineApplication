using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class UserMenu
    {
        public void DisplayMenu()
        {
            Ordermenu ORDER = new Ordermenu();
            string[][] items = new string[3][];

            items[0] = new string[] { "1.NonVeg:", "  ", "VARIETIES---->  BRIYANI", "VARIETIES---->  FRIEDRICE", "VARIETIES---->  NOODLES", "VARIETIES----> GRAVY"};
            items[1] = new string[] { "2.Veg:", " ", "VARIETIES----> BRIYANI", "VARETIES---->  FRIEDRICE", "VARIETIES----> STARTERS"};
            items[2] = new string[] { "3.AllTimeFood:", " ", "VARIETIES----> IDLY", "VARIETIES----> DOSA", "VARIETIES----> PONGAL" };


            string[] menus = new string[] { "AVAILABLE MENUS ARE \n 1----> NonVeg \n 2----> Veg \n 3---->AllTimeFood" };
            foreach (string itemss in menus )
            {
                Console.WriteLine(itemss);
            }
            Console.WriteLine();
            Console.WriteLine("*********ENTER --->menus <----- FOR SHOW THE  VARIETIES IN MENUS ********");
            int INPUT = Convert.ToInt32(Console.ReadLine());

            if (INPUT == 1)

            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();

                //IMenu();
                Ordermenu ordermenu = new Ordermenu();
                ordermenu.DisplayMenu();
                //  flag = false;


            }

            else if (INPUT == 2)
            {
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();
                ORDER.DisplayMenu();
                //flag = false;

            }
            else if (INPUT == 3)
            {
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        Console.WriteLine("{0} ", items[i][j]);
                    }

                }
                Console.WriteLine();
                ORDER.DisplayMenu();
                // flag = false;

            }


            else
            {
                Console.WriteLine("enter valid credentials");
                //view();
            }

        }

        public void ChooseUserMenu()
        {

            Console.WriteLine("ENTER interest you want \n1---->view the varieties /n2----> visit  items in the cart \n--->exit ");
            int need = Convert.ToInt32(Console.ReadLine());
            if (need == 1)
            {
                //view();
                DisplayMenu();
            }
            else if (need == 2)
            {
                Console.WriteLine(" ********NO ITEMS IN CART********");
                ChooseUserMenu();
            }
            else if (need == 3)
            {
                Console.WriteLine("Thank you visit again!!");

            }
            else
            {
                Console.WriteLine("enter valid credentials");
                ChooseUserMenu();
            }


        }
    }
}

    

