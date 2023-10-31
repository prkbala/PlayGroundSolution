

var ts = MyAsyncMethod();

Console.WriteLine("Outside of Async");

ts.Wait();

static async Task MyAsyncMethod()
{
    Console.WriteLine("Before await");
    await SomeAsyncOperation(); // This operation is asynchronous.
    Console.WriteLine("After await");
}

static async Task SomeAsyncOperation()
{
    Console.WriteLine("Starting SomeAsyncOperation");
    // Simulate an asynchronous delay of 5 seconds.
    await Task.Delay(5000);
    Console.WriteLine("SomeAsyncOperation completed");
}
