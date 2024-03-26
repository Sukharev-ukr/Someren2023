using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int Id { get; set; }         // database id
        public int DrinkId { get; set; }    // drink's id
        public int StudentId { get; set; }    // student's id
        public int amount { get; set; }     // number of drinks order


       
    }
}
