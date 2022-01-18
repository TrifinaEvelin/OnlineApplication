using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class Paymenu : Ordermenu
    {
        OrderBo o = new OrderBo();
        public void paydetails()
        {
            int DISCOUNT;
            List<Order> admin = o.GetAllcart();

            foreach (var item in OrderBo.orderList)
                Console.WriteLine(item);
            Console.ReadLine();
            Ordermenu ordermenu = new Ordermenu();
            Console.WriteLine("enter your quantity in NonVeg");
            int quantity1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your quantity in Veg");
            int quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your quantity in AllTimeFood");
            int quantity3 = Convert.ToInt32(Console.ReadLine());
            int quantityCost = ((quantity1 * 300) + (quantity2 * 150) + (quantity3 * 100));
            Console.WriteLine();
            Console.WriteLine("availble types are 1--->southindian 2---->continental 3-->chinese ");
            Console.WriteLine("enter your type");
            int type = Convert.ToInt32(Console.ReadLine());

            if (type == 1 || type == 2 || quantityCost < 1000)

            {
                DISCOUNT = 5;

                int totalCost = ((quantityCost * DISCOUNT) / 100);
                int PayAmount = (totalCost - quantityCost);
                Console.WriteLine("you get 5% discount");
                Console.WriteLine($"YOU DISCOUNT IS { totalCost}");
                Console.WriteLine($"YOU NEED TO PAY ONLY{PayAmount}");
                payment();
            }

            else if ((type == 2 || type == 3) || quantityCost < 1500)
            {
                DISCOUNT = 10;

                int totalCost = ((quantityCost * DISCOUNT) / 100);
                int PayAmount = (totalCost - quantityCost);
                Console.WriteLine("you get 10% discount");
                Console.WriteLine("YOU DISCOUNT IS {}", totalCost);
                Console.WriteLine("YOU NEED TO PAY ONLY{}", PayAmount);
                payment();
            }
           
            else
            {
                Console.WriteLine("ENTER CORRECT DEATILS");
                cart();
            }

        }

        public void payment()
        {
            string opt;
            int pay;

            Console.WriteLine("ENTER BUY FOR CONTINUE AND EXIST FOR  CLOSE  ");
            opt = Console.ReadLine();
            if (opt == "BUY")
            {
                Console.WriteLine(" ENTER METHOD YOU WANT  1. DEBIT 2. CREDIT ");
                pay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();

                if (pay == 1 || pay == 2 )
                {

                    Console.WriteLine("Enter your password:");
                    string Password = Console.ReadLine();
                    bool isValidPassword = PayValidation.ValidatePass(Password);
                    while (isValidPassword == false)
                    {
                        if (!isValidPassword)
                        {
                            Console.WriteLine("Please enter the valid password. ");
                        }
                        Console.WriteLine("Enter your password:");
                        Password = Console.ReadLine();
                        isValidPassword = PayValidation.ValidatePass(Password);
                    }
                }
                else
                {
                    Console.WriteLine();
                    payment();
                }
            }
            Console.WriteLine("Ensure details click ok for placing order");
            string conclude = Console.ReadLine();
            if (conclude == "ok")
            {

                List<Order> admin = o.GetAllcart();

                foreach (var item in OrderBo.orderList)
                    Console.WriteLine(item);
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("************Your order is placed!!! it will be arriving in few mins************** ");
                Console.ReadLine();
                break;
            }
            else
            {
                Console.WriteLine(" try again ");
                payment();
            }

        }
    }
}

