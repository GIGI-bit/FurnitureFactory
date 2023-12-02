using FurnitureFactory.Chairs;
using FurnitureFactory.Interfaces;
using FurnitureFactory.Sofa;
using FurnitureFactory.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Factories
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public ICoffeeTable coffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public IChair createChair()
        {
            return new ModernChair();   
        }

        public ISofa sofa()
        {
            return new ModernSofa();
        }
        public ModernFurnitureFactory()
        {
            
        }
    }
}
