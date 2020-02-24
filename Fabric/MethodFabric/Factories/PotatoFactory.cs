using Fabric.MethodFabric.Model;

namespace Fabric.MethodFabric.Factories
{
    public class PotatoFactory : VegetablesFactory
    {
        public override IVegetables BuildVegetables()
        {
            return new Potato();
        }
    }
}