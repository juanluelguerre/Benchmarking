namespace ElGuerre.Benchmarking.AsyncAwait;

internal class TaskChef
{
    public Task<string> CookSalad()
    {
        Task.Delay(10).Wait();
        return Task.FromResult("Cooking salad ...");
    }

    public Task<string> CookChicken()
    {
        Task.Delay(30).Wait();
        return Task.FromResult("cooking chicken ...");
    }

    public Task<string> CookDessert()
    {
        Task.Delay(5).Wait();
        return Task.FromResult("cooking cake ...");
    }
}

internal class AwaitChef
{
    public async Task<string> CookSalad()
    {
        await Task.Delay(30);
        return "Salad ready";
    }

    public async Task<string> CookChicken()
    {
        await Task.Delay(50);
        return "Chicken ready";
    }

    public async Task<string> CookDessert()
    {
        await Task.Delay(20);
        return "Cake ready";
    }
}
