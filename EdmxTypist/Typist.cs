/**
 * This file is part of Edmx Typist  - A cyber typist to help you fix your edmx file.
 * Copyright (C) 2012 Saulo Vallory <me@saulovallory.com>
 * 
 * Edmx Typist is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * Edmx Typist is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Edmx Typist. If not, see <http://www.gnu.org/licenses/>.
 */
namespace EdmxTypist
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Windows.Forms;
	using System.Xml.Linq;
	using Flexer;
	using ModelInfo;
	using Model;
	using Options;
	using Renamer;

	/// <summary>
	/// Our Holy Typist. It processes our model and type the name we want for each piece according to our options.
	/// </summary>
	/// <remarks>
	///		It all begins in the conceptual model because it's the only part always present. 
	/// Each MetaObject knows how to find it's complementary elements inside Storage Schema and C-S Mapping
	/// Since we are using EF for storing the meta model, references are automatically updated
	/// after building the meta model, we process the xml again, this time replacing the names.
	/// For each name to be replaced, the relevant meta model object is passed as an info parameter.
	/// This allows custom renamers to use any relanship or related data to decide how the Entity, Property, 
	/// or any other piece should be named.
	/// </remarks>
	public class Typist
	{
		private IRenamer Renamer;

		// todo: clean up this mess. Some of the namespace fields aren't even used.
		private readonly XNamespace edmxNS = "http://schemas.microsoft.com/ado/2008/10/edmx";
		private readonly XNamespace edmNS = "http://schemas.microsoft.com/ado/2008/09/edm";
		private readonly XNamespace mappingNS = "http://schemas.microsoft.com/ado/2008/09/mapping/cs";
		private readonly XNamespace storeNS = "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator";
		private readonly XNamespace annotationNS = "http://schemas.microsoft.com/ado/2009/02/edm/annotation";

		/// <summary>
		/// The Namespace for Storage Schema
		/// </summary>
		public const string SSDL_NS = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl";

		/// <summary>
		/// The Namespace for Conceptual Schema
		/// </summary>
		public const string CSDL_NS = "http://schemas.microsoft.com/ado/2008/09/edm";

		/// <summary>
		/// The Namespace for C-S Mapping
		/// </summary>
		public const string MSL_NS = "http://schemas.microsoft.com/ado/2008/09/mapping/cs";

		/// <summary>
		/// The Namespace for the Diagram tags
		/// </summary>
		public const string Diagram_NS = "http://schemas.microsoft.com/ado/2008/10/edmx";

		/// <summary>
		/// The XDoc for the current run
		/// </summary>
		private XDocument xdoc;

		/// <summary>
		/// Options for the current run
		/// </summary>
		public GlobalOptions Options;

		/// <summary>
		/// The meta model for the current run
		/// </summary>
		public MetaModel MModel;
		
		private XDocument GetXdoc(string source)
		{
			xdoc = XDocument.Load(source);

			if (xdoc.Root == null)
				throw new Exception("Couldn't load the edmx file");

			return xdoc;
		}

		public void Run(string source, RuleSet ruleSet, GlobalOptions options, Type customRenamerType = null)
		{
			var edmxFile = new EdmxFile(source);

			MModel = new MetaModel(edmxFile);

			Options = options;

			if (customRenamerType != null)
			{
				//Renamer = (IRenamer) Activator.CreateInstance(customRenamerType, ruleSet, Options);
			}
			else
				Renamer = new DefaultRenamer(ruleSet, Options);

			ProcessCSDL(edmxFile.Concept);
			ProcessMSL(edmxFile.Mapping);
			ProcessDesigner(edmxFile.Diagram);

			edmxFile.Save(options.GetOutputPath(source));
		}

		private void ProcessDesigner(XElement ds)
		{
			// Diagram > EntityTypeShape.EntityType

			// <EntityTypeShape EntityType="Movies.Movie" Width="1.5" PointX="3" PointY="1" Height="2.3648893229166661" />
			foreach (var shape in ds.D("EntityTypeShape"))
			{
				shape.Att("EntityType", Renamer.GetName(MModel.EntityTypes[shape.Att("EntityType")], shape.Att("EntityType")));
			}
		}

		// CSDL
		private void ProcessCSDL(XElement schema)
		{
			// edmx:Runtime
			//    > edmx:ConceptualModels > Schema 
			//        > EntityContainer 
			//			  > EntitySet.EntityType="MinModel.BlogComentariosUsers"
			//        > EntityType.Name
			//            > Key > PropertyRef.Name
			//            > Property.Name
			//			  > NavigationProperty.Name

			var ns = schema.Att("Namespace");

			// Begining with association so we can save multiplicity and use it later
			// <Association Name="FK_pedidos_usuarios">
			foreach (var assoc in schema.Es("Association"))
			{
				var assocName = ns.Dot(assoc.Att("Name"));

				// <End Type="Movies.Genre" Role="genre" Multiplicity="0..1" />
				foreach (var end in assoc.Es("End"))
				{
					var oldRoleName = end.Att("Role");
					var fullRoleName = assocName.Dot(oldRoleName);

					// renaming EntityType
					var etName = end.Att("Type");
					end.Att("Type", Renamer.GetName(MModel.EntityTypes[etName], etName));

					// renaming role
					var role = MModel.AssociationRoles[fullRoleName];

					var newRoleName = Renamer.GetName(role, oldRoleName);

					//end.Att("Role", newRoleName);

					// <Principal Role="usuarios">
					//   <PropertyRef Name="user_id" /></Principal>
					// <Dependent Role="pedidos">
					//   <PropertyRef Name="user_id" /></Dependant>
					var node =
						assoc.Descendants().FirstOrDefault(e => (
								e.Name.LocalName == "Principal" || 
								e.Name.LocalName == "Dependent") 
						        && e.Att("Role") == oldRoleName);

					//node.Att("Role", Renamer.GetName(role, node.Att("Role")));

					var pRef = node.E("PropertyRef");
					pRef.Att("Name", Renamer.GetName(MModel.ScalarProperties[etName.Dot(pRef.Att("Name"))], pRef.Att("Name")));
				}
			}

			// <EntityContainer Name="MoviesContainer" annotation:LazyLoadingEnabled="true">
			var eCont = schema.E("EntityContainer");
			var containerName = ns.Dot(eCont.Att("Name"));

			// <EntitySet Name="Genres" EntityType="Movies.Genre" />
			foreach (var eSet in eCont.Es("EntitySet"))
			{
				eSet.Att("Name", Renamer.GetName(MModel.EntitySets[containerName.Dot(eSet.Att("Name"))], eSet.Att("Name")));
				eSet.Att("EntityType", Renamer.GetName(MModel.EntityTypes[eSet.Att("EntityType")], eSet.Att("EntityType")));
			}

			// renaming EntitySet
			//     <End Role="pedidos" EntitySet="pedidos" />
			foreach (var end in eCont.D("End"))
			{
				var esFullName = containerName.Dot(end.Att("EntitySet"));
				end.Att("EntitySet", Renamer.GetName(MModel.EntitySets[esFullName], end.Att("EntitySet")));
			}

			foreach (var eType in schema.Es("EntityType"))
			{
				var etFullName = ns.Dot(eType.Att("Name"));

				// <EntityType Name="pedidos">
				eType.Att("Name", Renamer.GetName(MModel.EntityTypes[etFullName], eType.Att("Name")));
			
				// <Key>
				//   <PropertyRef Name="pedido_id" />
				foreach (var pRef in eType.D("PropertyRef"))
					pRef.Att("Name", Renamer.GetName(MModel.ScalarProperties[etFullName.Dot(pRef.Att("Name"))], pRef.Att("Name")));

				// <Property Name="pedido_id" Type="Int32" Nullable="false" />
				foreach (var prop in eType.Es("Property"))
				{
					if(MetaComplexProperty.IsComplexPropertyNode(MModel, prop))
					{
						prop.Att("Name", Renamer.GetName(MModel.ComplexProperties[etFullName.Dot(prop.Att("Name"))], prop.Att("Name")));
					}
					else
						prop.Att("Name", Renamer.GetName(MModel.ScalarProperties[etFullName.Dot(prop.Att("Name"))], prop.Att("Name")));
				}

				// <NavigationProperty Name="usuarios" Relationship="InflectorTestModel.FK_pedidos_usuarios" FromRole="pedidos" ToRole="usuarios" />
				foreach (var prop in eType.Es("NavigationProperty"))
					prop.Att("Name", Renamer.GetName(MModel.NavigationProperties[etFullName.Dot(prop.Att("Name"))], prop.Att("Name")));
			}

			foreach (var ctNode in schema.Es("ComplexType"))
			{
				//		<ComplexType Name="Location">
				//          <Property Type="String" Name="City" MaxLength="50" FixedLength="false" Unicode="true" />
				//          <Property Type="String" Name="State" MaxLength="50" FixedLength="false" Unicode="true" />
				//          <Property Type="String" Name="Country" MaxLength="50" FixedLength="false" Unicode="true" />
				//        </ComplexType>
				var ct = MModel.ComplexTypes[ns.Dot(ctNode.Att("Name"))];

				foreach (var ctProp in ctNode.Es("Property"))
				{
					var ctpFullName = ct.FullName.Dot(ctProp.Att("Name"));
					ctProp.Att("Name", Renamer.GetName(ct.Properties.First(p => p.FullName == ctpFullName), ctProp.Att("Name")));
				}
			}

		}

		// MSL
		private void ProcessMSL(XElement mapping)
		{
			//    > edmx:Mappings > Mapping > EntityContainerMapping > EntitySetMapping 
			//        > EntityTypeMapping.TypeName
			//        > MappingFragment > ScalarProperty.Name

			var ns = mapping.Es("Alias").FirstWhere("Key", "Model").Att("Value");

			// <EntityContainerMapping CdmEntityContainer="MoviesContainer" StorageEntityContainer="MoviesStoreContainer">
			var container = mapping.D("EntityContainerMapping").FirstOrDefault();

			var ctnrName = ns.Dot(container.Att("CdmEntityContainer"));

			foreach(var eSetMap in mapping.D("EntitySetMapping"))
			{
				// <EntitySetMapping Name="Genres">
				eSetMap.Att("Name", Renamer.GetName(MModel.EntitySets[ctnrName.Dot(eSetMap.Att("Name"))], eSetMap.Att("Name")));

				// <EntityTypeMapping TypeName="Movies.Genre">
				foreach (var etMap in eSetMap.Es("EntityTypeMapping"))
				{
					var etFullName = etMap.Att("TypeName");

					etMap.Att("TypeName", Renamer.GetName(MModel.EntityTypes[etFullName], etFullName));

					// <MappingFragment StoreEntitySet="pedidos">
					var mapFrag = etMap.E("MappingFragment");

					if (mapFrag != null)
					{
						foreach (var scProp in mapFrag.Es("ScalarProperty"))
						{
							scProp.Att("Name", Renamer.GetName(MModel.ScalarProperties[etFullName.Dot(scProp.Att("Name"))], scProp.Att("Name")));
						}

						foreach (var cProp in mapFrag.Es("ComplexProperty"))
						{
							//	<ComplexProperty Name="Shooting">
							//	  <ScalarProperty Name="Country" ColumnName="shooting_country" />
							//	  <ScalarProperty Name="State" ColumnName="shooting_state" />
							//	  <ScalarProperty Name="City" ColumnName="shooting_city" />
							//	</ComplexProperty>

							var ctProp = MModel.ComplexProperties[etFullName.Dot(cProp.Att("Name"))];

							cProp.Att("Name", Renamer.GetName(ctProp, cProp.Att("Name")));

							var ct = ctProp.ComplexType;

							foreach (var scProp in cProp.Es("ScalarProperty"))
							{
								var ctpFullName = ct.FullName.Dot(scProp.Att("Name"));
								scProp.Att("Name", Renamer.GetName(ct.Properties.First(p => p.FullName == ctpFullName), scProp.Att("Name")));
							}
						}
					}
				}
			}
		}

		public EdmxNamesSample SampleNames(string source, int max = int.MaxValue)
		{
			xdoc = GetXdoc(source);

			var root = xdoc.Root;
			Debug.Assert(root != null, "root != null");

			var sample = new EdmxNamesSample();

			var eSets = root.Descendants(edmNS + "EntitySet");

			sample.EntitySets = eSets.Select((xe, i) => xe.Att("Name")).Distinct().Take(max).ToList();
			
			sample.EntityTypes = eSets.Select((xe, i) => xe.Att("EntityType").Split('.').Last()).Distinct().Take(max).ToList();
			
			sample.Scalars = root.Descendants(edmNS + "Property")
					.Select((x, i) => x.Att("Name")).Distinct().Take(max).ToList();
			
			sample.NavigationProperties = root.Descendants(edmNS + "NavigationProperty")
					.Select((x, i) => x.Att("Name")).Distinct().Take(max).ToList();
			
			sample.ComplexTypes = root.Descendants(edmNS + "ComplexType")
					.Select((x, i) => x.Att("Name")).Distinct().Take(max).ToList();

			sample.ComplexProperties = root.Descendants(XName.Get("ComplexProperty", MSL_NS))
					.Select((x, i) => x.Att("Name")).Distinct().Take(max).ToList();

			sample.Methods = root.Descendants(XName.Get("Function", SSDL_NS))
					.Select((x, i) => x.Att("Name").Split('.').Last()).Distinct().Take(max).ToList();
			
			// associations
			sample.Associations = root.Descendants(edmNS + "End")
					.Select((x, i) => x.Att("Role")).Distinct().Take(max).ToList();

			return sample;
		}

		private IRenamer GetRenamer()
		{
			return Renamer;
		}
	}
}
