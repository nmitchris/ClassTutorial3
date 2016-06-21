using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Property2Selfhost;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Property2Selfhost.DTO
{
    //The DataContract and DataMember attributes specify the classes/members to be included 
    //    in the serialization process; 
    //    i.e. this is the exact data that will be exchanged between the client and WCF server.
    [DataContract]
    public class clsLocation
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [DataMember]
        public int Location_ID { get; set; }
        [DataMember]
        public string City_Name { get; set; }
        [DataMember]
        public string Location_Detail { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Property> Properties { get; set; }
        public clsLocation GetLocation(string prLocationName)
        {
            using (Property_DataEntities lcContext = new Property_DataEntities())
            {
                Location lcLocation = lcContext.Locations
                .Include("Works")
                .Where(Location => Location.City_Name == prLocationName)
                .FirstOrDefault();
                //C# shorthand for creating an object and assigning the public member variables
                clsLocation lcLocationDTO = new clsLocation()
                { City_Name = lcLocation.City_Name, Location_Detail = lcLocation.Location_Detail };
                return lcLocationDTO;
            }
        }
    }

}
