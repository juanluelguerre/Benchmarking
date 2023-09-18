using static System.Console;

namespace ElGuerre.Benchmarking.AsyncAwait;

internal class RestaurantMediator
{
    public async Task TaskService()
    {
        var customer = new TaskCustomer();
        var chef = new TaskChef();
        var waiter = new TaskWaiter();

        WriteLine(await waiter.AskCustomer());
        WriteLine(await customer.DecideMenu());
        WriteLine("start cooking salad");
        WriteLine(await chef.CookSalad());
        var serveSalad = waiter.ServeSalad();
        WriteLine("start cooking chicken");
        var chicken = chef.CookChicken();
        WriteLine(await serveSalad);
        WriteLine(await customer.HaveSalad());
        WriteLine(await chicken);
        var serveChicken = waiter.ServeChicken();
        WriteLine("start cooking dessert");
        var dessert = chef.CookDessert();
        WriteLine(await serveChicken);
        WriteLine(await customer.HaveChicken());
        WriteLine(await dessert);
        WriteLine(await waiter.ServeDessert());
        WriteLine(await customer.HaveDessert());
        WriteLine(await waiter.Billing());
        WriteLine(await customer.Pay());
        WriteLine("--- Done ---");
    }

    public async Task AwaitService()
    {
        var customer = new AwaitCustomer();
        var chef = new AwaitChef();
        var waiter = new AwaitWaiter();

        WriteLine(await waiter.AskCustomer());
        WriteLine(await customer.DecideMenu());
        WriteLine("start cooking salad");
        WriteLine(await chef.CookSalad());
        var serveSalad = waiter.ServeSalad();
        WriteLine("start cooking chicken");
        var chicken = chef.CookChicken();
        WriteLine(await serveSalad);
        WriteLine(await customer.HaveSalad());
        WriteLine(await chicken);
        var serveChicken = waiter.ServeChicken();
        WriteLine("start cooking dessert");
        var dessert = chef.CookDessert();
        WriteLine(await serveChicken);
        WriteLine(await customer.HaveChicken());
        WriteLine(await dessert);
        WriteLine(await waiter.ServeDessert());
        WriteLine(await customer.HaveDessert());
        WriteLine(await waiter.Billing());
        WriteLine(await customer.Pay());
        WriteLine("--- Done ---");
    }
}
