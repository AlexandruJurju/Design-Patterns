namespace Builder.Building;

public class BuildingBuilder : IBuildingBuilder
{
    private Building _building = new Building();

    public BuildingBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        // Create a new Building object for each build
        _building = new Building();
    }
    
    public IBuildingBuilder SetType(string type)
    {
        _building.Type = type;
        return this;
    }

    public IBuildingBuilder AddWalls(string material)
    {
        _building.Features.Add($"Walls made of {material}");
        return this;
    }

    public IBuildingBuilder AddRoof(string style)
    {
        _building.Features.Add($"Roof with {style} style");
        return this;
    }

    public IBuildingBuilder AddWindows(int count)
    {
        _building.Features.Add($"{count} windows");
        return this;
    }

    public IBuildingBuilder AddDoors(int count)
    {
        _building.Features.Add($"{count} doors");
        return this;
    }

    public IBuildingBuilder AddSpecialFeature(string feature)
    {
        _building.Features.Add(feature);
        return this;
    }

    public Building Build()
    {
        var building = _building;
        Reset();
        return building;
    }
}