namespace Builder.Building;

public class BuildingDirector
{
    public Building ConstructHouse(IBuildingBuilder builder)
    {
        return builder
            .SetType("House")
            .AddWalls("Brick")
            .AddRoof("Flat")
            .AddWindows(4)
            .AddDoors(2)
            .AddSpecialFeature("Garden")
            .Build();
    }

    public Building ConstructCastle(IBuildingBuilder builder)
    {
        return builder
            .SetType("Castle")
            .AddWalls("Stone")
            .AddRoof("Pointed")
            .AddWindows(10)
            .AddDoors(4)
            .AddSpecialFeature("Moat")
            .AddSpecialFeature("Drawbridge")
            .Build();
    }

    public Building ConstructPalace(IBuildingBuilder builder)
    {
        return builder
            .SetType("Palace")
            .AddWalls("Marble")
            .AddRoof("Domed")
            .AddWindows(20)
            .AddDoors(6)
            .AddSpecialFeature("Fountain")
            .AddSpecialFeature("Royal Gardens")
            .Build();
    }
}
