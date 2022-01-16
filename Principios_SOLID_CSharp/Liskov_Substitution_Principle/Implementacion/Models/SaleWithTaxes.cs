namespace Liskov_Substitution_Principle.Implementacion.Models
{
    public abstract class SaleWithTaxes : AbstractSale
    {
        protected decimal taxes; //impuestos

        public abstract void CalculateTaxes();
    }
}
