namespace Liskov_Substitution_Principle.Implementacion.Models
{
    public abstract class AbstractSale
    {
        protected decimal amount;
        protected string customer;
        //protected decimal taxes; //impuestos

        public abstract void Generate();
        //public abstract void CalculateTaxes();
    }
}
