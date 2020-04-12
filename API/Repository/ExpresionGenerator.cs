using System;
using System.Linq;
using System.Linq.Expressions;

namespace ModelAPI.Repository.IRepository
{
    internal static class ExpresionGenerator
    {
        internal static Expression<Func<Media, bool>> SearchAny(string search)
        {
            return (media) => (media.Name.ToLower().Contains(search.ToLower()) ||
                               media.Event.Any(e => e.Name.ToLower().Contains(search.ToLower())) ||
                               media.People.Any(e => e.Name.ToLower().Contains(search.ToLower())) ||
                               media.Place.Any(e => e.Name.ToLower().Contains(search.ToLower())) ||
                               media.Tag.Any(e => e.Name.ToLower().Contains(search.ToLower())) ||
                               media.DateOfCreation.ToString().Equals(search)) && !media.Deleted;
        }

        internal static Expression<Func<Media, bool>> SearchByEvent(string search)
        {
            return (media) => (media.Event.Any(e => e.Name.ToLower().Contains(search.ToLower()))) && !media.Deleted;
        }

        internal static Expression<Func<Media, bool>> SearchByPeople(string search)
        {
            return (media) => (media.People.Any(e => e.Name.ToLower().Contains(search.ToLower()))) && !media.Deleted;
        }

        internal static Expression<Func<Media, bool>> SearchByTag(string search)
        {
            return (media) => (media.Tag.Any(e => e.Name.ToLower().Contains(search.ToLower()))) && !media.Deleted;
        }

        internal static Expression<Func<Media, bool>> SearchByPlace(string search)
        {
            return (media) => (media.Place.Any(e => e.Name.ToLower().Contains(search.ToLower()))) && !media.Deleted;
        }
    }
}