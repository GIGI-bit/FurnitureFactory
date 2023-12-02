using FurnitureFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Tables
{
    internal class ModernCoffeeTable:ICoffeeTable
    {
        public ModernCoffeeTable() { }

        public void hasLegs()
        {
            Console.WriteLine("Modern Coffee Table has legs.");
        }

        public int height()
        {
            return 20;
        }
    }
}
