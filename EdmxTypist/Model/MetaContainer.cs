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
