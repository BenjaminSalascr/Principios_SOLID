//O – Open/Closed Principle (OCP) 

//INCORRECT IMPLEMENTATION

class NotificationService{
    send(notifications: Array<Notification>){
        notifications.forEach(n => {
            //código para enviar la notificación
            if(n.title == "email"){
                //01. código para enviar el correo
            }
            if(n.title == "sms"){
                //02. código para enviar el sms
            }
            //SI EN EL FUTURO SE VA A NOTIFICAR POR OTRO MEDIO, SE DEBE EDITAR ESTA CLASE
        });
    }
}

//CORRECT IMPLEMENTATION

//se utiliza una interfaz y posterior se categorizan las clases
interface INotification{
    notify(): void;
}
class NotificationEmail implements INotification{
    notify(){
        //01. código para enviar el correo
    }
}
class NotificationSms implements INotification{
    notify(){
        //02. código para enviar el sms
    }
}

class NotificationServices{
    send(notifications: Array<INotification>){
        notifications.forEach(n => {
            n.notify();
        });
    }
}

//De esta manera si despues surge otra notificación, se debe agregar una nueva clase que implemente la interfaz