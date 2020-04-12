using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ModelAPI;

namespace WCF.ObjectWCF
{
    [ServiceContract]
    interface IEventWCF
    {
        [OperationContract]
        Event GetByIdEvent(Guid id);

        [OperationContract]
        IList<Event> GetAllEvent();

        [OperationContract]
        void InsertEvent(Event iEvent);

        [OperationContract]
        void UpdateEvent(Event iEvent);

        [OperationContract]
        void DeleteEvent(Event iEvent);
    }
}