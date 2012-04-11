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
	using System.Xml.Linq;

	public partial class MetaNavigationProperty
	{
		// <NavigationProperty Name="Movies" Relationship="Movies.FK_movies_genres" FromRole="genre" ToRole="movie" />
		public static MetaNavigationProperty Parse(MetaModel mmodel, MetaEntityType et, XElement node)
		{
			var fullName = et.FullName + '.' + node.Att("Name");

			if (mmodel.NavigationProperties.ContainsKey(fullName))
				return mmodel.NavigationProperties[fullName];

			var m = new MetaNavigationProperty
			        	{
			        		FullName = fullName,
			        		Name = node.Att("Name")
			        	};

			mmodel.NavigationProperties.Add(fullName, m);

			m.AssociationRole = MetaAssociationRole.Parse(mmodel, et, node);

			m.EntityType = m.AssociationRole.ToEntityType;

			return m;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.NavigationProperty;
		}
	}
}
