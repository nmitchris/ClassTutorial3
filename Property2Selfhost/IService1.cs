using System.Collections.Generic;
using System.ServiceModel;

namespace Property2Selfhost
{
    [ServiceContract]
    interface IService1
    {
        //Lab3.prt2.iv - "paste service routine header"
        [OperationContract]
        List<string> GetLocationNames();
    }
}
