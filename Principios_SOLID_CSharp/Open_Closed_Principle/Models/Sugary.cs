using Open_Closed_Principle.Categorize;

namespace Open_Closed_Principle.Models
{
    public class Sugary : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; } //impuesto
        public decimal Expiration { get; set; }
        public decimal GetPrice() => Price + (Price * Invoice) - Expiration;
    }
}
