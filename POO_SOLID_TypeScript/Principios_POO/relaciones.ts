//ASOCIACIÓN
class Usuario{
    id: number;
    name: string;
    public address?: Address; // asociación de uno a uno
    public phones: Array<PhoneNumber> = []; // asociación de uno a muchos
    public jobs: Array<Job> = []; // asociación de muchos a muchos

    constructor(id: number, name: string){
        this.id = id;
        this.name = name;
    }
}

class Address{
    constructor(){}
}

class PhoneNumber{
    constructor(){}
}

class Job{
    public users: Array<Usuario> = []; // asociación de muchos a muchos
    constructor(){}
}

//COLABORACIÓN
class UserRepository{

    users: Array<Usuario> = [
        new Usuario(1, "Juan"),
        new Usuario(2, "Pedro")
    ];

    get(id: number): Usuario{ // colaboración a traves de una referencia a otra clase (Usuario)
        return this.users.find(user => user.id === id) as Usuario;
    }

    add(user: Usuario): void{ // colaboración a traves de una referencia a otra clase (Usuario)
        this.users.push(user);
    }
}

//Result
let users = new UserRepository();
console.log(users.get(1));
console.log(users.get(2));
//Usuario { phones: [], jobs: [], id: 1, name: 'Juan' }
//Usuario { phones: [], jobs: [], id: 2, name: 'Pedro' }




