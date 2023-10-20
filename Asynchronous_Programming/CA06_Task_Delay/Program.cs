
DelayUsingTask(5);

static void DelayUsingTask(int ms)
{
    //Create task after number of ms
    Task.Delay(ms);
    Console.WriteLine("Completed after Task.Delay" + ms);
}
static void sleepUsingThread(int ms)
{
    Thread.Sleep(ms);
    Console.WriteLine("Completed after Thread.Sleep" + ms);

}