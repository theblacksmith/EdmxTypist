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
	using System.Xml.Linq;

	public partial class MetaContainer : RenameableObject
	{
		public const string NodeName = "EntityContainer";

		public static MetaContainer Parse(MetaModel mmodel, string name)
		{
			var node = mmodel.EdmxFile.Concept.D(NodeName).WithName(name);

			if (node == null)
				throw new Exception("Couldn't find the container " + name);

			return Parse(mmodel, node);
		}

		public static MetaContainer Parse(MetaModel mmodel, XElement node)
		{
			if(node.Name.LocalName != NodeName)
				throw new Exception("Invalid Node. To parse a " + NodeName + " you need to provide an XElement with the same name.");

			var c = new MetaContainer();

			c.Name = node.Att("Name");
			c.FullName = node.Parent.Att("Namespace") + '.' + c.Name;

			foreach (var eSet in node.Es("EntitySet"))
			{
				c.EntitySets.Add(MetaEntitySet.Parse(mmodel, c, eSet));
			}

			mmodel.Containers[c.FullName] = c;
			
			return c;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.Container;
		}
	}
}
