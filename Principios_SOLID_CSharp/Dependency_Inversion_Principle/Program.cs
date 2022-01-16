//D – Dependency Inversion Principle (DIP) (Principio de inversión de dependencias) 
//Este principio establece que los módulos de alto nivel no deben de depender de los de bajo nivel. 
//En ambos casos deben depender de las abstracciones. Alto nivel se refiere a operaciones cuya naturaleza es más amplia o 
//abarca un contexto más general y bajo nivel son componentes individuales más específicos. 

using Dependency_Inversion_Principle.Models;
using Dependency_Inversion_Principle.Services;

string origen = @"http://jsonplaceholder.typicode.com/todos";
IInfo info = new InfoByRequest(origen);
PantallaMonitor monitor = new (info);
await monitor.Show();