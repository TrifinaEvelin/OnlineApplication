using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application01.MenuModule
{
    public class OrderBo
    {
        public static List<Order> orderList = new List<Order>(); // Create a new User
        public bool CreateNewCart(string varieties, string quantity)
        {
            Order order = Findcart(varieties);
            if (order == null)
            {
                order = new Order(varieties, quantity);
                orderList.Add(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Order> GetAllcart()
        {
            if (orderList.Count == 0)
            {
                return null;
            }
            else
            {
                return orderList;
            }
        }
        public bool Delete(string varieties)
        {
            Order order = Findcart(varieties);
            if (order != null)
            {
                orderList.Remove(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Order Findcart(string VarietieS)
        {
            var order = (from k in orderList
                         where k.Varieties == VarietieS
                         select k).FirstOrDefault();
            return order;
        }
    }
}

