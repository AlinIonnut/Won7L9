using Won7L9;

CurrentAccount AlinAccount = new CurrentAccount("Alin", 250);
CurrentAccount IonutAccount = new CurrentAccount("Ionut", 300);
SavingsAccount AlinSavings = new SavingsAccount("Alin", 300, 0.05);
InvestmentAccount AlinInvestment = new InvestmentAccount("Alin", 50, 20);

AlinAccount.AddMoney(50);
AlinAccount.TakeOutMoney(4300);

AlinSavings.AddMoney(50);

AlinInvestment.TakeOutMoney(20);

Console.WriteLine(AlinAccount.ToString());
Console.WriteLine(IonutAccount.ToString());
Console.WriteLine(AlinSavings.ToString());
Console.WriteLine(AlinInvestment.ToString());

