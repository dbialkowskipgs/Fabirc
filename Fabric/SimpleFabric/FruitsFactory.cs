using System;
using Fabric.SimpleFabric.Model;

namespace Fabric.SimpleFabric
{
    internal class FruitsFactory
    {
        public IFruits CreateFruitInstance(string fruit)
        {
            switch (fruit)
            {
                case "orange":
                    return new Orange();
                    break;

                case "apple":
                    return new Apple();
                    break;

                case "plum":
                    return new Plum();
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}