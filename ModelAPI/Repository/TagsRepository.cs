using ModelAPI.Repository.IRepository;

namespace ModelAPI.Repository
{
    public class TagsRepository : Repository<Tag>, ITagsRepository
    {
        public TagsRepository(ModelContainer dataContext) : base(dataContext)
        {
            _dbEntities = dataContext;
        }

        private readonly ModelContainer _dbEntities;
    }
}