﻿namespace EdmxTypist.Model
{
	using System;
	using System.Linq;
	using System.Xml.Linq;

	public partial class MetaAssociationRole
	{
		public MultiplicityEnum Multiplicity
		{
			get
			{
				switch (MultiplicityValue)
				{
					case "1":
						return MultiplicityEnum.One;

					case "*":
						return MultiplicityEnum.Many;
						
					case "0..1":
						return MultiplicityEnum.ZeroOrOne;
						
					default:
						throw new Exception("MultiplicityValue property for association " + FullName + " has an invalid value. It shouldn't happen since it's a private property.");
				}
			}
			set
			{
				switch (value)
				{
					case MultiplicityEnum.One:
						MultiplicityValue = "1";
						break;

					case MultiplicityEnum.Many:
						MultiplicityValue = "*";
						break;

					case MultiplicityEnum.ZeroOrOne:
						MultiplicityValue = "0..1";
						break;
					default:
						throw new Exception("Invalid MultiplicityValue. If you updated the MultiplicityEnum, you have to update the MetaAssociationRole.Multiplicity property as well.");
				}
			}
		}

		/*
		 * <Association Name="FK_movies_genres">
	  <End Type="Movies.Genre" Role="genre" Multiplicity="0..1" />
	  <End Type="Movies.Movie" Role="movie" Multiplicity="*" />
	  <ReferentialConstraint>
		<Principal Role="genre">
		  <PropertyRef Name="Id" />
		</Principal>
		<Dependent Role="movie">
		  <PropertyRef Name="GenreId" />
		</Dependent>
	  </ReferentialConstraint>
	</Association>
		 * */

		public static MetaAssociationRole Parse(MetaModel mmodel, MetaEntityType fromET, XElement navP)
		{
			var fullName = navP.Att("Relationship") + '.' + navP.Att("ToRole");

			if(mmodel.AssociationRoles.ContainsKey(fullName))
				return mmodel.AssociationRoles[fullName];

			// navP : <NavigationProperty Name="Movies" Relationship="Movies.FK_movies_genres" FromRole="genre" ToRole="movie" />
			var a = new MetaAssociationRole();

			a.FullName = fullName;
			a.Name = a.FullName.LastPart();
			a.NavigationProperty = (from p in fromET.NavigationProperties where p.Name == navP.Att("Name") select p).FirstOrDefault();

			mmodel.AssociationRoles.Add(a.FullName, a);

			var assNode = mmodel.EdmxFile.Concept.D("Association").WithName(navP.Att("Relationship").LastPart());

			var role = assNode.Es("End").FirstWhere("Role", navP.Att("ToRole"));

			var toE = mmodel.EntityTypes.ContainsKey(role.Att("Type")) ? mmodel.EntityTypes[role.Att("Type")] : MetaEntityType.Parse(mmodel, role.Att("Type"));

			a.MultiplicityValue = role.Att("Multiplicity");
			a.ToEntityType = toE;

			return a;
		}

		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.AssociationRole;
		}
	}
}
