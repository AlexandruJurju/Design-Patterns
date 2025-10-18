namespace Builder.Dometrain.Nested.Conceptual;

public record Product(string Name, string Description)
{
    public class Builder
    {
        private string _name = String.Empty;
        private string _description = String.Empty;

        public void BuildName(string name)
        {
            _name = name;
        }

        public void BuildDescription(string description)
        {
            _description = description;
        }

        public Product Build()
        {
            return new Product(_name, _description);
        }
    }
}