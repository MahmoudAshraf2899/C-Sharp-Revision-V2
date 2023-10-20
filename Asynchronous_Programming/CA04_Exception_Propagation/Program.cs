try
{
    var th = new Thread(ThrowException);
    th.Start();
    th.Join();
    ThrowException();
}
catch
{
    Console.WriteLine("Exception is Thrown!!");
    throw;
}
Console.ReadKey();

static void ThrowException()
{
    throw new NullReferenceException();
}
