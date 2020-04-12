using ModelAPI.Repository.IRepository;

namespace ModelAPI.Repository
{
    public class PersonsRepository : Repository<People>, IPersonsRepository
    {
        public PersonsRepository(ModelContainer dataContext) : base(dataContext)
        {
            _dbEntities = dataContext;
        }

        private readonly ModelContainer _dbEntities;
    }
}