using ModelAPI.Repository.IRepository;

namespace ModelAPI.Repository
{
    public class EventsRepository : Repository<Event>, IEventsRepository
    {
        public EventsRepository(ModelContainer dataContext) : base(dataContext)
        {
            _dbEntities = dataContext;
        }

        private readonly ModelContainer _dbEntities;
    }
}