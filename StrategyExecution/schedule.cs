//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StrategyExecution
{
    using System;
    using System.Collections.Generic;
    
    public partial class schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public schedule()
        {
            this.scheduletransfers = new HashSet<scheduletransfer>();
        }
    
        public string year { get; set; }
        public int sem { get; set; }
        public string teacherid { get; set; }
        public string teachername { get; set; }
        public string courseid { get; set; }
        public string classname { get; set; }
        public string coursename { get; set; }
        public int weekstart { get; set; }
        public int weekend { get; set; }
        public int dayno { get; set; }
        public int section { get; set; }
        public int id { get; set; }
        public string teachingbuilding { get; set; }
        public string floor { get; set; }
    
        public virtual semesterinfo semesterinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scheduletransfer> scheduletransfers { get; set; }
    }
}