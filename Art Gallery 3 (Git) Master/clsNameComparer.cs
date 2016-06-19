using System;
using System.Collections.Generic;

namespace Property
{
    sealed class clsNameComparer : IComparer<clsProperty>
    {   //Singleton
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
