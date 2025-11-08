using Flyweight.Dometrain.Conceptual;

FlyweightFactory factory = new FlyweightFactory();

Client client = new Client(factory);

client.Operation("Hello");
client.Operation("Hello");
client.Operation("Hi");
client.Operation("Hi");
client.Operation("World");
client.Operation("World");