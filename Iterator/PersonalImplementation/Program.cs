// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var myEnumerable = new Enumerable2<int?>();

myEnumerable.Push(1);
myEnumerable.Push(2);
myEnumerable.Push(3);
myEnumerable.Push(4);
myEnumerable.Push(5);
myEnumerable.Push(6);

myEnumerable.PrintContent();

myEnumerable.ForEach2(x =>
{
    System.Console.Write(x * x);
    System.Console.Write(" ");
});

