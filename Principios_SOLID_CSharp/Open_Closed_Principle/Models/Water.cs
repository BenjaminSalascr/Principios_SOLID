using Open_Closed_Principle.Categorize;

namespace Open_Closed_Principle.Models
{
    internal class Water : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; } //impuesto
        public decimal GetPrice() => Price + (Price * Invoice);
    }
}
