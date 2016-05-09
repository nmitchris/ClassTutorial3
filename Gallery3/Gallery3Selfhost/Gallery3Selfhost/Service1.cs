using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3Selfhost
{
    //Lab 3 - Prt.2aii
    //Implement an Interface - Ref: https://msdn.microsoft.com/en-us/library/ms173156.aspx
    public class Service1 : IService1
    {
        public List<string> GetArtistNames()
        {
            using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
                return lcContext.Artists
                .Select(lcArtist => lcArtist.Name)
                .ToList();
        }

    }
}
