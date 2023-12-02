using FurnitureFactory.Chairs;
using FurnitureFactory.Interfaces;
using FurnitureFactory.Sofa;
using FurnitureFactory.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory.Factories
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public ICoffeeTable coffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ISofa sofa()
        {
            return new VictorianSofa();
        }
        public VictorianFurnitureFactory()
        {
            
        }
    }
}
