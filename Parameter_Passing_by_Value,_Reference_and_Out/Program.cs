
#region Pass By Value
//var num1 = 5;
//int passByValue(int number)
//{
//    number = number * 2;
//    return number;
//}
//Console.WriteLine($"Number Before passByValue Method Is {num1}");

//passByValue(num1);
//Console.WriteLine($"Number After passByValue Method Is {num1}"); 
#endregion

#region Pass By Reference
//int number = 5;
//int passByRef(ref int number)
//{
//    number = number * 2;
//    return number;
//}
//Console.WriteLine($"Number Before passByRef Method Is {number}");
//passByRef(ref number);
//Console.WriteLine($"Number After passByRef Method Is {number}");

#endregion

#region Pass By Out
int number = 5;
int passByOut(out int number)
{
    //In Out Variable Should have value inside the method before any operation on it        
    number = 5;
    number = number * 2;
    return number;
}
Console.WriteLine($"Number Before passByOut Method Is {number}");
passByOut(out number);
Console.WriteLine($"Number After passByOut Method Is {number}");
#endregion