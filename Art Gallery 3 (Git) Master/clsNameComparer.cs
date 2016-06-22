// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'CLSNAMECOMPARER' SEALED subCLASS / OF ICOMPARER 'CLSPROPERTY' SUPERCLASS
// SINGLETONE PATTERN

using System.Collections.Generic;

namespace Property
{
    sealed class clsNameComparer : IComparer<clsProperty>
    {   //Singleton Pattern
        public static readonly clsNameComparer Instance = new clsNameComparer();

        private clsNameComparer() { }

        public int Compare(clsProperty x, clsProperty y)
        {
            clsProperty workClassX = x;
            clsProperty workClassY = y;
            string lcNameX = workClassX.Name;
            string lcNameY = workClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
