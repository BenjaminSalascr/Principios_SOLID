//L – Liskov Substitution Principle (LSP) (Principio de substitución de Liskov) 
//Este principio establece que una subclase puede ser sustituida por su superclase. 
//Es decir, podemos crear una subclase llamada Auto, la cual deriva de la superclase Vehículo.
//Si al usar la superclase el programa falla, este principio no se cumple. 

using Liskov_Substitution_Principle.EjemploBasico;
using Liskov_Substitution_Principle.Implementacion.Models;
using Liskov_Substitution_Principle.Implementacion.Services;

//EjemploBasico
Console.WriteLine("EjemploBasico");

Padre padre = new HijoUno();
Console.WriteLine(padre.GetName());
padre = new HijoDos();
Console.WriteLine(padre.GetName());
Console.WriteLine("Fin \n");


//Implementación
Console.WriteLine("Implementación");

SaleWithTaxes sale = new LocalSale(100, "Jorge", 0.16m);
sale.CalculateTaxes();
sale.Generate();
sale = new SaleInvoce(100, "Jorge", 0.16m);
sale.CalculateTaxes();
sale.Generate();
Console.WriteLine("\n");
AbstractSale sale2 = new ForeingSale(200, "Alex");
sale2.Generate();

Console.WriteLine("Fin");

