//S – Single Responsability Principle (SRP) (Principio de responsabilidad única) 
//Este principio establece que un componente o clase debe tener una responsabilidad única, sencilla y concreta. 
//Esto simplifica el código al evitar que existan clases que cumplan con múltiples funciones, 
//las cuales son difíciles de memorizar y muchas veces significan una pérdida de tiempo buscando qué parte del código hace qué función.


using Single_Responsability_Principle.DataBase;
using Single_Responsability_Principle.Models;
using Single_Responsability_Principle.Service;

Beer cerveza = new ("Aguila","Bavaria");
BeerDB guardarCerveza = new(cerveza);
guardarCerveza.Save();
BeerRequest enviarCerveza = new(cerveza);
enviarCerveza.Send();