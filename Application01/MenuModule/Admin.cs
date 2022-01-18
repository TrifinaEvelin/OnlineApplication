using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01.MenuModule
{
    class Admin
    {
        string VARIETIES;
        string QUANTITY;
       

        // Zero Parameterised Con
        public Admin()
        {
        }
        // Parameterised Contr

        public Admin(string varieties, string quantity)
        {

           Varieties = varieties;
            Quantity = quantity;
        
        }

        public string Varieties { get => VARIETIES; set => VARIETIES = value; }
        public string Quantity { get =>QUANTITY; set => QUANTITY = value; }

       
        // Convert to Object
        public override string ToString()
        {
            return String.Format("Varieties--->{0} Quantity---->{1}", Varieties, Quantity);
        }
    }
}


