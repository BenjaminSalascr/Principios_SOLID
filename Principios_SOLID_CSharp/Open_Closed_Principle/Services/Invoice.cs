using Open_Closed_Principle.Categorize;

namespace Open_Closed_Principle.Services
{
    //factura
    public class Invoice
    {
        public decimal GetTotal(IEnumerable<IDrink> lstDrink)
        {
            decimal total = 0;
            foreach (var drink in lstDrink)
            {
                total += drink.GetPrice();
            }
            return total;
        }
    }
}

//esta clase implementa cualquier clase que implemente 'IDrink', si el código se extiende a futuro en otra clase
//que implemente esta interfaz, aquí no hay nada que modificar.