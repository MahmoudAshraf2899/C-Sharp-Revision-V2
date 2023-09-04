
IEnumerable<int> list1 = new int[] { 2, 5, 6, 7, 9, 1, 3, 4, 8 };
Console.WriteLine("--Numbers Less Than Six--");
PrintNumbersLessThanSix(list1);
Console.WriteLine("--Numbers Less Than Pivot Number--");
PrintNumbersLessPivot(list1, e => e < 6);
Console.WriteLine("--Numbers Even--");
PrintEvenNumbers(list1, e => e % 2 == 0);

PrintNumbers(list1, e => e % 2 == 0);//Even Numbers
static void PrintNumbers<T>(IEnumerable<T> numbers, filterDelegate<T> filter)
{
    foreach (var item in numbers)
    {
        if (filter(item))
        {
            Console.WriteLine(item);
        }
    }
}
static void PrintNumbersLessThanSix(IEnumerable<int> numbers)
{
    foreach (var item in numbers)
    {
        if (item < 6)
        {
            Console.WriteLine(item);
        }
    }
}

static void PrintNumbersLessPivot<T>(IEnumerable<T> numbers, filterDelegate<T> filter)
{
    foreach (var item in numbers)
    {
        if (filter(item))
        {
            Console.WriteLine(item);
        }
    }
}


static void PrintEvenNumbers<T>(IEnumerable<T> numbers, filterDelegate<T> filter)
{
    foreach (var item in numbers)
    {
        if (filter(item))
        {
            Console.WriteLine(item);
        }
    }
}
public delegate bool filterDelegate<in T>(T number);