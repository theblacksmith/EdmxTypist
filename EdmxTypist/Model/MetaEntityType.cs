namespace EdmxTypist.Model
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml.Linq;

	/// <summary>
	/// 
	/// </summary>
	/// <example>
	///		Concept Xml:
	///		<![CDATA[
	///		<EntityType Name="Genre">
	///          <Key>
	///            <PropertyRef Name="Id" />
	///          </Key>
	///          <Property Type="Int32" Name="Id" Nullable="false" />
	///          <Property Type="String" Name="Name" Nullable="false" MaxLength="50" FixedLength="false" Unicode="true" />
	///          <NavigationProperty Name="Movies" Relationship="Movies.FK_movies_genres" FromRole="genre" ToRole="movie" />
	///        </EntityType>
	///		]]>
	///		Mapping Xml:
	///		<![CDATA[
	///			<EntitySetMapping Name="Genres">
	///            <EntityTypeMapping TypeName="Movies.Genre">
	///              <MappingFragment StoreEntitySet="genres">
	///                <ScalarProperty Name="Name" ColumnName="name" />
	///                <ScalarProperty Name="Id" ColumnName="genre_id" />
	///              </MappingFragment>
	///            </EntityTypeMapping>
	///          </EntitySetMapping>
	///		]]>
	/// </example>
	public partial class MetaEntityType
	{
		public const string NodeName = "EntityType";
		
		public static MetaEntityType Parse(MetaModel mmodel, string fullName, MetaEntitySet eSet = null)
		{
			if (mmodel.EntityTypes.ContainsKey(fullName))
				return mmodel.EntityTypes[fullName];

			var m = new MetaEntityType
			        	{
			        		FullName = fullName, 
							Name = fullName.LastPart(), 
							EntitySet = eSet
			        	};

			// need to add before processing related meta-models
			mmodel.EntityTypes.Add(m.FullName, m);

			var node = mmodel.EdmxFile.Concept.D(NodeName).WithName(m.Name);

			var keyNames = (from k in node.D("PropertyRef") select k.Att("Name")).ToList();

			// parsing properties
			foreach (var scP in node.D("Property"))
			{
				// Property elements with a Type attribute reprents a ComplexProperty
				if (MetaComplexProperty.IsComplexPropertyNode(mmodel, scP))
				{
					m.ComplexProperties.Add(MetaComplexProperty.Parse(mmodel, m, scP));
				}
				else
				{
					var sp = MetaScalarProperty.Parse(mmodel, m, scP);
					sp.isKey = keyNames.Contains(scP.Att("Name"));

					m.Properties.Add(sp);
				}
			}

			foreach (var navP in node.D("NavigationProperty"))
			{
				m.NavigationProperties.Add(MetaNavigationProperty.Parse(mmodel, m, navP));
			}

			// todo: process store


			return m;
		}

		/// <summary>
		///	Links a MetaEntityType with a MetaEntityTypeStore all the way down do the properties.
		/// </summary>
		/// <example>
		///		Mapping Xml:
		///		<![CDATA[
        ///    <EntityTypeMapping TypeName="Movies.Movie">
        ///      <MappingFragment StoreEntitySet="movies">
        ///        <ScalarProperty Name="GenreId" ColumnName="genre_id" />
        ///        <ScalarProperty Name="Published" ColumnName="published" />
        ///        <ScalarProperty Name="Synopsis" ColumnName="synopsis" />
        ///        <ScalarProperty Name="Name" ColumnName="name" />
        ///        <ScalarProperty Name="Id" ColumnName="movie_id" />
        ///        <ComplexProperty Name="Shooting">
        ///          <ScalarProperty Name="Country" ColumnName="shooting_country" />
        ///          <ScalarProperty Name="State" ColumnName="shooting_state" />
        ///          <ScalarProperty Name="City" ColumnName="shooting_city" />
        ///        </ComplexProperty>
        ///      </MappingFragment>
		///    </EntityTypeMapping>
		///		]]>
		/// </example>
		public static void Link(MetaEntityType et, MetaEntityTypeStore ets, XElement mapping)
		{
			/*
			var propDic = (from prop in et.Properties select prop).ToDictionary(k => k.Name);
			var stPropDic = (from prop in ets.PropertiesStores select prop).ToDictionary(k => k.Name);

			foreach (var scP in mapping.d("ScalarProperty"))
			{
				MetaScalarProperty.Link(propDic[scP.Att("Name")], stPropDic[scP.Att("ColumnName")]);
			}

			var cPropDic = (from prop in et.ComplexProperties select prop).ToDictionary(k => k.Name);
			var stCPropDic = (from prop in ets.PropertyStores select prop).ToDictionary(k => k.Name);

			foreach (var scP in mapping.d("ComplexProperty"))
			{
				MetaComplexProperty.
				MetaScalarProperty.Link(propDic[scP.Att("Name")], stPropDic[scP.Att("ColumnName")]);
			}
			 * */
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.EntityType;
		}
	}
}
