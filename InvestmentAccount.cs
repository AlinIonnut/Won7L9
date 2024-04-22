using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L9
{
    internal class InvestmentAccount
    {
        private int _withdrawalDay;
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public int CurrentBalance { get; set; }
        public int WithdrawalDay { get => _withdrawalDay; set
            {
                if (value < 1 || value > 31)
                {
                    throw new ArgumentException("Withdrawal day must be between 1 and 31.");
                }
                _withdrawalDay = value;
            }
        } 

        public InvestmentAccount(string name, int currentBalance, int withdrawalDay)
        {
            Id = Guid.NewGuid();
            Name = name;
            CurrentBalance = currentBalance;
            WithdrawalDay = withdrawalDay;
        }


        public void AddMoney(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("The amount The amount must be higher than 0!");
            }
            CurrentBalance += amount;
        }

        public void TakeOutMoney(int amount)
        {
            if (amount > CurrentBalance)
            {
                throw new ArgumentException("The amount must be less than the current balance!");
            }
            if(DateTime.Now.Day < WithdrawalDay)
            {
                throw new ArgumentException($"Your must wait till the withdrawal day, witch is in {WithdrawalDay - DateTime.Now.Day}");
            }

            CurrentBalance -= amount;
        }

        public override string ToString()
        {
            return $"Investment account informations: \n Identification number: {Id} \n Account holder: {Name} \n Current Balance: {CurrentBalance} \n Withdrawal day: {WithdrawalDay}";
        }
    }
}
