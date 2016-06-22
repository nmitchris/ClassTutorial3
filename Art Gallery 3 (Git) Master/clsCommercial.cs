// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'COMMERCIAL' CLASS - sub-CLASS OF ABSTRACT CLASS 'PROPERTY'
// WIP - NEED TO UPDATE CLASS PROPERTY TO "COMMERCIAL_TERM"

using System;

namespace Property
{
    [Serializable()]
    public class clsCommercial : clsProperty
    {
        private float _Width;
        //private float _Height;
        //private string _Type;

        public delegate void LoadCommericialFormDelegate(clsCommercial prCommercial);
        public static LoadCommericialFormDelegate LoadCommercialForm;

        public override void EditDetails()
        {
            LoadCommercialForm(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        //public Single Height
        //{
        //    get { return _Height; }
        //    set { _Height = value; }
        //}

        //public string Type
        //{
        //    get { return _Type; }
        //    set { _Type = value; }
        //}
    }
}
