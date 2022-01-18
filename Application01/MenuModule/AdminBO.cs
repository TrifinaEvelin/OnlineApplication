using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class AdminBo
    {
        public static List<Admin> adminList = new List<Admin>();

        // Create a new User
        public bool CreateNew(string VARIETIES, string QUANTITY)
        {
            Admin admin = FindItems(VARIETIES);
            if (admin == null)
            {
                admin = new Admin(VARIETIES, QUANTITY);
                adminList.Add(admin);
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Admin> GetAllItems()
        {

            if (adminList.Count == 0)
            {
                Console.WriteLine("No items Avaiable..");
                return null;
            }
            else
            {
                return adminList;
            }
        }
        public bool UpdateItems(string VARIETIES, string QUANTITY)
        {
            Admin admin = FindItems(VARIETIES);
            Console.WriteLine("Existing ITEMS Details");
            Console.WriteLine(admin);
            if (admin != null)
            {
                Admin temUer = admin;
                admin.Varieties = VARIETIES;
                admin.Quantity = QUANTITY;
                adminList.Remove(temUer);
                adminList.Add(admin);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteItems(string VARIETIES)
        {
            Admin admin = FindItems(VARIETIES);
            if (admin != null)
            {
                adminList.Remove(admin);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Admin FindItems(string VARIETIES)
        {
            var admin = (from k in adminList
                         where k.Varieties == VARIETIES
                         select k).FirstOrDefault();
            return admin;
        }
    }
}


