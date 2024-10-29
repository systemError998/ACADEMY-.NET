namespace REST_08_MONGO.Repos
{
    public interface IRepoScrittura<T>
    {
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}
