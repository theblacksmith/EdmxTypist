using System.Xml.Linq;
namespace EdmxTypist.Model
{
	public partial class MetaComplexTypeProperty
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ScalarProperty;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml example:
		/// <![CDATA[
		///		<Property Type="String" Name="City" MaxLength="50" FixedLength="false" Unicode="true" />
		/// ]]>
		/// </example>
		/// <param name="file"></param>
		/// <param name="ct"></param>
		/// <param name="prop"></param>
		/// <returns></returns>
		public static MetaComplexTypeProperty Parse(MetaModel metaModel, MetaComplexType ct, XElement prop)
		{
			var p = new MetaComplexTypeProperty
			        	{
			        		FullName = ct.FullName.Dot(prop.Att("Name")), 
							Name = prop.Att("Name"), 
							Type = prop.Att("Type"),
							ComplexType = ct
			        	};
			
			return p;
		}
	}
}
