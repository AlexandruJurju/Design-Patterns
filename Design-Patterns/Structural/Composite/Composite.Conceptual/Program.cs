using Composite.Conceptual;

var tree = new Composite.Conceptual.Composite();

var branch1 = new Composite.Conceptual.Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

var branch2 = new Composite.Conceptual.Composite();
branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);

Console.WriteLine(tree.Operation());