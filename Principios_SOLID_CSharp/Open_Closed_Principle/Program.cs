//O – Open / Closed Principle(OCP)(Principio abierto / cerrado)
//Este principio establece que los componentes del software deben estar abiertos para extender a partir de ellos, 
//pero cerrados para evitar que se modifiquen. 

using Open_Closed_Principle.Categorize;
using Open_Closed_Principle.Models;
using Open_Closed_Principle.Services;

var bebidas = new List<IDrink>();

var bebidaAlcoholica = new Alcohol();
bebidaAlcoholica.Name = "Ron";
bebidaAlcoholica.Price = 3000;
bebidaAlcoholica.Invoice = 0.5m;
bebidaAlcoholica.Promo = 0;

var gaseosa = new Sugary();
gaseosa.Name = "Coca-Cola";
gaseosa.Price = 2000;
gaseosa.Invoice = 0.1m;
gaseosa.Expiration = 10; 

var agua = new Water();
agua.Name = "Brisa";
agua.Price = 1000;
agua.Invoice = 0;

bebidas.Add(bebidaAlcoholica);
bebidas.Add(gaseosa);
bebidas.Add(agua);

//bebida agregada meses después

var energizante = new Energizing();
energizante.Name = "Red Bull";
energizante.Price = 2000;
energizante.Invoice = 0;

bebidas.Add(energizante);


//factura
Invoice factura = new();
Console.WriteLine("Total a pagar {0}", factura.GetTotal(bebidas));
