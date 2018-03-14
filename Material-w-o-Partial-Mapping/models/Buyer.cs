using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material_w_o_Partial_Mapping.models
{
    public class Buyer
    {

        public Buyer(String Name, int MaterialAmount, Double Price) {
            this.Name = Name;
            this.MaterialAmount = MaterialAmount;
            this.Price = Price;
            this.PricePerUnit = (Double)Price / MaterialAmount;

        }

        public String Name { get; private set; }

        public int MaterialAmount { get; private set; }

        public Double Price { get; private set; }

        public Double PricePerUnit { get; private set; }
    }
}
