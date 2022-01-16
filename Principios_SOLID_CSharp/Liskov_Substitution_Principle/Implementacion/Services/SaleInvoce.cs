using Liskov_Substitution_Principle.Implementacion.Models;

namespace Liskov_Substitution_Principle.Implementacion.Services
{
    public class SaleInvoce : SaleWithTaxes
    {
        public SaleInvoce(decimal amount, string customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }
        public override void Generate()
        {
            Console.WriteLine("Se generó la venta con factura");
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("Se calculan los impuestos de la factura");
        }

        public void FacturaXML()
        {
            Console.WriteLine("Se genera XML de la factura");
        }
    }
}
