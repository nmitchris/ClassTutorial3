using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Property
{
    [Serializable()]
    public class clsLocationList : SortedDictionary<string, clsLocation>
    {
        private const string _FileName = "gallery.dat";
        private string _GalleryName;

        public void NewArtist(clsLocation prLocation)
        {
            if (!string.IsNullOrEmpty(prLocation.Name))
            {
                Add(prLocation.Name, prLocation);
            }
            else
                throw new Exception("No location name entered");
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsLocation lcLocation in Values)
            {
                lcTotal += lcLocation.TotalValue;
            }
            return lcTotal;
        }

        public string GalleryName
        {
            get { return _GalleryName; }
            set { _GalleryName = value; }
        }
 
        public static clsLocationList RetrieveLocationList()
        {
            clsLocationList lcLocationList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcLocationList = (clsLocationList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }
            catch (Exception ex)
            {
                lcLocationList = new clsLocationList();
                throw new Exception("File Retrieve Error: " + ex.Message);
            }
            return lcLocationList;
        }

        public void Save()
        {
            System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            lcFormatter.Serialize(lcFileStream, this);
            lcFileStream.Close();
        }
    }
}
