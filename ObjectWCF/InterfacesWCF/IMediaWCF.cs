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
    interface IMediatWCF
    {
        [OperationContract]
        Media GetByIdMedia(Guid id);

        [OperationContract]
        IList<Media> GetAllMedia();

        [OperationContract]
        IList<Media> GetAllNotDeletedMedia();

        [OperationContract]
        IList<Media> FindByContentTypeMedia(string searchI, string type);

        [OperationContract]
        void InsertMedia(Media media);

        [OperationContract]
        void UpdateMedia(Media media);

        [OperationContract]
        void DeleteMedia(Media media);
    }
}