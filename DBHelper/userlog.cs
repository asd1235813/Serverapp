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
    
    public partial class userlog
    {
        public int id { get; set; }
        public Nullable<int> Userid { get; set; }
        public string action { get; set; }
        public System.DateTime ActionTime { get; set; }
    
        public virtual userdetail userdetail { get; set; }
    }
}
