using Application01.MenuModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class AdminMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.Write("Welcome Admin");
            Console.WriteLine("Select the Any Options");
            Console.WriteLine("1.Add 2. Update  3. Delete  4. Display All  5.Exist");
            int adminOption = 0;
            adminOption = Convert.ToInt32(Console.ReadLine());

            // Create Instance user Bo Class to Access Funalities 
            AdminBo adminBo = new AdminBo();
            string VARIETIES, QUANTITY;
            switch (adminOption)
            {
                case 1:
                    Console.WriteLine("Enter  Details");
                    Console.WriteLine("Enter the VARIETIES");
                    VARIETIES = Console.ReadLine();
                    Console.WriteLine("Enter the QUANTITY");
                    QUANTITY = Console.ReadLine();
                    bool res = adminBo.CreateNew(VARIETIES, QUANTITY);

                    if (res)
                    {
                        Console.WriteLine(" items Added SuccessFully");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" items Not Added SuccessFully... ");
                    }
                    DisplayMenu();
                    break;
                case 2:
                    Console.WriteLine("Enter the Details");
                    Console.WriteLine("Enter the VARIETIES");
                    VARIETIES = Console.ReadLine();
                    Console.WriteLine("Enter the QUANTITY");
                    QUANTITY = Console.ReadLine();
             
                    bool res1 = adminBo.UpdateItems(VARIETIES, QUANTITY);
                    if (res1) { Console.WriteLine(" ITEMS Updated SuccessFully"); }
                    else
                    {
                        Console.WriteLine(" ITEMS Not Updated SuccessFully");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the ITEM No you want to delete : ");
                    VARIETIES = Console.ReadLine();
                    bool res2 = adminBo.DeleteItems(VARIETIES);
                    if (res2)
                    {
                        Console.WriteLine("items deleted successfully..");
                    }
                    else
                    {
                        Console.WriteLine("ITEMS not deleted successfully - Check the Route Number..");
                    }
                    DisplayMenu();
                    break;
                case 4:
                    Console.ReadLine();
                    List<Admin> admin = adminBo.GetAllItems();


                    Console.ReadLine();

                    foreach (var item in AdminBo.adminList)
                    {


                        Console.WriteLine(item);

                    }
                    Console.ReadLine();

                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }

        }
    }
}

