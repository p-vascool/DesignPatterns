#region Adapter

using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine(target.GetRequest());
#endregion

#region Bridge

Client client = new Client();
Abstraction abstraction;

abstraction = new Abstraction(new ConcreteImplementationA());

Console.WriteLine(abstraction.Operation());

Console.WriteLine();

abstraction = new ExtendedAbstarction(new ConcreteImplementationB());
#endregion