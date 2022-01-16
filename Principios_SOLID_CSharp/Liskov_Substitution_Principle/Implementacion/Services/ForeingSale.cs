using Liskov_Substitution_Principle.Implementacion.Models;

namespace Liskov_Substitution_Principle.Implementacion.Services
{
    public class ForeingSale : AbstractSale
    {
        public ForeingSale(decimal amount, string customer)
        {
            this.amount = amount;
            this.customer = customer;
        }

        public override void Generate()
        {
            Console.WriteLine("Se generó la venta internacional");
        }        
    }
}
