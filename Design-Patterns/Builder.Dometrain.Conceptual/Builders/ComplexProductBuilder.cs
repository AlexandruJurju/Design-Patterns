namespace Builder.Dometrain.Conceptual.Builders;

public class ComplexProductBuilder : IBuilder
{
    private string _name = "";
    private string _description = "";

    public void BuildName()
    {
        _name = "Complex Name";
    }

    public void BuildDescription()
    {
        _description = "Complex Description";
    }

    public Product Build()
    {
        return new Product(_name, _description);
    }
}