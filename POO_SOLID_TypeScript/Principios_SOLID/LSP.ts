//L – Liskov Substitution Principle (LSP) 

//INCORRECT IMPLEMENTATION
class Animal{
    run(): void{}
    walk(): void{}
    hunt(): void{} //cazar
}

class Tiger extends Animal{}

class Turtle extends Animal{
    run(): void{
        throw new Error("No puede correr");
    }
    hunt(): void{
        throw new Error("No puede cazar");
    }
}

//CORRECT IMPLEMENTATION
interface IHunt{
    hunt(): void;
}
interface IRun{
    run(): void;
}
interface IWalk{
    walk(): void;
}

class Tigers implements IHunt, IRun, IWalk{
    hunt(): void{}
    run(): void{}
    walk(): void{}
}
class Turtles implements IWalk{
    walk(): void{}
}