//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAssignment7_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation
    {
        public int DonationKey { get; set; }
        public Nullable<int> PersonKey { get; set; }
        public System.DateTime DonationDate { get; set; }
        public decimal DonationAmount { get; set; }
        public Nullable<System.Guid> DonationConfirmation { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
