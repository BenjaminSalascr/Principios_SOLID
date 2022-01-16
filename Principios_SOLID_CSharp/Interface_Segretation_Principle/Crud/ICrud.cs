namespace Interface_Segretation_Principle
{
    public interface ICrud<T>
    {
        public T Get(int id);
        public List<T> GetList();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}

//'userService' implementa todos los métodos pero 'saleService' no tiene 'update' ni 'delete'
//por lo tanto se implemento mejor IBasicActions, IEditableActions
