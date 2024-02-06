using FactoryMethod;

Console.Title = "Factory method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine(discountService.DiscountPercentage);
    Console.WriteLine(discountService.ToString());
}

Console.ReadKey();