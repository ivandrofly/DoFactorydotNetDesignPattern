/// <summary>
/// Creates an instance of several families of classes.
/// 
/// Provide an interface for creating families of related or
/// dependent objects without specifying their concrete classes.
/// 
/// Frequence of use: 5 high.
/// </summary>
namespace DoFactory.GangOfFour.Abstract.Structural
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}