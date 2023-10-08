//int n1 = 10;
//int n2 = 10;
//Console.WriteLine(n1.Equals(n2));//true

//string s1 = "Nabwy";
//string s2 = "Nabwy";
//Console.WriteLine(s1.Equals(s2)); //true

//Checking Account (Daily Withdraw limit = 5000)
//Saving Account (Daily Withdraw limit =2000)


abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; } // Refer to Credit
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
     
}
class CheckingAccount : BankAccount
{
    public override void Deposit(decimal amount)
    {
        throw new NotImplementedException();
    }

    public override void Withdraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}
class SavingAccount
{

}
