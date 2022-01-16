//D – Dependency Inversion Principle (DIP)

//INCORRECT IMPLEMENTATION
class MailChimpService{
    send(message: Message): void{/*código*/}
}
class OrderServicess{
    constructor(private readonly _mailChimpService: MailChimpService) {}
    add(order: Order): void{
        //01. código para crear la orden
        //02. código para enviar el correo y notificar el cliente
        var message = new Message();
        message.to = order.email;
        message.from = "admin@ardila.com";
        message.body = "Your order was placed successfully";

        this._mailChimpService.send(message);
    }
}
//el constructor de OrderServicess esta dependiendo de MailChimpService, por lo que si MailChimpService cambia, OrderServicess tambien cambia

//CORRECT IMPLEMENTATION
interface IMailService{
    send(message: Message): void;
}
class MailChimpServices implements IMailService{
    send(message: Message): void{/*código*/}
}
class SendInBlueService implements IMailService{
    send(message: Message): void{/*código*/}
}
class SendGridService implements IMailService{
    send(message: Message): void{/*código*/}
}
class OrderServicesss{
    constructor(private readonly _mailService: IMailService) {}
    add(order: Order): void{
        //01. código para crear la orden
        //02. código para enviar el correo y notificar el cliente
        var message = new Message();
        message.to = order.email;
        message.from = "admin@ardila.com";
        message.body = "Your order was placed successfully";

        this._mailService.send(message);
    }
}
//se soluciono el cambio de requerimiento o de proveedores smtp por medio de recibir la interface en el ctor de OrderServicesss
let orderService1 = new OrderServicesss(new MailChimpServices());
let orderService2 = new OrderServicesss(new SendInBlueService());
let orderService3 = new OrderServicesss(new SendGridService());