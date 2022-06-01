using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;


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

#region Prototype
var person = new Person();
person.Name = "Vasko";
person.IdInfo = new IdInfo(123);
person.Age = 23;
person.BirthDate = new DateTime(1999,02,01);

var person2 = person.DeepCooy();
person2.Name = "Ivan";
person2.Age = 13;
person2.IdInfo = new IdInfo(321);
person2.BirthDate = new DateTime(2009, 01, 01);
Console.WriteLine();
Console.WriteLine(person.ToString());
Console.WriteLine();
Console.WriteLine(person2.ToString());

#endregion

#region Singleton
var firstInst = Singleton.GetInstance();
var secondInst = Singleton.GetInstance();
firstInst.InstanceName = "Vasko";
Console.WriteLine();
Console.WriteLine(firstInst.InstanceName);
Console.WriteLine();
Console.WriteLine(secondInst.InstanceName);
Console.WriteLine();

secondInst.InstanceName = "Veche ne e Vasko";
Console.WriteLine(firstInst.InstanceName);
Console.WriteLine();
Console.WriteLine(secondInst.InstanceName);
#endregion

void ClientCode(Logisticts creator)
{
    Console.WriteLine("Client: I'm not aware of the creator's class," +
    "but it still works.\n" + creator.SomeOperation());
}