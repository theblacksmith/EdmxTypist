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
	using System.Linq;

	/// <summary>
	/// 
	/// </summary>
	/// <example>
	///	Xml example:
	///	<![CDATA[
	///		<EntityType Name="genres">
	///			<Key>
	///				<PropertyRef Name="genre_id" />
	///			</Key>
	///			<Property Name="genre_id" Type="int" Nullable="false" />
	///			<Property Name="name" Type="nvarchar" Nullable="false" MaxLength="50" />
	///		</EntityType>
	/// ]]>
	/// </example>
	public partial class MetaEntityTypeStore
	{
		public static MetaEntityTypeStore Parse(EdmxFile file, string fullName, MetaEntitySetStore entitySetStore = null)
		{
			var xEl = file.Storage.D("EntityType").WithName(fullName.LastPart());

			if (xEl != null)
			{
				var m = new MetaEntityTypeStore();

				m.FullName = fullName;
				m.Name = fullName.LastPart();
				m.EntitySetStore = entitySetStore;
				
				var keyNames = (from k in xEl.D("PropertyRef") select k.Att("Name")).ToList();

				m.PropertiesStores = (from p in xEl.D("Property")
									   select new MetaPropertyStore()
									          	{
									          		FullName = fullName + '.' + p.Att("Name"),
													Name = p.Att("Name"),
													Nullable = p.Att("Nullable") == "true",
													Type = p.Att("Type"),
													EntityTypeStore = m,
													isKey = keyNames.Contains(p.Att("Name"))
									          	}).ToList();
				 
				return m;
			}

			return null;
		}
	}

}
