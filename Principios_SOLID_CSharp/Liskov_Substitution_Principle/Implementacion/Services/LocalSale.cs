using Liskov_Substitution_Principle.Implementacion.Models;

namespace Liskov_Substitution_Principle.Implementacion.Services
{
    public class LocalSale : SaleWithTaxes
    {
        public LocalSale(decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }
        public override void Generate()
        {
            Console.WriteLine("Se generó lo venta local");
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("Se calculan los impuestos locales");
        }
    }
}
