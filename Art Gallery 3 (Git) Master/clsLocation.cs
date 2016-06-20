using System;

namespace Property
{
    [Serializable()]
    public class clsLocation
    {
        private string _Location_ID;
        private string _City_Name;
        private string _Location_Detail;

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
            get { return _Location_ID; }
            set { _Location_ID = value; }
        }

        public string Speciality
        {
            get { return _City_Name; }
            set { _City_Name = value; }
        }

        public string Phone
        {
            get { return _Location_Detail; }
            set { _Location_Detail = value; }
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
