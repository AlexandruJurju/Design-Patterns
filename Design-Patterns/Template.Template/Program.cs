using Template.Template;

Template.Template.Template instance = new ConcreteAlgorithmA();
instance.TemplateMethod();
Console.WriteLine();

instance = new ConcreteAlgorithmB();
instance.TemplateMethod();