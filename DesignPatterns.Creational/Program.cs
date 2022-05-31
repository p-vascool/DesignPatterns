﻿using DesignPatterns.Creational.AbstractFactory;
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

void ClientCode(Logisticts creator)
{
    Console.WriteLine("Client: I'm not aware of the creator's class," +
    "but it still works.\n" + creator.SomeOperation());
}