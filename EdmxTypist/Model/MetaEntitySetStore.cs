using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxTypist.Model
{
	/// <summary>
	///		
	/// </summary>
	/// <example>
	///		Storage XML example:
	///		<![CDATA[
	///			<EntitySet Name="genres" EntityType="Movies.Store.genres" store:Type="Tables" Schema="dbo" />
	///		]]>
	/// </example>
	public partial class MetaEntitySetStore
	{
		public static MetaEntitySetStore Parse(EdmxFile file, string fullName)
		{
			var name = fullName.LastPart();
			var xel = file.Storage.D("EntitySet").FirstWhere("Name",name);

			if (xel != null)
			{
				var m = new MetaEntitySetStore();

				m.FullName = fullName;
				m.Name = name;
				m.Type = xel.Att("store:Type");
				m.Schema = xel.Att("Schema");

				m.EntityTypeStore = MetaEntityTypeStore.Parse(file, xel.Att("EntityType"), m);

				return m;
			}

			return null;
		}
	}
}
