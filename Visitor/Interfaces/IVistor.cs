namespace DoFactory.GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
