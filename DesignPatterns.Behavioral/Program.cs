using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;

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