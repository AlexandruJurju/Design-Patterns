namespace Builder.Dometrain.Conceptual.Builders;

public class SimpleProductBuilder : IBuilder
{
    private string _name = "";
    private string _description = "";

    public void BuildName()
    {
        _name = "Simple Name";
    }

    public void BuildDescription()
    {
        _description = "Simple Description";
    }

    public Product Build()
    {
        return new Product(_name, _description);
    }
}