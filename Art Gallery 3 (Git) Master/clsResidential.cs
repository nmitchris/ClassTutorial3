using System;

namespace Property
{
    [Serializable()]
    public class clsResidential : clsProperty
    {
        private float _Width;
        private float _Height;
        private string _Type;

        public delegate void LoadResidentialFormDelegate(clsResidential prPhotograph);
        public static LoadResidentialFormDelegate LoadResidentialForm;


        public override void EditDetails()
        {
            LoadResidentialForm(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
