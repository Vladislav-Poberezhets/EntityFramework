using EntityFramework;

using (ApplicationsContext db = new ApplicationsContext())
{
    
    var employees = db.Employees.ToList();
    Console.WriteLine("Employees list:");
    foreach (Employees u in employees)
    {
        Console.WriteLine($"{u.Id}.{u.FirstName} - {u.SecondName } ");
    }

    var customers = db.Customers.ToList();
    Console.WriteLine("Customers list:");

    foreach (Customers c in customers)
    {
        Console.WriteLine($"{c.Id}. {c.FirstName} - {c.SecondName} - {c.Email} - {c.PhoneNumber}");
    }

    var products = db.Products.ToList();
    Console.WriteLine("Products list:");

    foreach (Products p in products)
    {
        Console.WriteLine($"{p.Id}. {p.Name} - {p.Cost} - {p.Quantity}");
    }

    var orders = db.Orders.ToList();
    Console.WriteLine("Orders list:");

    foreach (Orders o in orders)
    {
        Console.WriteLine($"{o.Id}. CustomerID:{o.CustomerId}  Name: {o.Customer.FirstName}  ProductId: {o.ProductId} - {o.Product.Name}  Quantity: {o.Quantity}  Cost: {o.Cost}");
    }




}