namespace EdmxTypist.Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using resources;

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
