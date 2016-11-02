namespace DoFactory.GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
