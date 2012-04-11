/**
 * This file is part of Edmx Typist  - A cyber typist to help you fix your edmx file.
 * Copyright (C) 2012 Saulo Vallory <me@saulovallory.com>
 * 
 * Edmx Typist is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * Edmx Typist is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Edmx Typist. If not, see <http://www.gnu.org/licenses/>.
 */
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
    /// <summary>
    /// Stores info about an EntityType
    /// </summary>
    public partial class MetaEntityType : RenameableObject
    {
        public MetaEntityType()
        {
            this.AssociationRoles = new HashSet<MetaAssociationRole>();
            this.ComplexProperties = new HashSet<MetaComplexProperty>();
            this.Methods = new HashSet<MetaMethod>();
            this.Properties = new HashSet<MetaScalarProperty>();
            this.NavigationProperties = new HashSet<MetaNavigationProperty>();
        }
    
    
    	/// <summary>
    	/// The MetaEntitySet info for the EntitySet this Entity belongs to
    	/// </summary>
        public virtual MetaEntitySet EntitySet { get; set; }
        public virtual ICollection<MetaAssociationRole> AssociationRoles { get; set; }
        public virtual ICollection<MetaComplexProperty> ComplexProperties { get; set; }
        public virtual ICollection<MetaMethod> Methods { get; set; }
        public virtual MetaEntityTypeStore Store { get; set; }
        public virtual ICollection<MetaScalarProperty> Properties { get; set; }
        public virtual ICollection<MetaNavigationProperty> NavigationProperties { get; set; }
    }
    
}
