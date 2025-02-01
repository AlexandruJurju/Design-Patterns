namespace Builder.StaticInner;

public class Product
{
    public List<string> Parts { get; } = new();

    public void Show() => Console.WriteLine("Product Parts: " + string.Join(", ", Parts));

    public class Builder
    {
        private Product _product = new();

        public Builder AddPartA()
        {
            _product.Parts.Add("Part A");
            return this;
        }

        public Builder AddPartB()
        {
            _product.Parts.Add("Part B");
            return this;
        }

        public Product Build() => _product;
    }
}