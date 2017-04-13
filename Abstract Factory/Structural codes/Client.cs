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
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}