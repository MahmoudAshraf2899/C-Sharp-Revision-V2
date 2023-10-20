using Microsoft.VisualBasic;

var todoList = new List<DailyDuty>
{
    new DailyDuty("Clean House"),
    new DailyDuty("Wash Dishes"),
    new DailyDuty("Doing Laundry"),
    new DailyDuty("Preparing Meals"),
    new DailyDuty("Checking Emails")
};

//Console.WriteLine("Using Parallelism");
//await ProcessThingsInParallel(todoList);

//Console.WriteLine("Using Concurrency");
//await ProcessThingsInConcurrency(todoList);


Console.WriteLine("Using Asynchronous");
await ProcessInAsync(todoList);

Console.ReadKey();
static Task ProcessThingsInParallel(IEnumerable<DailyDuty> things)
{
    Parallel.ForEach(things, thing => thing.Process());
    return Task.CompletedTask;
}
static Task ProcessThingsInConcurrency(IEnumerable<DailyDuty> things)
{
    foreach (var item in things)
    {
        item.Process();
    }
    return Task.CompletedTask;

}
async Task ProcessInAsync(IEnumerable<DailyDuty> things)
{
    foreach (var item in things)
    {
        await item.ProcessAsync();
    }

}
class DailyDuty
{
    public string title { get; private set; }
    public bool proccessed { get; private set; }
    public DailyDuty(string title)
    {
        this.title = title;
    }

    public void Process()
    {
        Console.WriteLine($"TID = {Thread.CurrentThread.ManagedThreadId}" +
            $",processor id = {Thread.GetCurrentProcessorId()}");
        Task.Delay(100).Wait();
        this.proccessed = true;
    }
    public async Task ProcessAsync()
    {
        Console.WriteLine($"TID = {Thread.CurrentThread.ManagedThreadId}" +
           $",processor id = {Thread.GetCurrentProcessorId()}");
        await Task.Delay(100);
        this.proccessed = true;

    }

}
