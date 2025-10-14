namespace Prototype.Simple;

public class Person
{
    public IdInfo IdInfo;
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = string.Copy(Name);
        return clone;
    }
}