//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Property
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Property
    {
        public System.Guid Property_ID { get; set; }
        public System.DateTime Date_Modified { get; set; }
        public decimal Lease_Rate { get; set; }
        public string Owner { get; set; }
        public byte[] TimestStamp { get; set; }
        public string Address { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
