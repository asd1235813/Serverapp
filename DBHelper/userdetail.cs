//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBHelper
{
    using System;
    using System.Collections.Generic;
    
    public partial class userdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public userdetail()
        {
            this.userlocationaccesses = new HashSet<userlocationaccess>();
            this.userlocationaccesses1 = new HashSet<userlocationaccess>();
            this.userlogs = new HashSet<userlog>();
            this.userpermissions = new HashSet<userpermission>();
            this.userpermissions1 = new HashSet<userpermission>();
        }
    
        public int SerialNo { get; set; }
        public string LoginID { get; set; }
        public string UserName { get; set; }
        public string PersonType { get; set; }
        public string PersonnelStatus { get; set; }
        public string Notes { get; set; }
        public string Password { get; set; }
        public string phone { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime expireDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userlocationaccess> userlocationaccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userlocationaccess> userlocationaccesses1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userlog> userlogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userpermission> userpermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userpermission> userpermissions1 { get; set; }
    }
}