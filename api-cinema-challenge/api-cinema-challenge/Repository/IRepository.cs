namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> 
    {
        public Task<IEnumerable<T>> GetAll();
        //public Task<T> Get(int id);

    }
}
