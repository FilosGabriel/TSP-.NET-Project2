using ModelAPI.Repository;
using ModelAPI.Repository.IRepository;

namespace ModelAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMediaRepository Media { get; set; }
        public IPersonsRepository Persons { get; set; }
        public IEventsRepository Events { get; set; }
        public ITagsRepository Tags { get; set; }

        public UnitOfWork(ModelContainer context)
        {
            _context = context;
            Media = new MediaRepository(_context);
            Persons = new PersonsRepository(_context);
            Events = new EventsRepository(_context);
            Tags = new TagsRepository(_context);
        }

        public UnitOfWork()
        {
            _context = new ModelContainer();
            Media = new MediaRepository(_context);
            Persons = new PersonsRepository(_context);
            Events = new EventsRepository(_context);
            Tags = new TagsRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private readonly ModelContainer _context;
    }
}