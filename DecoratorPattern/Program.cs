using DecoratorPattern;


ConcreteComponent concrete = new ConcreteComponent();
concrete.operation();

Console.WriteLine("----------------------------------------------------------------------------------->");

ConcreteDecorator concreteDecorator = new ConcreteDecorator(concrete);
concreteDecorator.operation();

Console.ReadKey();