// MATTHIAS OTTO - NMIT SDV701 GALLERY EXAMPLE
// GITHUB - FORKED MODIFIED BY: CHRISTOPHER D'ENTREMONT
// 20160623 - SDV701 - ASSESSMENT 1 PHASE 2 - PROPERTY (LOCATION / LEASE) APPLICATION
// TIERED SOFTWARE C# APPLICATION
// PROPERTY / 'CLSPROPERTY'CLASS

using System;

namespace Property
{
    [Serializable()]
    public abstract class clsProperty
    {
        private string _Name;
        private DateTime _Date = DateTime.Now;
        private decimal _Value;

        public clsProperty()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter C for Commercial and R for Residential";

        public static clsProperty NewWork(char prChoice)
        {
            switch (char.ToUpper(prChoice))
            {
                case 'C': return new clsCommercial();
                //case 'S': return new clsSculpture();
                case 'R': return new clsResidential();
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _Name + "\t" + _Date.ToShortDateString();
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public decimal Value
        {
            get { return _Value; }
            set { _Value = value; }
        }


    }
}
