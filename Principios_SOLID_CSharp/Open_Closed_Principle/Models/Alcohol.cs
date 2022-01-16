using Open_Closed_Principle.Categorize;

namespace Open_Closed_Principle.Models
{
    public class Alcohol : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; } //impuesto
        public decimal Promo { get; set; }
        public decimal GetPrice() => Price + (Price * Invoice) - Promo;
    }
}
