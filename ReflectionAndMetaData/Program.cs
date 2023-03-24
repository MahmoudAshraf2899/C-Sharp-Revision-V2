using System;

namespace ReflectionAndMetaData
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type t1 = DateTime.Now.GetType(); //At Run Time
            Console.WriteLine($"T1 At Run Time is : {t1}");
            Type t2 = typeof(DateTime); //At Compile Time
            Console.WriteLine($"T2 At Compile Time is : {t2}");
            Console.WriteLine($"T1 Full Name is : {t1.FullName}"); //NameSpace.TypeName

            //Using Reflection To Create instance
            Console.WriteLine($"Enemy : ");

            do
            {
                var input = Console.ReadLine();
                object obj = null;
                try
                {
                    var enemy = Activator.CreateInstance(typeof(Program).Assembly.GetName().Name, input);
                    obj = enemy.Unwrap();

                }
                catch
                {

                }
                switch (obj)
                {
                    case firstEnemy fE:
                        Console.WriteLine(fE);
                        break;
                    case secondEnemy sE:
                        Console.WriteLine(sE);
                        break;
                    case ThirdEnemy tE:
                        Console.WriteLine(tE);
                        break;

                    default:
                        Console.WriteLine("Un Known Enemy");
                        break;
                }
            } while (true);


            Console.ReadKey();
        }
    }
    public class firstEnemy
    {
        public override string ToString()
        {
            return $"{{Speed :  {20},  Hit Power : {13} , Strength : {7 }}}";
        }
    }
    public class secondEnemy
    {
        public override string ToString()
        {
            return $"{{Speed :  {25},  Hit Power : {12} , Strength : {9}}}";
        }
    }
    public class ThirdEnemy
    {
        public override string ToString()
        {
            return $"{{Speed :  {28},  Hit Power : {17} , Strength : {5 }}}";
        }
    }

}
