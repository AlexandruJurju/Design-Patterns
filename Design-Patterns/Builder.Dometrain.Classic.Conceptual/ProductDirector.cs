using Builder.Dometrain.Classic.Conceptual.Builders;

namespace Builder.Dometrain.Classic.Conceptual;

public class ProductDirector(IBuilder builder)
{
    public void ConstructProduct()
    {
        builder.BuildName();
        builder.BuildDescription();
    }
}