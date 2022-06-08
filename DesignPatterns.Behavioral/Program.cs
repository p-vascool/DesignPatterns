using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;

#region ChainOfResposibility

var monkey = new MonkeyHandler();
var squirel = new SquirrelHandler();
var dog = new DogHandler();

monkey
    .SetNext(squirel)
    .SetNext(dog);

Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
CORClient.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
CORClient.ClientCode(squirel);
#endregion

#region Command

Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi"));
Receiver receiver = new Receiver();

invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
invoker.DoSomethingImportant();
#endregion

#region Iterator

var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Straight traversal:");
foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");
collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}
#endregion

#region Mediator

var component1 = new Component1();
var component2 = new Component2();
new ConcreteMediator(component1, component2);

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Client triggets operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();
#endregion

#region Memento

Originator originator = new Originator("Super-duper-super-puper-super.");
CareTaker careTaker = new CareTaker(originator);

careTaker.BackUp();
originator.DoSomething();

careTaker.BackUp();
originator.DoSomething();

careTaker.BackUp();
originator.DoSomething();

Console.WriteLine();
Console.WriteLine();

careTaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
careTaker.Undo();

Console.WriteLine("\nOnce more!\n");
careTaker.Undo();

#endregion