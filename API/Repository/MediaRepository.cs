using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ModelAPI.Repository.IRepository;

namespace ModelAPI.Repository
{
    public class MediaRepository : Repository<Media>, IMediaRepository
    {
        public MediaRepository(ModelContainer dataContext) : base(dataContext)
        {
            _dbEntities = dataContext;
            _searchOptions = new Dictionary<string, Func<string, Expression<Func<Media, bool>>>>();
            _searchOptions.Add("any", ExpresionGenerator.SearchAny);
            _searchOptions.Add("event", ExpresionGenerator.SearchByEvent);
            _searchOptions.Add("people", ExpresionGenerator.SearchByPeople);
            _searchOptions.Add("tag", ExpresionGenerator.SearchByTag);
            _searchOptions.Add("place", ExpresionGenerator.SearchByPlace);
        }


        public IList<Media> GetAllNotDeleted()
        {
            return _dbEntities.MediaSet.Where(e => !e.Deleted)
                .Include(e => e.Event)
                .Include(e => e.People)
                .Include(e => e.Place)
                .Include(e => e.Tag).ToList();
        }

        public void DeleteMediaInCascade(Media media)
        {
            var mediaFromDb = GetById(media.MediaId);
            foreach (var @event in mediaFromDb.Event.ToList())
            {
                _dbEntities.EventSet.Remove(@event);
            }

            foreach (var people in mediaFromDb.People.ToList())
            {
                _dbEntities.PeopleSet.Remove(people);
            }

            foreach (var place in mediaFromDb.Place.ToList())
            {
                _dbEntities.PlaceSet.Remove(place);
            }

            foreach (var tag in mediaFromDb.Tag.ToList())
            {
                _dbEntities.TagSet.Remove(tag);
            }

            Delete(mediaFromDb);
        }

        public IList<Media> FindByContentType(string searchI, string type)
        {
            if (!_searchOptions.ContainsKey(type.ToLower()))
                throw new NotImplementedException(type);

            return _dbEntities.MediaSet.Where(_searchOptions[type.ToLower()](searchI)).ToList();
        }

        private readonly ModelContainer _dbEntities;
        private readonly Dictionary<string, Func<string, Expression<Func<Media, bool>>>> _searchOptions;
    }
}