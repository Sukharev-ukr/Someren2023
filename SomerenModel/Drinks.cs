using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    {
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public decimal DrinkVAT {  get; set; }
        public string DrinkType { get; set; }
        public decimal DrinkPrice { get; set; }
        public int DrinkStock { get; set; }
    }
}