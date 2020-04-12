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
    interface IPersonWCF
    {
        [OperationContract]
        People GetByIdPeople(Guid id);

        [OperationContract]
        IList<People> GetAllPeople();

        [OperationContract]
        void InsertPeople(People people);

        [OperationContract]
        void UpdatePeople(People people);

        [OperationContract]
        void DeletePeople(People people);
    }
}