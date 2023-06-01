// See https://aka.ms/new-console-template for more information
// REF : https://www.stevejgordon.co.uk/aspnet-core-dependency-injection-what-is-the-iservicecollection

using System.Threading.Channels;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<ClassA>();
serviceCollection.AddSingleton<IThing, ClassB>();

var sp = serviceCollection.BuildServiceProvider();

var a = sp.GetService<ClassA>();

a?.Work();

Console.WriteLine("done");