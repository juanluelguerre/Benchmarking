namespace ElGuerre.Benchmarking.AsyncAwait;

internal class TaskWaiter
{
    public Task<string> AskCustomer()
    {
        Task.Delay(10).Wait();
        return Task.FromResult("Customer ready");
    }

    public Task<string> ServeSalad()
    {
        Task.Delay(5).Wait();
        return Task.FromResult("Salad served");
    }

    public Task<string> ServeChicken()
    {
        Task.Delay(5).Wait();
        return Task.FromResult("Chicken served");
    }

    public Task<string> ServeDessert()
    {
        Task.Delay(5).Wait();
        return Task.FromResult("Cake served");
    }

    public Task<string> Billing()
    {
        Task.Delay(10).Wait();
        return Task.FromResult("The bill");
    }
}

internal class AwaitWaiter
{
    public async Task<string> AskCustomer()
    {
        await Task.Delay(10);
        return "Customer ready";
    }

    public async Task<string> ServeSalad()
    {
        await Task.Delay(5);
        return "Salad served";
    }

    public async Task<string> ServeChicken()
    {
        await Task.Delay(5);
        return "Chicken served";
    }

    public async Task<string> ServeDessert()
    {
        await Task.Delay(5);
        return "Cake served";
    }

    public async Task<string> Billing()
    {
        await Task.Delay(10);
        return "The bill";
    }
}
