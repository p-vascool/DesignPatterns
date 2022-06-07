#region Adapter

using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composition;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine(target.GetRequest());
#endregion

#region Bridge

DesignPatterns.Structural.Bridge.Client client = new DesignPatterns.Structural.Bridge.Client();
Abstraction abstraction;

abstraction = new Abstraction(new ConcreteImplementationA());

Console.WriteLine(abstraction.Operation());

Console.WriteLine();

abstraction = new ExtendedAbstarction(new ConcreteImplementationB());
#endregion

#region Composition

DesignPatterns.Structural.Composition.Client cl = new DesignPatterns.Structural.Composition.Client();

Leaf leaf = new Leaf();
Console.WriteLine("Client: I get a simple component:");
cl.ClientCode(leaf);

Composite tree = new Composite();
Composite branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
Composite branch2 = new Composite();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client: Now I've got a composite tree:");
cl.ClientCode(tree);

Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
cl.ClientCode2(tree, leaf);
#endregion

#region Decorator

ClientNode clientNode = new ClientNode();

var comcreteCompo = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
clientNode.ClientCode(comcreteCompo);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
FacebookDecorator decorator1 = new FacebookDecorator(comcreteCompo);
SmsDecorator decorator2 = new SmsDecorator(decorator1);
SlackDecorator decorator = new SlackDecorator(decorator2);
Console.WriteLine("Client: Now I've got a decorated component:");
clientNode.ClientCode(decorator);
#endregion

#region Facade

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
Facade facade = new Facade(subsystem1, subsystem2);
FacadeClient.ClientCode(facade);

#endregion

#region Flyweight

var factory = new FlyweightFactory(
               new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
               new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
               new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
               new Car { Company = "BMW", Model = "M5", Color = "red" },
               new Car { Company = "BMW", Model = "X6", Color = "white" }
           );
factory.ListFlyweights();

addCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "M5",
    Color = "red"
});

addCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "X1",
    Color = "red"
});

factory.ListFlyweights();


static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
    Console.WriteLine("\nClient: Adding a car to database.");

    var flyweight = factory.GetFlyweight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyweight.Operation(car);
}
#endregion

#region Proxy
ProxyClient proxyClient = new ProxyClient();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
proxyClient.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new Proxy(realSubject);
proxyClient.ClientCode(proxy);
#endregion