using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.ObjectWCF;

namespace WCF.InterfacesWCF
{
    [ServiceContract]
    interface IWcf : IEventWCF, IMediatWCF, IPersonWCF, ITagWCF
    { }
}