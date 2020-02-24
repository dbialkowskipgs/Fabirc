using Fabric.MethodFabric.Model;

namespace Fabric.MethodFabric.Factories
{
    public class KarotFactory : VegetablesFactory
    {
        public override IVegetables BuildVegetables()
        {
            return new Karot();
        }
    }
}