namespace Prototype.Cloneable;

public class Person : ICloneable
{
    public IdInfo IdInfo;
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }

    public object Clone()
    {
        var clonedPerson = (Person)MemberwiseClone();

        clonedPerson.IdInfo = new IdInfo
        {
            IdNumber = IdInfo.IdNumber
        };

        return clonedPerson;
    }
}