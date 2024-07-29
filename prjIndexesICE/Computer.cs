using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexesICE
{
    public class Computer
    {
        public double Price;
        public string Brand, Colour, Display;

        public Computer(double price, string brand, string colour, string display) 
        {
            this.Price = price;
            this.Brand = brand;
            this.Colour = colour;
            this.Display = display;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.Price;
                else if (index == 1)
                    return this.Brand;
                else if (index == 2)    
                    return this.Colour;
                else if(index == 3)
                    return this.Display;
                return null;
            }
            set
            {
                if (index == 0)
                    this.Price = (double)value;
                else if (index == 1)
                    this.Brand = (string)value;
                else if( index == 2)
                    this.Colour = (string)value;
                else if(index == 3)
                    this.Display= (string)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("price"))
                    return this.Price;
                else if (attrName.ToLower().Equals("brand"))
                    return this.Brand;
                else if (attrName.ToLower().Equals("colour"))
                    return this.Colour;
                else if (attrName.ToLower().Equals("Display"))
                    return this.Display;
                return null;
            }
            set
            {
                if(attrName.ToLower().Equals("price"))
                    this.Price = (double)value;
                else if (attrName.ToLower().Equals("brand"))
                    this.Brand = (string)value;
                else if (attrName.ToLower().Equals("colour"))
                    this.Colour = (string)value;
                else if(attrName.ToLower().Equals("Display"))
                    this.Display = (string)value;
            }
        }

    }
}
