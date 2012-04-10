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
