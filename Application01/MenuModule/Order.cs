using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Application01.MenuModule

{
    // User Class to collect its Behaviour and Properties
    public class Order
    {
        // User Fields
        string varieties;
        string quantity;
 

        // Zero Parameterised Constructor
        public Order()
        {
        }
        // Parameterised Contr



        public Order(string varieties, string quantity)
        {
            Varieties = varieties;
            Quantity = quantity;
     

        }
        public string Varieties { get => varieties; set => varieties = value; }
        public string Quantity { get => quantity; set => quantity = value; }
       
        public override string ToString()
        {
            return String.Format("varieties---->{0} ,quantity---->{1} ", Varieties, Quantity);
        }

    }
}
