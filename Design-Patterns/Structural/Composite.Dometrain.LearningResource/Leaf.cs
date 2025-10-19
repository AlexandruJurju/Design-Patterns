namespace Composite.Dometrain.LearningResource;

public class Course(string name, TimeSpan duration, decimal price)  : LearningResource
{
    public override decimal GetPrice() => price;

    public override TimeSpan GetDuration() => duration;

    public override string GetName() => name;
}