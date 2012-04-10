using System.Xml.Linq;
namespace EdmxTypist.Model
{
	public partial class MetaComplexType : RenameableObject
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ComplexType;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml Example:
		/// <![CDATA[
		///		<ComplexType Name="Location">
		///			<Property Type="String" Name="City" MaxLength="50" FixedLength="false" Unicode="true" />
		///			<Property Type="String" Name="State" MaxLength="50" FixedLength="false" Unicode="true" />
		///			<Property Type="String" Name="Country" MaxLength="50" FixedLength="false" Unicode="true" />
		///		</ComplexType>
		/// ]]>
		/// </example>
		/// <param name="metaModel"></param>
		/// <param name="cType"></param>
		/// <returns></returns>
		public static MetaComplexType Parse(MetaModel metaModel, XElement cType)
		{
			var fullName = metaModel.Namespace.Dot(cType.Att("Name"));

			if (metaModel.ComplexTypes.ContainsKey(fullName))
				return metaModel.ComplexTypes[fullName];

			var ct = new MetaComplexType();

			ct.FullName = fullName;
			ct.Name = cType.Att("Name");

			foreach (var prop in cType.Es("Property"))
			{
				ct.Properties.Add(MetaComplexTypeProperty.Parse(metaModel, ct, prop));
			}

			metaModel.ComplexTypes.Add(ct.FullName, ct);

			return ct;
		}

		public static XElement FindNode(MetaModel mmodel, string name)
		{
			return mmodel.EdmxFile.Concept.Es("ComplexType").WithName(name.LastPart());
		}
	}
}
