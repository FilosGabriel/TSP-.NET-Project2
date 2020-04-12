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
    interface ITagWCF
    {
        [OperationContract]
        Tag GetByIdTag(Guid id);

        [OperationContract]
        IList<Tag> GetAllTag();

        [OperationContract]
        void InsertTag(Tag tag);

        [OperationContract]
        void UpdateTag(Tag tag);

        [OperationContract]
        void DeleteTag(Tag tag);
    }
}