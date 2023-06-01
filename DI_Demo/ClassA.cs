public class ClassA
{
    private readonly IThing _dependency;

    public ClassA(IThing dependency)
    {
        _dependency = dependency;
    }

    public void Work() => _dependency.DoStuff();
}