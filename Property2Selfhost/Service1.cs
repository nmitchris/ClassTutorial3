// CHRISTOPHER D'ENTREMONT 
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE)
// TIERED SOFTWARE C# APPLICATION
// PROPERTY2SELFHOST / SERVICE1.CS 
// CONFIGURING DB - TABLE / ATTRIBUTE CONNECTIONS 
//  CONTAINS METHODS FOR ISERVICE1.CS

using System.Collections.Generic;
using System.Linq;
using Property2Selfhost.DTO;

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

        public List<string> GetLocation()
        {
            using (Property_DataEntities lcContext = new Property_DataEntities())
                return lcContext.Locations
                .Select(lcLocation => lcLocation.City_Name)
                .ToList();
        }


    }

}
