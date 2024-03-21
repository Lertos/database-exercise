namespace dao
{
    internal interface DOA<T>
    {
        T Get(int id);

        T[] GetAll();

        int Save(T t);

        int Update(T t);

        int Insert(T t);

        int Delete(T t);

    }
}
