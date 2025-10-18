namespace Builder.Dometrain.Conceptual.Builders;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}