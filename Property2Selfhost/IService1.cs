// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2SELFHOST / 'ISERVICE1'
// CALLS OR USES METHODS FROM 'SERVICE1'

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

        [OperationContract]
        List<string> GetLocation();
    }

}
