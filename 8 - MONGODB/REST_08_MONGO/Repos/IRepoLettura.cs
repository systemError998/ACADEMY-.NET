namespace REST_08_MONGO.Repos
{
    public interface IRepoLettura<T>
    {
        T? GetById();
        IEnumerable<T> GetAll();
    }
}
