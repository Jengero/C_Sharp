namespace CSharpAdvanced
{
    public class Violet : Flower
    {
        private string _name;
        private string _color;
        private double _price;

        public override string Name { get => _name; set => _name = value; }
        public override string Color { get => _color; set => _color = value; }
        public override double Price { get => _price; set => _price = value; }

        public Violet(string name, string colour, double price)
        {
            _name = name;
            _color = colour;
            _price = price;
        }
    }
}
