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

	public partial class MetaComplexTypeProperty
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ScalarProperty;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml example:
		/// <![CDATA[
		///		<Property Type="String" Name="City" MaxLength="50" FixedLength="false" Unicode="true" />
		/// ]]>
		/// </example>
		/// <param name="file"></param>
		/// <param name="ct"></param>
		/// <param name="prop"></param>
		/// <returns></returns>
		public static MetaComplexTypeProperty Parse(MetaModel metaModel, MetaComplexType ct, XElement prop)
		{
			var p = new MetaComplexTypeProperty
			        	{
			        		FullName = ct.FullName.Dot(prop.Att("Name")), 
							Name = prop.Att("Name"), 
							Type = prop.Att("Type"),
							ComplexType = ct
			        	};
			
			return p;
		}
	}
}
