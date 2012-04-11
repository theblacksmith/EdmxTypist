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

	public partial class MetaComplexType : RenameableObject
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ComplexType;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml Example:
		/// <![CDATA[
		///		<ComplexType Name="Location">
		///			<Property Type="String" Name="City" MaxLength="50" FixedLength="false" Unicode="true" />
		///			<Property Type="String" Name="State" MaxLength="50" FixedLength="false" Unicode="true" />
		///			<Property Type="String" Name="Country" MaxLength="50" FixedLength="false" Unicode="true" />
		///		</ComplexType>
		/// ]]>
		/// </example>
		/// <param name="metaModel"></param>
		/// <param name="cType"></param>
		/// <returns></returns>
		public static MetaComplexType Parse(MetaModel metaModel, XElement cType)
		{
			var fullName = metaModel.Namespace.Dot(cType.Att("Name"));

			if (metaModel.ComplexTypes.ContainsKey(fullName))
				return metaModel.ComplexTypes[fullName];

			var ct = new MetaComplexType();

			ct.FullName = fullName;
			ct.Name = cType.Att("Name");

			foreach (var prop in cType.Es("Property"))
			{
				ct.Properties.Add(MetaComplexTypeProperty.Parse(metaModel, ct, prop));
			}

			metaModel.ComplexTypes.Add(ct.FullName, ct);

			return ct;
		}

		public static XElement FindNode(MetaModel mmodel, string name)
		{
			return mmodel.EdmxFile.Concept.Es("ComplexType").WithName(name.LastPart());
		}
	}
}
