using System.Collections.Generic;

namespace ModelAPI.Repository.IRepository
{
    public interface IMediaRepository : IRepository<Media>
    {
        void DeleteMediaInCascade(Media media);

        IList<Media> FindByContentType(string search, string type);
        IList<Media> GetAllNotDeleted();
    }
}