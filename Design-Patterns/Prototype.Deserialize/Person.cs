using Newtonsoft.Json;

namespace Prototype.Deserialize;

public class Person : ICloneable
{
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }

    public IdInfo IdInfo { get; set; }

    public object Clone()
    {
        var serialized = JsonConvert.SerializeObject(this);

        return JsonConvert.DeserializeObject<Person>(serialized)!;
    }
}