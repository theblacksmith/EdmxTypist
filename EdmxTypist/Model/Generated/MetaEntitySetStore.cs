//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace EdmxTypist.Model
{
    public partial class MetaEntitySetStore
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Schema { get; set; }
        public string Type { get; set; }
    
        public virtual MetaEntitySet Concept { get; set; }
        public virtual MetaEntityTypeStore EntityTypeStore { get; set; }
    }
    
}