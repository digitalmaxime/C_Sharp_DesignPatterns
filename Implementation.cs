namespace FactoryMethod;

public abstract class DiscountService
{
    public override string ToString() => GetType().Name;
    public abstract int DiscountPercentage { get; }
}

public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }


    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case "BE":
                    return 20;
                default:
                    return 10;
            }
        }
    }
}

public class CodeDiscountService : DiscountService
{
    private readonly string _code;

    public CodeDiscountService(string code)
    {
        _code = code;
    }


    public override int DiscountPercentage
    {
        get => 15;
    }
}

public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}

public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryIdentifier;

    public CountryDiscountFactory(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }
    
    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}


public class CodeDiscountFactory : DiscountFactory
{
    private readonly string _code;

    public CodeDiscountFactory(Guid code)
    {
        _code = code.ToString();
    }
    
    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_code);
    }
}

