using Composite.Dometrain.Conceptual;

Component root = new Composite.Dometrain.Conceptual.Composite();

Component leafA = new Leaf();
root.Add(leafA);

Component childComposite = new Composite.Dometrain.Conceptual.Composite();

Component leafB = new Leaf();
Component leafC = new Leaf();

childComposite.Add(leafB);
childComposite.Add(leafC);

root.Add(childComposite);

root.Operation();