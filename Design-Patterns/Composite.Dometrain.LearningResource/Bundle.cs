namespace Composite.Dometrain.LearningResource;

public class Bundle(string name) : LearningResource
{
    private List<LearningResource> _children = [];

    public override decimal GetPrice()
    {
        return _children.Sum(child => child.GetPrice()) * 0.8m;
    }

    public override TimeSpan GetDuration()
    {
        return new(_children.Select(x => x.GetDuration().Ticks).Sum());
    }

    public override string GetName() => name;

    public override void Add(LearningResource learningResource)
    {
        _children.Add(learningResource);
    }

    public override void Remove(LearningResource learningResource)
    {
        _children.Remove(learningResource);
    }

    public override LearningResource? GetChild(string childName)
    {
        return _children.FirstOrDefault(x => x.GetName() == childName);
    }
}