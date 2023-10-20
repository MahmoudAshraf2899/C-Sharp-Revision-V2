

//Console.WriteLine(countPrimeNumberInARange(2, 2_000_000));
//If we need to run the above code with task
Task<int> task = Task.Run(() => countPrimeNumberInARange(2, 2_000_000));
//Console.WriteLine(task.Result); //bad way because it block the thread until the above code finished..
var awaiter = task.GetAwaiter();
awaiter.OnCompleted(() =>
{
    Console.WriteLine(awaiter.GetResult()); // it also block the thread but task is completed

});
Console.WriteLine("Nabwy");
Console.ReadKey();
static int countPrimeNumberInARange(int lowerBound, int upperBound)
{
    var count = 0;
    for (int i = lowerBound; i < upperBound; i++)
    {
        var j = lowerBound;
        var isPrime = true;

        while (j <= (int)Math.Sqrt(i))
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
            ++j;
        }
        if (isPrime)
        {
            count++;
        }

    }
    return count;
}