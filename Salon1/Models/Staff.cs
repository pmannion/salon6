//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salon1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public Staff()
        {
            this.Bookings = new HashSet<Booking>();
            this.Contacts = new HashSet<Contact>();
        }
    
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int RoleID { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual Role Role { get; set; }
    }
}
