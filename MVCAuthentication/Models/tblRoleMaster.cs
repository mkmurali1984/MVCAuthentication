//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAuthentication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoleMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRoleMaster()
        {
            this.tblUserMasters = new HashSet<tblUserMaster>();
        }
    
        public int RoleId { get; set; }
        public string RoleDesc { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserMaster> tblUserMasters { get; set; }
    }
}
