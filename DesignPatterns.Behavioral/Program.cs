using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;

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

#region Observer

Console.WriteLine();
Console.WriteLine();

var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.ChangeSubjectState();
subject.ChangeSubjectState();
subject.ChangeSubjectState();

subject.Detach(observerB);
subject.ChangeSubjectState();

#endregion

#region State

var context = new DesignPatterns.Behavioral.State.Context(new ConcreteStateA());
context.FirstRequest();
context.SecondRequest();

#endregion

#region Strategy

var strategyContext = new DesignPatterns.Behavioral.Strategy.Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
strategyContext.SetStrategy(new ConcreteStrategyA());
strategyContext.DoSomeWork();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
strategyContext.SetStrategy(new ConcreteStrategy());
strategyContext.DoSomeWork();

#endregion

#region TemplateMethod
Console.WriteLine("Same client code can work with different subclasses:");

ConcreteClient.ClientCode(new ConcreteClassA());

Console.Write("\n");

Console.WriteLine("Same client code can work with different subclasses:");
ConcreteClient.ClientCode(new ConcreteClassB());
#endregion

#region Visitor

List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
var visitor1 = new ConcreteVisitorA();
VisitorClient.ClientCode(components, visitor1);

Console.WriteLine();

Console.WriteLine("It allows the same client code to work with different types of visitors:");
var visitor2 = new ConcreteVisitorB();
VisitorClient.ClientCode(components, visitor2);

#endregion