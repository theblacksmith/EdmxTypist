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
    public partial class MetaEntityTypeStore
    {
        public MetaEntityTypeStore()
        {
            this.PropertiesStores = new HashSet<MetaPropertyStore>();
        }
    
        public string FullName { get; set; }
        public string Name { get; set; }
    
        public virtual MetaEntityType Concept { get; set; }
        public virtual MetaEntitySetStore EntitySetStore { get; set; }
        public virtual ICollection<MetaPropertyStore> PropertiesStores { get; set; }
    }
    
}
