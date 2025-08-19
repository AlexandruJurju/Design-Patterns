using Builder.Building;

var builder = new BuildingBuilder();
var director = new BuildingDirector();

// Build a House
var house = director.ConstructHouse(builder);
house.Show();

// Build a Castle
var castle = director.ConstructCastle(builder);
castle.Show();

// Build a Palace
var palace = director.ConstructPalace(builder);
palace.Show();