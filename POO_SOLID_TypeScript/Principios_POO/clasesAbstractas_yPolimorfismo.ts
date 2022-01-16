abstract class User{
    public profesion: string;

    constructor(profesion: string){
        this.profesion = profesion;
    }

    goToWork(): void{
        console.log("Go to work");
    }
}

interface IUserInformation{
    phoneNumber: string;
}

class Artist extends User implements IUserInformation{
    
    phoneNumber: string;
    
    constructor(phoneNumber: string){
        super('Artist');
        this.phoneNumber = phoneNumber;
    }
}

class Astronaut extends User{
    
    constructor(){
       super('Astronaut');
    }    
}

function printProfessions(user: User): void{
    console.log(user.profesion);
}
    
let artist = new Artist('123456789'),
astronaut = new Astronaut();

printProfessions(artist);
printProfessions(astronaut);