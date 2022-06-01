using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;


#region FactoryMethod

Console.WriteLine("App: Launched with the ConcreteCreator1.");
ClientCode(new RoadLogistics());

Console.WriteLine("App: Launched with the ConcreteCreator2.");
ClientCode(new SeaLogistics());

#endregion

#region AbstractFactory

Console.WriteLine();
Console.WriteLine();
var client = new Client();
client.Main();
#endregion

#region Builder

var builder = new ConcreteBuilder();
var director = new Director();

director.Builder = builder;
Console.WriteLine();
Console.WriteLine();
director.BuildMinimalVaiableProduct();

Console.WriteLine(builder.GetProduct().ListParts());
Console.WriteLine();

director.BuildMaxVaiableProduct();

Console.WriteLine(builder.GetProduct().ListParts());

#endregion

void ClientCode(Logisticts creator)
{
    Console.WriteLine("Client: I'm not aware of the creator's class," +
    "but it still works.\n" + creator.SomeOperation());
}