namespace Builder.Dometrain.Classic.Conceptual.Builders;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}