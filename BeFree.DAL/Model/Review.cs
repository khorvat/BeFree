//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeFree.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public System.Guid id { get; set; }
        public Nullable<System.Guid> propertyid { get; set; }
        public Nullable<int> rating { get; set; }
        public string comment { get; set; }
        public Nullable<System.DateTime> ratedon { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
