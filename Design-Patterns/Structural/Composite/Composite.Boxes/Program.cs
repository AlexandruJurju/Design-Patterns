using Composite.Boxes;

var book = new Product("Book", 20);
var toy = new Product("Toy", 30);
var pen = new Product("Pen", 5);

var smallBox = new Box("Small Box");
smallBox.AddItem(book);
smallBox.AddItem(pen);

var bigBox = new Box("Big Box");
bigBox.AddItem(toy);
bigBox.AddItem(smallBox);

Console.WriteLine($"Total price of '{smallBox.Name}': ${smallBox.GetPrice()}");