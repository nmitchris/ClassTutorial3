//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Property2Selfhost
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int Application_ID { get; set; }
        public string Applicant_Email { get; set; }
        public Nullable<System.DateTime> Date_Applied { get; set; }
        public Nullable<System.DateTime> Date_Start { get; set; }
        public Nullable<System.DateTime> Date_End { get; set; }
        public int Property_ID { get; set; }
    
        public virtual Property Property { get; set; }
    }
}