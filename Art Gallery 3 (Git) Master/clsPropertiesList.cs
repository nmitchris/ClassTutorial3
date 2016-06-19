using System;
using System.Collections.Generic;

namespace Property
{
    [Serializable()]
    public class clsPropertiesList : List<clsProperty>
    {
        private byte _SortOrder;

        public void AddWork(char prChoice)
        {
            clsProperty lcWork = clsProperty.NewWork(prChoice);
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }

        public void EditProperty(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsProperty lcProperty = (clsProperty)this[prIndex];
                lcProperty.EditDetails();
            }
            else
                throw new Exception("Sorry no work selected #" + Convert.ToString(prIndex));
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsProperty lcProperty in this)
            {
                lcTotal += lcProperty.Value;
            }
            return lcTotal;
        }

        public void SortByName()
        {
            Sort(clsNameComparer.Instance);
            _SortOrder = 0;
        }

        public void SortByDate()
        {
            Sort(clsDateComparer.Instance);
            _SortOrder = 1;
        }

        public byte SortOrder
        {
            get { return _SortOrder; }
            set { _SortOrder = value; }
        }

    }
}
