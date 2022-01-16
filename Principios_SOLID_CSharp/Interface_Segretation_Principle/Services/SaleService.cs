namespace Interface_Segretation_Principle
{
    public class SaleService : IBasicActions<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Creamos la venta");
        }

        public Sale Get(int id) => new Sale();

        public List<Sale> GetList() => new List<Sale>();
        
    }
}
