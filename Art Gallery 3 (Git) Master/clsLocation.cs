using System;

namespace Property
{
    [Serializable()]
    public class clsLocation
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;

        private clsPropertiesList _PropertiesList;
        private clsLocationList _LocationList;

        public clsLocation() { }

        public clsLocation(clsLocationList prLocationList)
        {
            _PropertiesList = new clsPropertiesList();
            _LocationList = prLocationList;
        }

        public bool IsDuplicate(string prLocationName)
        {
            return _LocationList.ContainsKey(prLocationName);
        }

        public void NewLocation()
        {
            if (!string.IsNullOrEmpty(Name))
                _LocationList.Add(Name, this);
            else
                throw new Exception("No location name entered");
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Speciality
        {
            get { return _Speciality; }
            set { _Speciality = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public decimal TotalValue
        {
            get { return _PropertiesList.GetTotalValue(); /* was: _TotalValue;*/ }
        }

        public clsLocationList LocationList
        {
            get { return _LocationList; }
        }

        public clsPropertiesList PropertiesList
        {
            get { return _PropertiesList; }
        }
    }
}
