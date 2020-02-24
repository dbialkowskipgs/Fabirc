using System;
using System.Collections.Generic;
using System.Text;
using Fabric.AbstractFabric;
using Fabric.AbstractFabric.Common;
using Fabric.AbstractFabric.ExternalAudit;
using Fabric.AbstractFabric.InternalAudit;
using Fabric.MethodFabric;
using Fabric.MethodFabric.Factories;
using Fabric.SimpleFabric;

namespace Fabric
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //simply fabric
            Console.WriteLine("Simply Fabric:");
            Console.WriteLine(Environment.NewLine);

            FruitsFactory fruitsfactory = new FruitsFactory();
            IFruits orange = fruitsfactory.CreateFruitInstance("orange");
            IFruits apple = fruitsfactory.CreateFruitInstance("apple");
            IFruits plum = fruitsfactory.CreateFruitInstance("plum");

            Console.WriteLine("Fruits:");
            Console.WriteLine(orange.DisplayType());
            Console.WriteLine(apple.DisplayType());
            Console.WriteLine(plum.DisplayType());
            Console.WriteLine(Environment.NewLine);

            //method fabric
            Console.WriteLine("Method Fabric:");
            Console.WriteLine(Environment.NewLine);

            VegetablesFactory karotFactory = new KarotFactory();
            IVegetables karot = karotFactory.BuildVegetables();

            VegetablesFactory potatoFactory = new PotatoFactory();
            IVegetables potato = potatoFactory.BuildVegetables();

            VegetablesFactory cucumberFactory = new CucumberFactory();
            IVegetables cucumber = cucumberFactory.BuildVegetables();

            Console.WriteLine("Vegetables:");
            Console.WriteLine(karot.DisplayVegetable());
            Console.WriteLine(potato.DisplayVegetable());
            Console.WriteLine(cucumber.DisplayVegetable());
            Console.WriteLine(Environment.NewLine);

            //abstract fabric
            Console.WriteLine("Abstract Fabric:");
            Console.WriteLine(Environment.NewLine);

            AuditConstruction auditConstruction;

            auditConstruction = new AuditConstruction(new InternalAuditFactory());
            auditConstruction.MakeAudit();

            auditConstruction = new AuditConstruction(new ExternalAuditFactory());
            auditConstruction.MakeAudit();

            Console.ReadKey();
        }
    }
}