using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Interfaces
{
    internal interface IFurnitureFactory
    {
        public IChair createChair();
        public ICoffeeTable coffeeTable();
        public ISofa sofa();
    }
}
