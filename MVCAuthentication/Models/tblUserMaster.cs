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
    
    public partial class tblUserMaster
    {
        public int Uid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<System.DateTime> Createdon { get; set; }
    
        public virtual tblRoleMaster tblRoleMaster { get; set; }
    }
}
