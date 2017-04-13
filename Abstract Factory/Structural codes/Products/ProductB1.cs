using System;

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
    /// The 'ProductB1' class
    /// </summary>
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}

// Output:
// ProductB1 interacts with ProductA1
// ProductB2 interacts with ProductA2