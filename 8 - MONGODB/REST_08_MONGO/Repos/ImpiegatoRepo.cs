using MongoDB.Driver;
using REST_08_MONGO.Models;

namespace REST_08_MONGO.Repos
{
    public class ImpiegatoRepo : IRepoLettura<Impiegato>, IRepoScrittura<Impiegato>
    {
        private readonly ILogger _logger;
        private IMongoCollection<Impiegato> impiegati;
        ImpiegatoRepo(ILogger<ImpiegatoRepo> logger, IConfiguration configuration) { 
            _logger = logger;

            string? connessione = configuration.GetValue<string>("MongoDBConnection.DbLocale");
            string? database = configuration.GetValue<string>("MongoDBConnection.NomeDatabase");

            MongoClient conn = new MongoClient(connessione);
            IMongoDatabase db = conn.GetDatabase(database);

            this.impiegati = db.GetCollection<Impiegato>("Impiegatos"); //tutte le collection devono avere la s alla fine
        }

        public bool Create(Impiegato entity)
        {
            bool risultato = false;

            try
            {
                this.impiegati.InsertOne(entity);
            }
            catch (Exception ex)
            {
             _logger.LogError(ex.Message);
            }

            return risultato;
        }

        public bool Delete(Impiegato entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Impiegato> GetAll()
        {
            throw new NotImplementedException();
        }

        public Impiegato? GetById()
        {
            throw new NotImplementedException();
        }

        public bool Update(Impiegato entity)
        {
            throw new NotImplementedException();
        }
    }
}
