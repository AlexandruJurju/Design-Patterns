namespace Builder.Building;

public interface IBuildingBuilder
{
    IBuildingBuilder SetType(string type);
    IBuildingBuilder AddWalls(string material);
    IBuildingBuilder AddRoof(string style);
    IBuildingBuilder AddWindows(int count);
    IBuildingBuilder AddDoors(int count);
    IBuildingBuilder AddSpecialFeature(string feature);
    Building Build();
}