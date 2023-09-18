namespace ElGuerre.Benchmarking.AsyncAwait;

internal class TaskCustomer
{
    public Task<string> DecideMenu()
    {
        Task.Delay(30).Wait();
        return Task.FromResult("Menu");
    }

    public Task<string> HaveSalad()
    {
        Task.Delay(50).Wait();
        return Task.FromResult("Salad");
    }

    public Task<string> HaveChicken()
    {
        Task.Delay(50).Wait();
        return Task.FromResult("Chicken");
    }

    public Task<string> HaveDessert()
    {
        Task.Delay(20).Wait();
        return Task.FromResult("Cake");
    }

    public Task<string> Pay()
    {
        Task.Delay(10).Wait();
        return Task.FromResult("The bill is payed");
    }
}

internal class AwaitCustomer
{
    public async Task<string> DecideMenu()
    {
        await Task.Delay(30);
        return "Menu";
    }

    public async Task<string> HaveSalad()
    {
        await Task.Delay(50);
        return "Salad";
    }

    public async Task<string> HaveChicken()
    {
        await Task.Delay(50);
        return "Chicken";
    }

    public async Task<string> HaveDessert()
    {
        await Task.Delay(20);
        return "Cake";
    }

    public async Task<string> Pay()
    {
        await Task.Delay(10);
        return "The bill is payed";
    }
}
