using Factory.Transportation.Creators;
using Factory.Transportation.Products;

Logistics roadLogistics = new RoadLogistics();
Console.WriteLine(roadLogistics.Deliver());

Logistics shipLogistics = new SeaLogistics();
Console.WriteLine(shipLogistics.Deliver());

Logistics airLogistics = new AirLogistics();
Console.WriteLine(airLogistics.Deliver());