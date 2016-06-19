using System;
using System.Collections.Generic;

namespace Property
{
    public sealed class clsDateComparer : IComparer<clsProperty>
    {   //Singleton
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
