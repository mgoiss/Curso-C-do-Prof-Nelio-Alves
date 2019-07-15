using Topico_11.Entities.Exceptions;

namespace Topico_11.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance ,double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Valor solicitado excede o limite de Saque!");
            }

            if(amount > Balance)
            {
                throw new DomainException("Valor solicitado excede o seu Saldo!");
            }

            Balance -= amount;
        }
    }
}
