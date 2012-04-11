﻿/**
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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace EdmxTypist.Model
{
    public partial class MetaContext : DbContext
    {
        public MetaContext()
            : base("name=MetaContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MetaEntitySetStore> MetaEntitySetStores { get; set; }
        public DbSet<MetaPropertyStore> MetaPropertyStores { get; set; }
        public DbSet<MetaEntityTypeStore> MetaEntityTypeStores { get; set; }
        public DbSet<MetaScalarPropertyMap> MetaScalarPropertyMaps { get; set; }
        public DbSet<MetaContainerStore> MetaContainerStores { get; set; }
        public DbSet<MetaAssociationSet> MetaAssociationSets { get; set; }
        public DbSet<RenameableObject> RenameableObjects { get; set; }
    }
}
