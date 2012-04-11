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
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using System.Xml.Linq;

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		
	///		Concept:
	///		<![CDATA[
	///			<EntitySet Name="Genres" EntityType="Movies.Genre" />
	///		]]>
	///		Mapping:
	///		<![CDATA[
	///			<EntitySetMapping Name="Genres">
	///				<EntityTypeMapping TypeName="Movies.Genre">
	///					<MappingFragment StoreEntitySet="genres">
	///						<ScalarProperty Name="Name" ColumnName="name" />
	///						<ScalarProperty Name="Id" ColumnName="genre_id" />
	///					</MappingFragment>
	///				</EntityTypeMapping>
	///			</EntitySetMapping>
	///		]]>
	/// </remarks>
	public partial class MetaEntitySet
	{
		public const string NodeName = "EntitySet";

		public static List<MetaEntitySet> ParseAll(MetaModel mmodel)
		{
			// Eg: <EntityContainer Name="MoviesContainer" annotation:LazyLoadingEnabled="true">
			var container = mmodel.EdmxFile.Concept.E("EntityContainer");

			if (container == null)
				throw new Exception("Couldn't find the EntityContainer. The edmx file appears to be invalid.");

			var list = (from n in container.D("EntitySet")
			            select Parse(mmodel, container.Att("Name") + '.' + n.Att("Name"))).ToList();

			return list;
		}

		public static MetaEntitySet Parse(MetaModel mmodel, string fullName)
		{
			var node = mmodel.EdmxFile.Concept.D(NodeName).WithName(fullName.LastPart());

			if (node == null)
				throw new Exception("Couldn't find the EntitySet " + fullName);

			return Parse(mmodel, null, node);
		}


		//   <EntitySet Name="Genres" EntityType="Movies.Genre" />
        //   <EntitySet Name="Movies" EntityType="Movies.Movie" />
        //   <EntitySet Name="People" EntityType="Movies.Person" />
		//   <EntitySet Name="Roles" EntityType="Movies.Role" />
		public static MetaEntitySet Parse(MetaModel mmodel, MetaContainer c, XElement node)
		{
			if (node.Name.LocalName != NodeName)
				throw new Exception("Invalid Node. To parse an " + NodeName + " you need to provide an XElement with the same node name.");

			var fullName = c.FullName + '.' + node.Att("Name");

			if (mmodel.EntitySets.ContainsKey(fullName))
				return mmodel.EntitySets[fullName];

			var m = new MetaEntitySet
			        	{
			        		FullName = fullName,
							Name = node.Att("Name"),
							Container = c
			        	};

			mmodel.EntitySets.Add(fullName, m);
			m.EntityType = MetaEntityType.Parse(mmodel, node.Att("EntityType"), m);

			/* todo: process store
			// check for mapping
			var mapEnt = file.Mapping.d("EntitySetMapping").WithName(m.Name);

			if (mapEnt != null)
			{
				// we have a mapping! so we should have a MappingFrag...
				var mapFrag = mapEnt.d("MappingFragment").FirstOrDefault();

				if (mapFrag != null) // load the store
					m.Store = MetaEntitySetStore.Parse(file, mapFrag.Att("StoreEntitySet"));
			}

			if (m.Store != null)
			{
				m.Store.EntityTypeStore = m.EntityType.Store;
			}
			*/

			return m;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.EntitySet;
		}
	}
}
