/*
Title       : Online Food Delivery Application
Author      : Trifina Evelin V
Created at  : 31/Dec/2021
Reviewed by : AKSHAYA 
Updated at  : 05/Jan/2022
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.SigninORSignup();
        }
    }
}
