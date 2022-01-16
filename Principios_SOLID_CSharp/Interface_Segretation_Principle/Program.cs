//I – Interface Segretation Principle (ISP) (Principio de segregación de interfaz) 
//Este principio establece que los clientes no deben ser forzados a depender de interfaces que no utilizan. 
//Es importante que cada clase implemente las interfaces que va a utilizar. 
//De este modo, agregar nuevas funcionalidades o modificar las existentes será más fácil. 


using Interface_Segretation_Principle;

UserService usuario = new();
usuario.Get(1);