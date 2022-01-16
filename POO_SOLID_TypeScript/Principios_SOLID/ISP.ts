//I – Interface Segretation Principle (ISP) 
//varias interfaces funcionan mejor que una

//INCORRECT IMPLEMENTATION
class Users{}
class UsersReport{}
interface IRepository<T>{
    getAll(): Array<T>;
    getById(id: number): T;
    create(entity: T): void;
    update(entity: T): void;
    delete(id: number): void;
}
class UserRepository implements IRepository<Users>{
    getAll(): Array<Users>{
        return [];
    }
    getById(id: number): Users{
        return new Users();
    }
    create(entity: Users): void{/*código*/}
    update(entity: Users): void{/*código*/}
    delete(id: number): void{/*código*/}
}
class UserReportRepository implements IRepository<UsersReport>{
    getAll(): Array<UsersReport>{
        return [];
    }
    getById(id: number): UsersReport{
        return new UsersReport();
    }
    create(entity: UsersReport): void{throw new Error("No puede implementar");}
    update(entity: UsersReport): void{throw new Error("No puede implementar");}
    delete(id: number): void{throw new Error("No puede implementar");}
}

//CORRECT IMPLEMENTATION
interface IReadable<T>{
    getAll(): Array<T>;
    getById(id: number): T;
}
interface IWritable<T>{
    create(entity: T): void;
    update(entity: T): void;
}
interface IDeletable<T>{
    delete(id: number): void;
}
class UsersReportRepository implements IReadable<UsersReport>{
    getAll(): Array<UsersReport>{
        return [];
    }
    getById(id: number): UsersReport{
        return new UsersReport();
    }
}
