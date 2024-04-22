using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L9
{
    internal class CurrentAccount
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CurrentBalance { get; set; }

        public CurrentAccount(string name, int currentBalance)
        {
            Id = Guid.NewGuid();
            Name = name;
            CurrentBalance = currentBalance;
        }

        public void AddMoney(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("The amount must be higher than 0!");
            }

            CurrentBalance += amount;
        }

        public void TakeOutMoney(int amount)
        {
            if(amount > CurrentBalance)
            {
                CurrentBalance += 5000;
            }
            if(amount > CurrentBalance)
            {
                throw new ArgumentException("The amount must be less than the current sold!");
            }

            CurrentBalance -= amount;
        }

        public override string ToString()
        {
            return $"Current account informations: \n Identification number: {Id} \n Account holder: {Name} \n Current Balance: {CurrentBalance}";
        }
    }
}
