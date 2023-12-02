using FurnitureFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Chairs
{
    internal class ModernChair:IChair
    {
        public ModernChair() { }

        public void hasLegs()
        {
            Console.WriteLine("Chair has legs");
        }

        public void sitOn()
        {
            Console.WriteLine("Sit");
        }
    }
}
