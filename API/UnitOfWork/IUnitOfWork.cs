using System;
using ModelAPI.Repository.IRepository;

namespace ModelAPI.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IMediaRepository Media { get; set; }
        IPersonsRepository Persons { get; set; }
        IEventsRepository Events { get; set; }
        ITagsRepository Tags { get; set; }

        int Complete();
    }
}