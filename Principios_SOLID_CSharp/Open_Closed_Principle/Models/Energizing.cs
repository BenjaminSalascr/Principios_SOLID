using Open_Closed_Principle.Categorize;

namespace Open_Closed_Principle.Models
{
    //nueva bebida o requerimiento
    public class Energizing : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; } //impuesto
        public decimal GetPrice() => Price + (Price * Invoice);
    }
}
