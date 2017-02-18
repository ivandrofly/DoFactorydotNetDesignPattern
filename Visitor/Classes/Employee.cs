namespace DoFactory.GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    public abstract class Employee : IElement
    {
        private string _name;
        private double _income;
        private int _vacationDays;

        // Constructor
        public Employee(string name, double income, int vacationDays)
        {
            _name = name;
            _income = income;
            _vacationDays = vacationDays;
        }

        // Gets or sets the name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or sets income
        public double Income
        {
            get { return _income; }
            set { _income = value; }
        }

        // Gets or sets number of vacation days
        public int VacationDays
        {
            get { return _vacationDays; }
            set { _vacationDays = value; }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}