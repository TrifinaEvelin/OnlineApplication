using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class Ordermenu : IOrdermenu
    {

        UserMenu usermenu = new UserMenu();
        
        public void DisplayMenu()
        {
            Console.WriteLine("Hi customer!!!");


            // Create Instance user Bo Class to Access Funalities 
            OrderBo orderbo = new OrderBo();
            string varieties;
            string quantity;
        
            Console.WriteLine("enter the type of food you want ");
            varieties = Console.ReadLine();

            Console.WriteLine();
            List<string> Quantity = new List<string>() { "Quantity---->", "Full", "Half", "Quarter"};
            foreach (string Q in Quantity)
            {
                Console.WriteLine(Q);
            }
            Console.WriteLine();
            Console.WriteLine("Enter Quantity  you want : ");
            quantity = Console.ReadLine();

            Console.WriteLine();
                   
            bool res = orderbo.CreateNewCart(varieties, quantity);
            if (res)
            {

                Console.WriteLine(" ITEMS Added SuccessFully");

                cart();
                usermenu.DisplayMenu();
            }
            else
            {
                Console.WriteLine(" CART  not Added SuccessFully");
            }
        }
        public void cart()
        {
            OrderBo orderbo = new OrderBo();
            Console.WriteLine("1. order \n2. add more items");
            int inpu = Convert.ToInt32(Console.ReadLine());
            if (inpu == 1)
            {
                List<Order> admin = orderbo.GetAllcart();

                foreach (var item in OrderBo.orderList)
                    Console.WriteLine(item);
                Console.WriteLine();
                Console.WriteLine("*******************All the FOODITEMS are displayed successfully.......****************");

                Console.WriteLine("==============================================");



                Console.WriteLine();
                Console.WriteLine("please enter ok for payment");
                string op = Console.ReadLine();
                if (op == "OK")
                {
                    Paymenu PAYMENU = new Paymenu();
                    Console.WriteLine();
                    PAYMENU.paydetails();
                }
                else
                {
                    Console.WriteLine(" Enter valid credentials");
                    cart();
                }

            }
            else if (inpu == 2)
            {
                usermenu.DisplayMenu();

            }


            else
            {
                Console.WriteLine("ENTER VALID DETAILS ");
                cart();
            }

        }


    }





}

