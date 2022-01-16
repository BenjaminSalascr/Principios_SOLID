namespace Open_Closed_Principle.Categorize
{
    //bebida
    public interface IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; } //impuesto
        public decimal GetPrice();
        
    }
}
