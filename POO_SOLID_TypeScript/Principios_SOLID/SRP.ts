//S – Single Responsability Principle (SRP) 

//INCORRECT IMPLEMENTATION
class Order{
    email: string;
}
class Message{
    to: string;
    from: string;
    body: string;
}
class SmtpClient{
    send(message: Message): void{}
}

class OrderService {
    constructor(private readonly _client: SmtpClient) { }

    add(order: Order): void {
    //01. código para crear la orden

    //02. código para enviar el correo y notificar el cliente
    var message = new Message();
    message.to = order.email;
    message.from = "admin@ardila.com";
    message.body = "Your order was placed successfully";

    this.sendNotification(message);
    }

    //LA NOTIFICACIÓN SE DEBE HACER EN OTRA CLASE
    sendNotification(message: Message): void {
    this._client.send(message);
    }
}


//CORRECT IMPLEMENTATION
class OrderServices {
    constructor(private readonly _mailService: MailService) { }

    add(order: Order): void {
    //01. código para crear la orden

    //02. código para enviar el correo y notificar el cliente
    var message = new Message();
    message.to = order.email;
    message.from = "admin@ardila.com";
    message.body = "Your order was placed successfully";

    //OTRA CLASE SE ENCARGA DE LA NOTIFICACIÓN Y SI CAMBIA EL CÓDIGO DE ENVÍO, SOLO SE EDITA LA OTRA CLASE
    this._mailService.send(message);
    }    
}

class MailService{
    constructor(private readonly _client: SmtpClient) { }
    send(message: Message): void{
        this._client.send(message);
    }
}

