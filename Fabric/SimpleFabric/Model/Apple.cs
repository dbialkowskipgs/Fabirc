namespace Fabric.SimpleFabric.Model
{
    internal class Apple : IFruits
    {
        public string DisplayType()
        {
            return "Apple";
        }
    }

    //Złamanie zasady open-closed: dodanie nowej klasy oraz utworzenie jej instancji wymaga modyfikacji klasy ProductsFactory
}