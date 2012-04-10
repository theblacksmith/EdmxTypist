using System.Xml.Linq;
namespace EdmxTypist.Model
{
	using System;

	public partial class MetaComplexProperty
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.ComplexProperty;
		}

		public static bool IsComplexPropertyNode(MetaModel mmodel, XElement scP)
		{
			if (mmodel.ComplexTypes.ContainsKey(scP.Att("Type")))
				return true;

			return mmodel.EdmxFile.Concept.Es("ComplexType").FirstWhere("Name", scP.Att("Type").LastPart()) != null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <example>
		/// Xml example:
		/// <![CDATA[
		///		<Property Name="Shooting" Type="Movies.Location" Nullable="false" />
		/// ]]>
		/// </example>
		///<param name="mmodel"></param>
		///<param name="entityType"> </param>
		///<param name="scP"></param>
		///<returns></returns>
		public static MetaComplexProperty Parse(MetaModel mmodel, MetaEntityType entityType, XElement scP)
		{
			var p = new MetaComplexProperty
			        	{
							EntityType = entityType,
							FullName = entityType.FullName.Dot(scP.Att("Name")),
							Name = scP.Att("Name"),
							Nullable = scP.Att("Name").ToLower() == "true"
			        	};

			mmodel.ComplexProperties.Add(p.FullName, p);

			MetaComplexType ct;

			if (mmodel.ComplexTypes.ContainsKey(scP.Att("Type")))
				ct = mmodel.ComplexTypes[scP.Att("Type")];
			else
			{
				var ctNode = MetaComplexType.FindNode(mmodel, scP.Att("Type"));

				if(ctNode == null)
					throw new Exception("Couldn't find the ComplexType " + scP.Att("Type") + 
						". The type was used in " + entityType.FullName.Dot(scP.Att("Name")));

				ct = MetaComplexType.Parse(mmodel, ctNode);
			}

			p.ComplexType = ct;

			return p;
		}
	}
}
