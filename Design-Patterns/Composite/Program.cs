using Composite;

Composite.Composite tree = new Composite.Composite();

Composite.Composite branch1 = new Composite.Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());

Composite.Composite branch2 = new Composite.Composite();
branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);

Console.WriteLine(tree.Operation());