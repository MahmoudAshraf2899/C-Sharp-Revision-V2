using System;

namespace ProjectOne
{
    //public class Demo
    //{
    //    //Method Syntax (Simple)
    //    //What is The Difference Between Argumment and Parameters
    //    //Ans :
    //    //Argument : is What We Send in Method Implementation
    //    //Parameter : is What We Send in Method Defination
    //    public void doSomething(ref int age)
    //    {
    //        age = age + 3;
    //    }

    //    //Method OverLoading (A Common way of implementing Polymorpishm)
    //    public void promoteIncrease(double amount)
    //    {
    //        Console.WriteLine($"You Got A promotion Of {amount} ");
    //    }
    //    public void promoteIncrease(double amount, string trip)
    //    {
    //        Console.WriteLine($"You Got A promotion Of {amount} and a trip {trip}  ");
    //    }
    //    public void promoteIncrease(double amount, string trip ,string hotel)
    //    {
    //        Console.WriteLine($"You Got A promotion Of {amount} and a trip {trip} with {hotel} ");
    //    }
    //    //public bool isEven(int number)
    //    //{
    //    //    return number % 2 == 0;
    //    //}
    //    public bool isEven(int number) => number % 2 == 0;
    //}
    public class Dollar
    {
        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = processValue(value);
            }
        }
        public Dollar(decimal amount)
        {
            this._amount = processValue(amount);
        }
        private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);


    }
}