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
    
    public partial class strategylog
    {
        public int Id { get; set; }
        public int StrategyId { get; set; }
        public string MachineMac { get; set; }
        public string Instruction { get; set; }
        public System.DateTime ExecutionTime { get; set; }
        public int StrategyDescId { get; set; }
        public string Status { get; set; }
    
        public virtual strategydescription strategydescription { get; set; }
        public virtual strategymanagement strategymanagement { get; set; }
    }
}