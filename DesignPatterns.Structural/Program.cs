#region Adapter

using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composition;
using DesignPatterns.Structural.Decorator;

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