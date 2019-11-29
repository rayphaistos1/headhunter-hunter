using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeadHunter_Hunter.Models
{
    public class PricingOption
    {
        public PricingOption(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name;
        public double Price;
    }
}
