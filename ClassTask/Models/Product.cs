using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Product
    {
        string _name;
        float _price;

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
          
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length>5 && value.Length < 25)
                {
                    _name = value;
                }
            }
        }

        public float Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price=value;
                }
            }


        }
    }
}
