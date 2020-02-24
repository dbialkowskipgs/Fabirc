using Fabric.MethodFabric.Model;

namespace Fabric.MethodFabric.Factories
{
    public class CucumberFactory : VegetablesFactory
    {
        public override IVegetables BuildVegetables()
        {
            return new Cucumber();
        }
    }
}