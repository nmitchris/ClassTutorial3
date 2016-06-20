using System.Collections.Generic;
using System.Linq;

namespace Property2Selfhost
{
    //Lab 3 - Prt.2aii
    //Implement an Interface - Ref: https://msdn.microsoft.com/en-us/library/ms173156.aspx
    //Keyword 'using' allows creation of objects to dispose of when no longer needed.
    public class Service1 : IService1
    {
        public List<string> GetLocationNames()
        {
            using (Property_DataEntities lcContext = new Property_DataEntities())
                return lcContext.Locations
                .Select(lcLocation => lcLocation.City_Name)
                .ToList();
        }

    }
}
