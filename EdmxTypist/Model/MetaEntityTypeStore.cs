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
