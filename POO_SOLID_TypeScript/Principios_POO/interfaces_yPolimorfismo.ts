interface IUser{
    profesion: string;
    goToWork(): void;
}

interface IUserInformation{
    phoneNumber: string;
}

class Doctor implements IUser, IUserInformation{
    profesion: string;
    phoneNumber: string;
    
    constructor(phoneNumber: string){
        this.profesion = 'Doctor';
        this.phoneNumber = phoneNumber;
    }
    goToWork(): void{
        console.log("Go to work to the hospital");
    }
}

class Police implements IUser{
    profesion: string;
    constructor(){
        this.profesion = 'Police';
    }
    goToWork(): void{
        console.log("Go to work to the Police Station");
    }
}

function printProfession(user: IUser): void{
    console.log(user.profesion);
}
    
let doctor = new Doctor('123456789'),
    police = new Police();

printProfession(doctor);
printProfession(police);