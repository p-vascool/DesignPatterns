using DesignPatterns.Behavioral.ChainOfResponsibility;

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