using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Product
    {
        int _price;

        public int Count { get; set; }

        public int Price 
        { 
            get 
            {
                return _price;
            } 

            set 
            {
                if (value > 0)
                    _price = value;
            } 
        }

        public Product(int count,int price)
        {
            Count = count;
            Price = price;
        }
    }
}
