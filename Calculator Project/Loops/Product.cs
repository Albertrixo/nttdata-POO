using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Loops
{
    public class Product
    {
        public string Name { get; set; }
        public int Id{ get; set; }
        public float Price { get; set; }
        public Guid Guid { get; set; }

        public Product()
        {
            Guid= Guid.NewGuid();
        }
        public Product(int id, string name, float price)
        {
            //Método set 
            id = Id;
            name = Name;
            price = Price;
            Guid = Guid.NewGuid();

        }
        public override string ToString()
        {
            //Método get
            return "Product: " + Name + "," + Id + "," + Price;
        }
    }
}
