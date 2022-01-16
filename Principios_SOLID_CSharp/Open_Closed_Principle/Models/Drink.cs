namespace Open_Closed_Principle.Models
{
    //bebida
    public class Drink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}

//esta clase no aplica porque si la bebida es agua, alcohólica o azucarada
//se realiza una implementación pero si después surge una bebida energizante
//toca ir a modificar esa implementación y ese es el error, tener que modificar
//para ello se crea una interfaz IDrink que nos ayudará a categorizar las clases.
//se crearan las clases 'water' y demas...
