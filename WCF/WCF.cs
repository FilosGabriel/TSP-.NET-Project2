using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelAPI;
using ModelAPI.UnitOfWork;
using WCF.InterfacesWCF;

namespace WCF
{
    public class WCF : IWcf
    {
        public Event GetByIdEvent(Guid id)
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Events.GetById(id);
        }

        public IList<Event> GetAllEvent()
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Events.GetAll();
        }

        public void InsertEvent(Event iEvent)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Events.Insert(iEvent);
        }

        public void UpdateEvent(Event iEvent)
        {
            using var unitOfWork=new UnitOfWork();
            unitOfWork.Events.Update(iEvent);
        }

        public void DeleteEvent(Event iEvent)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Events.Delete(iEvent);
        }

        public Media GetByIdMedia(Guid id)
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Media.GetById(id);
        }

        public IList<Media> GetAllMedia()
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Media.GetAll();
        }

        public IList<Media> GetAllNotDeletedMedia()
        {
            using var unitOfWork=new UnitOfWork();
            return unitOfWork.Media.GetAllNotDeleted();
        }

        public IList<Media> FindByContentTypeMedia(string searchI, string type)
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Media.FindByContentType(searchI,type);
        }

        public void InsertMedia(Media media)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Media.Insert(media);
        }

        public void UpdateMedia(Media media)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Media.Update(media);
        }

        public void DeleteMedia(Media media)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Media.Delete(media);
        }

        public People GetByIdPeople(Guid id)
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Persons.GetById(id);
        }

        public IList<People> GetAllPeople()
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Persons.GetAll();
        }

        public void InsertPeople(People people)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Persons.Insert(people);
        }

        public void UpdatePeople(People people)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Persons.Update(people);
        }

        public void DeletePeople(People people)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Persons.Delete(people);
        }

        public Tag GetByIdTag(Guid id)
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Tags.GetById(id);
        }

        public IList<Tag> GetAllTag()
        {
            using var unitOfWork = new UnitOfWork();
            return unitOfWork.Tags.GetAll();
        }

        public void InsertTag(Tag tag)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Tags.Insert(tag);
        }

        public void UpdateTag(Tag tag)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Tags.Update(tag);
        }

        public void DeleteTag(Tag tag)
        {
            using var unitOfWork = new UnitOfWork();
            unitOfWork.Tags.Delete(tag);
        }
    }
}