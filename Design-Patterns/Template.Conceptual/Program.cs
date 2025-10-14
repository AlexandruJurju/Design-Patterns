using Template.Conceptual;

Template.Conceptual.Template instance = new ConcreteAlgorithmA();
instance.TemplateMethod();
Console.WriteLine();

instance = new ConcreteAlgorithmB();
instance.TemplateMethod();