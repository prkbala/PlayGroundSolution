
await TaskExecutor(SendDeviceDetails);

Console.WriteLine("Spun a task and continuing");

await RunTask();

Thread.Sleep(15000);
var test = "sdf";

async Task RunTask()
{
    await Task.Run(
        () =>
        {
            Thread.Sleep(10000);
        });
}

void SendDeviceDetails()
{
    Thread.Sleep(10000);
}

async Task TaskExecutor(Action action)
{
    await Task.Run(
        () =>
        {
            Console.WriteLine("Executing Task");
            action();
        });
}