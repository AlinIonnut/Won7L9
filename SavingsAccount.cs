using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L9
{
    internal class SavingsAccount
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public double CurrentBalance {  get; set; }

        public double InteresRate { get; set; }

        public SavingsAccount(string name, double currentBalance, double interesRate) 
        {
            Id = Guid.NewGuid();
            Name = name;
            CurrentBalance = currentBalance;
            InteresRate = interesRate;
        }

        public void AddMoney(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("The amount The amount must be higher than 0!");
            }

            CurrentBalance += amount;

            CurrentBalance = CurrentBalance*(1+InteresRate);
        }
        public void TakeOutMoney(int amount)
        {
            if (amount > CurrentBalance)
            {
                throw new ArgumentException("The amount must be less than the current balance!");
            }

            CurrentBalance -= amount;
        }

        public override string ToString()
        {
            return $"Savings account informations: \n Identification number: {Id} \n Account holder: {Name} \n Current Balance: {CurrentBalance} \n Interes rate: {InteresRate*100}%";
        }
    }
}
