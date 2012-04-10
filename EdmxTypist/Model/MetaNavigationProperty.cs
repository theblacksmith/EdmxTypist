using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxTypist.Model
{
	using System.Xml.Linq;

	public partial class MetaNavigationProperty
	{
		// <NavigationProperty Name="Movies" Relationship="Movies.FK_movies_genres" FromRole="genre" ToRole="movie" />
		public static MetaNavigationProperty Parse(MetaModel mmodel, MetaEntityType et, XElement node)
		{
			var fullName = et.FullName + '.' + node.Att("Name");

			if (mmodel.NavigationProperties.ContainsKey(fullName))
				return mmodel.NavigationProperties[fullName];

			var m = new MetaNavigationProperty
			        	{
			        		FullName = fullName,
			        		Name = node.Att("Name")
			        	};

			mmodel.NavigationProperties.Add(fullName, m);

			m.AssociationRole = MetaAssociationRole.Parse(mmodel, et, node);

			m.EntityType = m.AssociationRole.ToEntityType;

			return m;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.NavigationProperty;
		}
	}
}
