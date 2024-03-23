namespace dao
{
    internal interface DAO<T>
    {
        T? Get(int id);

        List<T>? GetAll();

        int Update(T t);

        int Insert(T t);

        int Delete(T t);

    }
}
