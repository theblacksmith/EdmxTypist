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
	using System;

	public partial class MetaComplexProperty
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ComplexProperty;
		}

		public static bool IsComplexPropertyNode(MetaModel mmodel, XElement scP)
		{
			if (mmodel.ComplexTypes.ContainsKey(scP.Att("Type")))
				return true;

			return mmodel.EdmxFile.Concept.Es("ComplexType").FirstWhere("Name", scP.Att("Type").LastPart()) != null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml example:
		/// <![CDATA[
		///		<Property Name="Shooting" Type="Movies.Location" Nullable="false" />
		/// ]]>
		/// </example>
		///<param name="mmodel"></param>
		///<param name="entityType"> </param>
		///<param name="scP"></param>
		///<returns></returns>
		public static MetaComplexProperty Parse(MetaModel mmodel, MetaEntityType entityType, XElement scP)
		{
			var p = new MetaComplexProperty
			        	{
							EntityType = entityType,
							FullName = entityType.FullName.Dot(scP.Att("Name")),
							Name = scP.Att("Name"),
							Nullable = scP.Att("Name").ToLower() == "true"
			        	};

			mmodel.ComplexProperties.Add(p.FullName, p);

			MetaComplexType ct;

			if (mmodel.ComplexTypes.ContainsKey(scP.Att("Type")))
				ct = mmodel.ComplexTypes[scP.Att("Type")];
			else
			{
				var ctNode = MetaComplexType.FindNode(mmodel, scP.Att("Type"));

				if(ctNode == null)
					throw new Exception("Couldn't find the ComplexType " + scP.Att("Type") + 
						". The type was used in " + entityType.FullName.Dot(scP.Att("Name")));

				ct = MetaComplexType.Parse(mmodel, ctNode);
			}

			p.ComplexType = ct;

			return p;
		}
	}
}
