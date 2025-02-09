namespace Prototype.Simple;

public class Person
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public IdInfo IdInfo;

    public Person ShallowCopy()
    {
        return (Person) MemberwiseClone();
    }

    public Person DeepCopy()
    {
        Person clone = (Person) MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = String.Copy(Name);
        return clone;
    }
}