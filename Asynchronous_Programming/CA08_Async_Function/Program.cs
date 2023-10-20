//var task = Task.Run(() => ReadContent("https://www.youtube.com/watch?v=kDUDX3VJFEc&t=1605s"));
//var awaiter = task.GetAwaiter();
//awaiter.OnCompleted(() =>
//{
//    Console.WriteLine(awaiter.GetResult());
//});
var urlContent = await ReadContentAsync("https://www.youtube.com/watch?v=kDUDX3VJFEc&t=1605s");
Console.WriteLine(urlContent);
Console.ReadKey();

static Task<string> ReadContent(string url)
{
    var client = new HttpClient();
    var task = client.GetStringAsync(url);
    return task;
}

static async Task<string> ReadContentAsync(string url)
{
    var client = new HttpClient();

    var content = await client.GetStringAsync(url);

    return content;
}