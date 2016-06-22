// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'CLSDATECOMPARER' SEALED subCLASS / OF ICOMPARER 'CLSPROPERTY' SUPERCLASS
// SINGLETON PATTERN

using System;
using System.Collections.Generic;

namespace Property
{
    public sealed class clsDateComparer : IComparer<clsProperty>
    {   //Singleton pattern
        public static readonly clsDateComparer Instance = new clsDateComparer();

        private clsDateComparer() { }

        public int Compare(clsProperty x, clsProperty y)
        {
            clsProperty lcWorkX = x;
            clsProperty lcWorkY = y;
            DateTime lcDateX = lcWorkX.Date.Date;
            DateTime lcDateY = lcWorkY.Date.Date;

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
