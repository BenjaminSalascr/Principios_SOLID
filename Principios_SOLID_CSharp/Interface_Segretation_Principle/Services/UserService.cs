namespace Interface_Segretation_Principle
{
    public class UserService : IBasicActions<User>, IEditableActions<User>
    {
        public void Add(User entity)
        {
            Console.WriteLine("Creamos el usuario");
        }

        public void Delete(User entity)
        {
            Console.WriteLine("Eliminamos el usuario");
        }

        public User Get(int id)
        {
            Console.WriteLine("Obtenemos el usuario");
            return new User();
        }

        public List<User> GetList() => new List<User>();


        public void Update(User entity)
        {
            Console.WriteLine("Editamos el usuario");
        }
    }
}
