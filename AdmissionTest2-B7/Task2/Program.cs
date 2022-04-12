using Task2;

DataMerge dataMerge = new();
dataMerge.CustomerList = new();
dataMerge.OrderList = new();

dataMerge.CustomerList.Add(new Customer { Id = 1, Name = "Person1", Address = "Dhaka" });
dataMerge.CustomerList.Add(new Customer { Id = 2, Name = "Person2", Address = "Sylhet" });
dataMerge.CustomerList.Add(new Customer { Id = 3, Name = "Person3", Address = "Khulna" });

dataMerge.OrderList.Add(new Order
{
    CustomerId = 3,
    Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 2, Name = "Laptop", Price = 50000 },
                new Product { Id = 3, Name = "Monitor", Price = 6000 },
            }
});
dataMerge.OrderList.Add(new Order
{
    CustomerId = 2,
    Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 4, Name = "Keyboard", Price = 500 },
                new Product { Id = 5, Name = "Mouse", Price = 100 },
            }
});
dataMerge.OrderList.Add(new Order
{
    CustomerId = 3,
    Products = new List<Product> {
                new Product { Id = 1, Name = "Camera", Price = 13000 },
                new Product { Id = 6, Name = "Pend Drive", Price = 300 },
                new Product { Id = 3, Name = "Monitor", Price = 6000 },
            }
});

var result = dataMerge.GetInfo();

foreach (var item in result)
{
    Console.WriteLine(item.customerName);
    foreach (var product in item.productNames)
    {
        Console.WriteLine(product);
    }
    Console.WriteLine("---------------------------");
}

