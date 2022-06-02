#region Adapter

using DesignPatterns.Structural.Adapter;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine(target.GetRequest());
#endregion

