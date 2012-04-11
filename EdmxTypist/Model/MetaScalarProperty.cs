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

	public partial class MetaScalarProperty
	{
		public static MetaScalarProperty Parse(MetaModel mmodel, MetaEntityType et, XElement node)
		{
			var fullName = et.FullName + '.' + node.Att("Name");

			if (mmodel.ScalarProperties.ContainsKey(fullName))
				return mmodel.ScalarProperties[fullName];

			var sp = new MetaScalarProperty()
			       	{
			       		FullName = fullName,
			       		Name = node.Att("Name"),
			       		Nullable = node.Att("Nullable") == "true",
			       		Type = node.Att("Type"),
			       		EntityType = et
			       	};

			mmodel.ScalarProperties.Add(fullName, sp);

			return sp;
		}

		public static void Link(MetaScalarProperty mp, MetaPropertyStore mps)
		{
			if (mp != null)
				mp.Store = mps;

			if(mps != null)
				mps.Concept = mp;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ScalarProperty;
		}
	}
}
