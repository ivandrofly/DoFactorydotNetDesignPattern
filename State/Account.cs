using System;

namespace DoFactory.GangOfFour.State.RealWorld
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        private State _state;
        private string _owner;

        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            _owner = owner;
            _state = new SilverState(0.0, this);
        }

        // Properties
        public double Balance => _state.Balance;

        public State State { get => _state; set => _state = value; }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}", State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}\n", State.GetType().Name);
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status = {0}\n", State.GetType().Name);
        }
    }
}
