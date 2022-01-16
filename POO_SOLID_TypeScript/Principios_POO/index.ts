//PRINCIPIOS POO
//1- abstracción es la creación de la clase que nos servirá de molde para los objetos //abstraer de la realidad
//2- encapsulamiento es el acceso a los atributos y métodos de una clase: public, private, protected
//3- herencia es la creación de clases que heredan de otras clases base
//4- polimorfismo son las multiples formas de una misma clase o interfaz, ej: granjero, lechero, cocinero, etc
//5- relaciones: asociación: una clase necesita de otra y colaboración: una clase puede ser parte de otra

//EJECURTAR CON NODEJS
// tsc index.ts
// node index.js

//CLASE PRINCIPAL
abstract class Smartphone {
    private color: string;
    private SO: string;
    private battery: number;

    constructor(color: string, SO: string) {
        this.color = color;
        this.SO = SO;
        this.battery = 100;
    }

    makeCall(): void {
        if (this.battery === 0)
            throw "El celular no tiene batería";

        this.battery -= 10;
        console.log("Llamando...");
    }

    get batteryLevel(): number {
        return this.battery;
    }

    recharge(): void {
        this.battery = 100;
        console.log("El celular se ha cargado");
    }
}

//CLASES HIJAS

class Android extends Smartphone {
    constructor(color: string) {
        super(color, "Android");
    }    
}

class Iphone extends Smartphone {
    constructor(color: string) {
        super(color, "Iphone");
    }    
}

//OBJETOS
let andorid = new Android("Red");
let iphone = new Iphone("White");

andorid.makeCall();
iphone.makeCall();
