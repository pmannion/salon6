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
    
    public partial class Role
    {
        public Role()
        {
            this.Staffs = new HashSet<Staff>();
        }
    
        public int RoleID { get; set; }
        public string Category { get; set; }
    
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
