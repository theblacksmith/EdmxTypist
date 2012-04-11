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
namespace EdmxTypist.Model
{
	using System.Collections.Generic;

	public class MetaModel
	{
		public string Name { get; set; }

		public string Namespace { get; set; }

		public Dictionary<string, MetaContainer> Containers = new Dictionary<string, MetaContainer>();

		public Dictionary<string, MetaEntitySet> EntitySets = new Dictionary<string, MetaEntitySet>();

		public Dictionary<string, MetaEntityType> EntityTypes = new Dictionary<string, MetaEntityType>();

		public Dictionary<string, MetaNavigationProperty> NavigationProperties = new Dictionary<string, MetaNavigationProperty>();

		public Dictionary<string, MetaMethod> Methods = new Dictionary<string, MetaMethod>();

		public Dictionary<string, MetaScalarProperty> ScalarProperties = new Dictionary<string, MetaScalarProperty>();

		public Dictionary<string, MetaAssociationRole> AssociationRoles = new Dictionary<string, MetaAssociationRole>();

		public Dictionary<string, MetaComplexType> ComplexTypes = new Dictionary<string, MetaComplexType>();

		public Dictionary<string, MetaComplexProperty> ComplexProperties = new Dictionary<string, MetaComplexProperty>();

		public EdmxFile EdmxFile { get; private set; }

		public MetaModel(EdmxFile file)
		{
			EdmxFile = file;
			Namespace = file.Concept.Att("Namespace");

			foreach (var cType in file.Concept.Es("ComplexType"))
			{
				MetaComplexType.Parse(this, cType);
			}

			foreach (var containerNode in file.Concept.D("EntityContainer"))
			{
				MetaContainer.Parse(this, containerNode);
			}
		}
	}
}
