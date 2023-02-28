using ProjectOne.Classes;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectOne
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //Arrays Are Reference Type

            #region  Single Dimensional Array
            //string[] friends = new string[5];//Friends Will be stored in Stach and The Five Elements will be in Heap
            //friends[0] = "Mahmoud";
            //friends[1] = "Ashraf";
            //friends[2] = "Mohamed";
            //friends[3] = "Elnabwy";
            //friends[4] = "Radwan";
            //Console.WriteLine("Friends :", friends);
            #endregion
            Console.WriteLine("-------------------------");

            #region Multi Dimensional Array [rectangular array]

            //int[,] suduko =
            //{
            //    {9,6,2,1,4,7,3,7,8 },
            //    {1,8,5,1,4,7,3,7,8 },
            //    {5,3,1,1,4,7,3,7,8 },
            //    {6,9,4,1,4,7,3,7,8 },
            //    {3,7,4,1,4,7,3,7,8 },
            //    {8,2,7,1,4,7,3,7,8 },
            //    {4,9,6,1,4,7,3,7,8 },
            //    {2,1,8,1,4,7,3,7,8 },
            //    {7,5,3,1,4,7,3,7,8 },
            //};
            //foreach (var item in suduko)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------");

            #endregion

            #region Jagged Array
            ////Jagged Array => Array Inside Array
            //var jagged = new int[][]
            //{
            //    new int [] {1,2},
            //    new int [] {2,5,6},
            //    new int [] { 7,3  }
            //};
            //Console.WriteLine("jagged[1][0]: " + jagged[1][0]);//1 Refer To Array Of Index 1 || 0 Refer to first index in Array Of Index one
            //Console.WriteLine("-------------------------");

            #endregion

            #region Indices And Ranges
            //var subject = new string[] { "Math", "Introduction TO CS", "Logic Design", "Operating System" };
            //var first = subject[0]; //Indices مؤشر
            //Console.WriteLine($"First : {first}");
            //Console.WriteLine("-------------------------");
            //var slicefirstTwoElements = subject[..2]; //Slice => It Will Return just first two elements
            //foreach(var item in slicefirstTwoElements)
            //    Console.WriteLine($"slicefirstTwoElements : {item}");
            //Console.WriteLine("-------------------------");

            //var skipFirstTwoElements = subject[2..];
            //foreach(var element in skipFirstTwoElements)
            //    Console.WriteLine($"skipFirstTwoElements : {element}");
            //Console.WriteLine("-------------------------");

            //var startFromTwoAndTakeUntilThree = subject[2..3];
            //foreach(var element in startFromTwoAndTakeUntilThree)
            //    Console.WriteLine($"startFromTwoAndTakeUntilThree : {element}");
            //Console.WriteLine("-------------------------");

            ////We Here Start From End Of Array 
            ////Because We Use ^ (Shapo)
            ////And It Make Us Count From 1 Not Zero Index..
            //var array = new string[] { "A", "B", "C", "D", "E", "F" };
            //var shapo = array[2..^2];
            //foreach (var item in shapo)
            //    Console.WriteLine($"Shapo : {item}");
            //Console.WriteLine("-------------------------");




            #endregion

            #endregion

            #region Expressions 
            //Null In Memory
            //S1 Will be stored in Stack But its clear value in Heap 
            //string s1 = null;
            //string s2 = s1?.ToUpper(); //IF S1 is Null Return Null Else Make The Value To Upper
            //Console.WriteLine(s2);
            //Console.WriteLine("-------------------------");


            ////Switch Statement In C# 8 
            //var cardNo = 8;
            //var cardName = cardNo switch
            //{
            //    1 => "A",
            //    2 => "B",
            //    3 => "C",
            //    4 => "D",
            //    5 => "E",
            //    6 => "F",
            //    7 => "G",
            //    8 => "H",
            //    _ => "NotFound"
            //};
            //Console.WriteLine($"card Name : {cardName}");
            //Console.WriteLine("-------------------------");
            //for (int i = 0; i <=10; i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine($"I : {i} ");
            //    Console.WriteLine("-------------------------");
            //}
            #endregion

            #region Casting / Type Conversion
            //Implicit Conversion 
            //int x = 10;
            //string str = x; //We Cannot Do That because c# is Strongly Types Language

            //We Can Convert Value Type To Reference Type in Implicity Way
            //int x = 10; //Value Type
            //Object obj; //Reference Type
            ////حطيت الاكس جوا الأوبجيكت
            //obj = x; //Boxing : From Value To Reference 
            //int y = (int)obj; //UnBoxing : From Reference To Value


            ////Convert from String To Number
            //string stringValue = "120";
            ////First By Using type.Parse
            //int number = int.Parse(stringValue); // It Will Parse Correctly 
            //string strongValue = "w150";
            //int number2 = int.Parse(strongValue); // It Will Got Exception Error
            //if (int.TryParse(strongValue, out int number3))
            //{
            //    Console.WriteLine($"Try Parse Result{number3}");
            //    Console.WriteLine("-------------------------");
            //}
            //else
            //    Console.WriteLine($"InValid Number Format");

            ////Second By Using Convert Class
            //var number4 = Convert.ToInt32(strongValue); //Exception
            ////Int.Parse is The best Performance 

            ////Bit Converter
            //var number5 = 255;
            //var bytes = BitConverter.GetBytes(number5);
            //foreach (var item in bytes)
            //{
            //    Console.WriteLine($"Bytes Converter Result : {item}");
            //}
            #endregion

            #region OOP

            #region Field & Constant
            //const double TAX = 0.03;

            //Console.Write("First Name : ");
            //var fName = Console.ReadLine();
            //Console.Write("last Name : ");
            //var lName = Console.ReadLine();
            //Console.Write("Wage :");
            //var wage = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Logged Hours :");
            //var loggedHours = Convert.ToDouble(Console.ReadLine());
            //var netSalary = wage * loggedHours - (wage * loggedHours * TAX);
            //Console.WriteLine($"First Name is {fName}");
            //Console.WriteLine($"Last Name is {lName}");
            //Console.WriteLine($"Wage is {wage}");
            //Console.WriteLine($"Logged Hours is {loggedHours}");
            //Console.WriteLine($"Net Salary is {netSalary}");

            ////4 Principles of Object-Oriented Programming
            ////1- Encapsulation التحزيم او التغليف
            ////2- Inheritance الوراثة 
            ////3- Polymorphism تعدد الاشكال
            ////4- Abstraction التجريد

            ////Object is an instance of a class.
            ////Employee empObj; //Decleration
            //Employee empObj = new Employee();
            //empObj.fName = Console.ReadLine();
            //empObj.lName = Console.ReadLine();
            //empObj.wage = Convert.ToDouble(Console.ReadLine());
            //empObj.loggedHours = Convert.ToDouble(Console.ReadLine());

            ////What Happend In Memory ?
            ////Ans : in Stack we store empObj 
            ////in Heap We Store The Values
            ////So The Class and Object are reference type ^_^

            //var newNetSalary = empObj.wage * empObj.loggedHours - (empObj.wage * empObj.loggedHours * Employee.TAX);
            //Console.WriteLine($"Object First Name is {empObj.fName}");
            //Console.WriteLine($"Object Last Name is {empObj.lName}");
            //Console.WriteLine($"Object Wage is {empObj.wage}");
            //Console.WriteLine($"Object Logged Hours is {empObj.loggedHours}");
            //Console.WriteLine($"Object Net Salary is {newNetSalary}");


            #endregion

            #region Methods
            //var  NetSalary = 0.0;
            //Employee[] emps = new Employee[2];
            //Console.WriteLine("TAX :");
            //Employee.TAX = Convert.ToDouble(Console.ReadLine());
            //Employee emp1 = new Employee();
            //Console.WriteLine("First Names Is :");
            //emp1.fName = Console.ReadLine();
            //Console.WriteLine("Last Names Is :");
            //emp1.lName = Console.ReadLine();
            //Console.WriteLine("Wage Is :");
            //emp1.wage = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Logged Hours Is :");
            //emp1.loggedHours = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("\nSecond Employee");
            //Employee emp2 = new Employee();
            //Console.WriteLine("First Names Is :");
            //emp2.fName = Console.ReadLine();
            //Console.WriteLine("Last Names Is :");
            //emp2.lName = Console.ReadLine();
            //Console.WriteLine("Wage Is :");
            //emp2.wage = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Logged Hours Is :");
            //emp2.loggedHours = Convert.ToDouble(Console.ReadLine());
            //emps[0] = emp1;
            //emps[1] = emp2;  
            //foreach (var emp in emps)
            //{
            //    NetSalary = emp.wage * emp.loggedHours - (emp.wage * emp.loggedHours * Employee.TAX);
            //}

            //Console.WriteLine($"Total Net Salary is : {NetSalary}");
            //The Difference between Static and Constant
            //Ans :
            //Static : قيمته ثابته للجميع ولكن اقدر اغيرها
            //Constant : قيمته ثابته للجميع لكن مقدرش اغيرها

            //Demo demo = new Demo();
            ////var age = 18;
            ////demo.doSomething(ref age);
            ////Console.WriteLine($"Age After Reference : {age}"); //Age Will be 21 because we use ref else it will be 18
            //double promote = 50.0;
            //string trip = "Turkey";
            //string hotel = "Kembiniski";
            //demo.promoteIncrease(promote,trip,hotel);

            #endregion

            #region Constructor
            //لو استخدمت برايفت كونستراكتور 
            //علشان اوصله لازم يكون عندي ستاتيك ميثود
            // لو عملت ال fields في ال class خليتها private ف مش هقدر اوصل للقيم دي الا عن طريق ال constructor ودا بيديني security افضل
            //Date date = new Date(01,01,1999);




            #endregion


            #region Property & Encapsulation
            //Property Promote Encapsulation بتعزز التغليف
            //Get : Allow Us To Read The Value of the Property
            //Set : Allow Us To Assign Value To The Property
            //Dollar dollar = new Dollar(1.95m);
            //dollar.Amount = 1.99m;
            //Console.WriteLine($"Get : {dollar.Amount}");
            //dollar.Amount = 12.5m;
            //Console.WriteLine($"Set : {dollar.Amount}");
            #endregion

            #region Indexers
            //int[] array = { 0, 1, 2 };
            //array[0] = 10; //0 is Index
            ////int data type doesn't has indexers
            //var ip = new IPAddress(119, 125, 451, 122);
            //Console.WriteLine($"IP :{ip.Address}");
            #endregion

            #region Delegates
            //var emps = new Employee[]
            //{
            //    new Employee {Id=1,Name="Mahmoud A",Gender="Male",totalSales =9000m},
            //    new Employee {Id=2,Name="Ahmed B",Gender="Male",totalSales =9500m},
            //    new Employee {Id=3,Name="Esraa C",Gender="Female",totalSales =7000m},
            //    new Employee {Id=4,Name="Ramadan D",Gender="Male",totalSales =8000m},
            //    new Employee {Id=6,Name="Ali E",Gender="Male",totalSales =12000m},
            //    new Employee {Id=7,Name="Moustafa F",Gender="Male",totalSales =7000m},
            //    new Employee {Id=5,Name="Ayman G",Gender="Male",totalSales =4500m},
            //    new Employee {Id=8,Name="Ashraqt F",Gender="Female",totalSales =6000m},
            //};
            //var report = new Report();

            //report.processEmployee(emps, "Employees With 6000 Plus Sales and Smalles Than 9000", IsGreaterThan6000AndSmallerThan9000);

            //report.processEmployee(emps, "Employees With 5000 Plus Sales ", IsGreaterThanOrEqual5000);
            ////Another Way
            //report.processEmployee(emps, "Employees With 5000 Plus Sales ", delegate (Employee e) { return e.totalSales > 5000m; });
            ////Another Way With Lambda Expression
            //report.processEmployee(emps, "Employees With 5000 Plus Sales ", (Employee e) => e.totalSales > 5000m);
            ////Another Way (احنا بعتنا الكلاس بتاع هناك في الكلاس فا ممكن نشيله خالص من هنا employee  )
            //report.processEmployee(emps, "Employees With 5000 Plus Sales ", e => e.totalSales > 5000m);



            //report.processEmployee(emps, "Employees Less Than 5000", IsLessThan5000);
            #endregion

            #region Events
            //var stock = new Stock("Amazon");
            //stock.Price = 100;
            //stock.onPriceChanged += Stock_onPriceChanged;
            //stock.ChangeStockPrice(0.05m);
            //stock.ChangeStockPrice(-0.03m);
            //stock.ChangeStockPrice(0.00m);
            ////Un Subscripe From Event
            //stock.onPriceChanged -= Stock_onPriceChanged;
            //stock.ChangeStockPrice(0.04m);
            //stock.ChangeStockPrice(0.03m);
            #endregion

            #region Operator Overloading
            //Money m1 = new Money(10.5m);
            //Money m2 = new Money(20);
            ////Console.WriteLine($"Money One : {m1.Amount} , Money Two : {m2.Amount}");
            //Money m3 = m1 + m2;
            //Console.WriteLine($"Money Three Using Operator : {m3.Amount}");
            #endregion

            #region Struct
            //Student student = new Student();
            //long age = 99999999999999;
            //long age1 = 99999999999999;
            //long age2 = 99999999999999;
            //long age3 = 99999999999999;
            //long age4 = 99999999999999;
            //long age5 = 99999999999999;
            //student.show(age,age1,age2,age3,age4,age5);
            #endregion

            #region ENUM

            //Console.WriteLine($"Enum is {Month.JAN}");
            //var day = "FEB";
            //if(Enum.TryParse(day,out Month month))
            //{

            //    Console.WriteLine(Enum.Parse(typeof(Month),day));
            //    Console.WriteLine("--------------------------------------");
            //}

            #endregion

            #region Inheritance
            //Eagle eagle = new Eagle();
            //eagle.Move();

            var e = new Eagle();
            Animal a = e;

            #endregion
            #endregion
            Console.ReadLine();
        }

        private static void Stock_onPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

            }
            Console.WriteLine($"{stock.Name} : {stock.Price}");
        }

        public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
        static bool IsGreaterThanOrEqual5000(Employee e) => e.totalSales > 6000m;
        static bool IsGreaterThan6000AndSmallerThan9000(Employee e) => e.totalSales > 6000m && e.totalSales < 9000;
        static bool IsLessThan5000(Employee e) => e.totalSales < 5000m;


        public class Animal
        {
            public void Move()
            {
                Console.WriteLine("Moving");
            }
        }
        public class Eagle : Animal
        {
            public void Flying()
            {
                Console.WriteLine("Flying");
            }
        }
    }
}