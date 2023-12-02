using FurnitureFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Tables
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        public VictorianCoffeeTable()
        {

        }
        public void hasLegs()
        {
            Console.WriteLine("Victorian Coffee Table has 4 legs");
        }

        public int height()
        {
            return 40;
        }
    }
}
