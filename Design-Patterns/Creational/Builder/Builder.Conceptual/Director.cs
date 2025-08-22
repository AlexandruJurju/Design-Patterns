using Builder.Conceptual.Builders;

namespace Builder.Conceptual;

public class Director
{
    public IBuilder Builder { get; set; }

    public void BuildMinimalViableProduct()
    {
        Builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        Builder.BuildPartA();
        Builder.BuildPartB();
        Builder.BuildPartC();
    }
}