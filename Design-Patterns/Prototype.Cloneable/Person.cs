namespace Prototype.Cloneable;

public class Person : ICloneable
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public IdInfo IdInfo;

    public object Clone()
    {
        Person clonedPerson = (Person)MemberwiseClone();

        clonedPerson.IdInfo = new IdInfo
        {
            IdNumber = IdInfo.IdNumber
        };

        return clonedPerson;
    }
}