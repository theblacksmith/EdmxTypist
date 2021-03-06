﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Movies", "FK_movies_genres", "genre", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(EdmxTool.Tests.resources.genre), "movie", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EdmxTool.Tests.resources.movie), true)]
[assembly: EdmRelationshipAttribute("Movies", "FK_roles_movies", "movie", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EdmxTool.Tests.resources.movie), "role", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EdmxTool.Tests.resources.role), true)]
[assembly: EdmRelationshipAttribute("Movies", "FK_roles_people", "person", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EdmxTool.Tests.resources.person), "role", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EdmxTool.Tests.resources.role), true)]

#endregion

namespace EdmxTool.Tests.resources
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MoviesContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MoviesContainer object using the connection string found in the 'MoviesContainer' section of the application configuration file.
        /// </summary>
        public MoviesContainer() : base("name=MoviesContainer", "MoviesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesContainer object.
        /// </summary>
        public MoviesContainer(string connectionString) : base(connectionString, "MoviesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MoviesContainer object.
        /// </summary>
        public MoviesContainer(EntityConnection connection) : base(connection, "MoviesContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<genre> genres
        {
            get
            {
                if ((_genres == null))
                {
                    _genres = base.CreateObjectSet<genre>("genres");
                }
                return _genres;
            }
        }
        private ObjectSet<genre> _genres;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<movie> movies
        {
            get
            {
                if ((_movies == null))
                {
                    _movies = base.CreateObjectSet<movie>("movies");
                }
                return _movies;
            }
        }
        private ObjectSet<movie> _movies;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<person> people
        {
            get
            {
                if ((_people == null))
                {
                    _people = base.CreateObjectSet<person>("people");
                }
                return _people;
            }
        }
        private ObjectSet<person> _people;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<role> roles
        {
            get
            {
                if ((_roles == null))
                {
                    _roles = base.CreateObjectSet<role>("roles");
                }
                return _roles;
            }
        }
        private ObjectSet<role> _roles;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the genres EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTogenres(genre genre)
        {
            base.AddObject("genres", genre);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the movies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomovies(movie movie)
        {
            base.AddObject("movies", movie);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the people EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTopeople(person person)
        {
            base.AddObject("people", person);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToroles(role role)
        {
            base.AddObject("roles", role);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Movies", Name="genre")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class genre : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new genre object.
        /// </summary>
        /// <param name="genre_id">Initial value of the genre_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static genre Creategenre(global::System.Int32 genre_id, global::System.String name)
        {
            genre genre = new genre();
            genre.genre_id = genre_id;
            genre.name = name;
            return genre;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 genre_id
        {
            get
            {
                return _genre_id;
            }
            set
            {
                if (_genre_id != value)
                {
                    Ongenre_idChanging(value);
                    ReportPropertyChanging("genre_id");
                    _genre_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("genre_id");
                    Ongenre_idChanged();
                }
            }
        }
        private global::System.Int32 _genre_id;
        partial void Ongenre_idChanging(global::System.Int32 value);
        partial void Ongenre_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_movies_genres", "movie")]
        public EntityCollection<movie> movies
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<movie>("Movies.FK_movies_genres", "movie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<movie>("Movies.FK_movies_genres", "movie", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Movies", Name="movie")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class movie : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new movie object.
        /// </summary>
        /// <param name="movie_id">Initial value of the movie_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="shooting">Initial value of the shooting property.</param>
        public static movie Createmovie(global::System.Int32 movie_id, global::System.String name, Location shooting)
        {
            movie movie = new movie();
            movie.movie_id = movie_id;
            movie.name = name;
            movie.shooting = StructuralObject.VerifyComplexObjectIsNotNull(shooting, "shooting");
            return movie;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 movie_id
        {
            get
            {
                return _movie_id;
            }
            set
            {
                if (_movie_id != value)
                {
                    Onmovie_idChanging(value);
                    ReportPropertyChanging("movie_id");
                    _movie_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("movie_id");
                    Onmovie_idChanged();
                }
            }
        }
        private global::System.Int32 _movie_id;
        partial void Onmovie_idChanging(global::System.Int32 value);
        partial void Onmovie_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String synopsis
        {
            get
            {
                return _synopsis;
            }
            set
            {
                OnsynopsisChanging(value);
                ReportPropertyChanging("synopsis");
                _synopsis = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("synopsis");
                OnsynopsisChanged();
            }
        }
        private global::System.String _synopsis;
        partial void OnsynopsisChanging(global::System.String value);
        partial void OnsynopsisChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> published
        {
            get
            {
                return _published;
            }
            set
            {
                OnpublishedChanging(value);
                ReportPropertyChanging("published");
                _published = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("published");
                OnpublishedChanged();
            }
        }
        private Nullable<global::System.DateTime> _published;
        partial void OnpublishedChanging(Nullable<global::System.DateTime> value);
        partial void OnpublishedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> genre_id
        {
            get
            {
                return _genre_id;
            }
            set
            {
                Ongenre_idChanging(value);
                ReportPropertyChanging("genre_id");
                _genre_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("genre_id");
                Ongenre_idChanged();
            }
        }
        private Nullable<global::System.Int32> _genre_id;
        partial void Ongenre_idChanging(Nullable<global::System.Int32> value);
        partial void Ongenre_idChanged();

        #endregion

        #region Complex Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Location shooting
        {
            get
            {
                _shooting = GetValidValue(_shooting, "shooting", false, _shootingInitialized);
                _shootingInitialized = true;
                return _shooting;
            }
            set
            {
                OnshootingChanging(value);
                ReportPropertyChanging("shooting");
                _shooting = SetValidValue(_shooting, value, "shooting");
                _shootingInitialized = true;
                ReportPropertyChanged("shooting");
                OnshootingChanged();
            }
        }
        private Location _shooting;
        private bool _shootingInitialized;
        partial void OnshootingChanging(Location value);
        partial void OnshootingChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_movies_genres", "genre")]
        public genre genre
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<genre>("Movies.FK_movies_genres", "genre").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<genre>("Movies.FK_movies_genres", "genre").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<genre> genreReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<genre>("Movies.FK_movies_genres", "genre");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<genre>("Movies.FK_movies_genres", "genre", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_roles_movies", "role")]
        public EntityCollection<role> roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<role>("Movies.FK_roles_movies", "role");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<role>("Movies.FK_roles_movies", "role", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Movies", Name="person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new person object.
        /// </summary>
        /// <param name="person_id">Initial value of the person_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="birthplace">Initial value of the birthplace property.</param>
        public static person Createperson(global::System.Int32 person_id, global::System.String name, Location birthplace)
        {
            person person = new person();
            person.person_id = person_id;
            person.name = name;
            person.birthplace = StructuralObject.VerifyComplexObjectIsNotNull(birthplace, "birthplace");
            return person;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 person_id
        {
            get
            {
                return _person_id;
            }
            set
            {
                if (_person_id != value)
                {
                    Onperson_idChanging(value);
                    ReportPropertyChanging("person_id");
                    _person_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("person_id");
                    Onperson_idChanged();
                }
            }
        }
        private global::System.Int32 _person_id;
        partial void Onperson_idChanging(global::System.Int32 value);
        partial void Onperson_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> birth_date
        {
            get
            {
                return _birth_date;
            }
            set
            {
                Onbirth_dateChanging(value);
                ReportPropertyChanging("birth_date");
                _birth_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("birth_date");
                Onbirth_dateChanged();
            }
        }
        private Nullable<global::System.DateTime> _birth_date;
        partial void Onbirth_dateChanging(Nullable<global::System.DateTime> value);
        partial void Onbirth_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String gender
        {
            get
            {
                return _gender;
            }
            set
            {
                OngenderChanging(value);
                ReportPropertyChanging("gender");
                _gender = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("gender");
                OngenderChanged();
            }
        }
        private global::System.String _gender;
        partial void OngenderChanging(global::System.String value);
        partial void OngenderChanged();

        #endregion

        #region Complex Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Location birthplace
        {
            get
            {
                _birthplace = GetValidValue(_birthplace, "birthplace", false, _birthplaceInitialized);
                _birthplaceInitialized = true;
                return _birthplace;
            }
            set
            {
                OnbirthplaceChanging(value);
                ReportPropertyChanging("birthplace");
                _birthplace = SetValidValue(_birthplace, value, "birthplace");
                _birthplaceInitialized = true;
                ReportPropertyChanged("birthplace");
                OnbirthplaceChanged();
            }
        }
        private Location _birthplace;
        private bool _birthplaceInitialized;
        partial void OnbirthplaceChanging(Location value);
        partial void OnbirthplaceChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_roles_people", "role")]
        public EntityCollection<role> roles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<role>("Movies.FK_roles_people", "role");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<role>("Movies.FK_roles_people", "role", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Movies", Name="role")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class role : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new role object.
        /// </summary>
        /// <param name="role_id">Initial value of the role_id property.</param>
        /// <param name="person_id">Initial value of the person_id property.</param>
        /// <param name="movie_id">Initial value of the movie_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static role Createrole(global::System.Int32 role_id, global::System.Int32 person_id, global::System.Int32 movie_id, global::System.String name)
        {
            role role = new role();
            role.role_id = role_id;
            role.person_id = person_id;
            role.movie_id = movie_id;
            role.name = name;
            return role;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 role_id
        {
            get
            {
                return _role_id;
            }
            set
            {
                if (_role_id != value)
                {
                    Onrole_idChanging(value);
                    ReportPropertyChanging("role_id");
                    _role_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("role_id");
                    Onrole_idChanged();
                }
            }
        }
        private global::System.Int32 _role_id;
        partial void Onrole_idChanging(global::System.Int32 value);
        partial void Onrole_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 person_id
        {
            get
            {
                return _person_id;
            }
            set
            {
                Onperson_idChanging(value);
                ReportPropertyChanging("person_id");
                _person_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("person_id");
                Onperson_idChanged();
            }
        }
        private global::System.Int32 _person_id;
        partial void Onperson_idChanging(global::System.Int32 value);
        partial void Onperson_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 movie_id
        {
            get
            {
                return _movie_id;
            }
            set
            {
                Onmovie_idChanging(value);
                ReportPropertyChanging("movie_id");
                _movie_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("movie_id");
                Onmovie_idChanged();
            }
        }
        private global::System.Int32 _movie_id;
        partial void Onmovie_idChanging(global::System.Int32 value);
        partial void Onmovie_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_roles_movies", "movie")]
        public movie movie
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<movie>("Movies.FK_roles_movies", "movie").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<movie>("Movies.FK_roles_movies", "movie").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<movie> movieReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<movie>("Movies.FK_roles_movies", "movie");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<movie>("Movies.FK_roles_movies", "movie", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Movies", "FK_roles_people", "person")]
        public person person
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<person>("Movies.FK_roles_people", "person").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<person>("Movies.FK_roles_people", "person").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<person> personReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<person>("Movies.FK_roles_people", "person");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<person>("Movies.FK_roles_people", "person", value);
                }
            }
        }

        #endregion

    }

    #endregion

    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="Movies", Name="Location")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class Location : ComplexObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String city
        {
            get
            {
                return _city;
            }
            set
            {
                OncityChanging(value);
                ReportPropertyChanging("city");
                _city = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("city");
                OncityChanged();
            }
        }
        private global::System.String _city;
        partial void OncityChanging(global::System.String value);
        partial void OncityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String state
        {
            get
            {
                return _state;
            }
            set
            {
                OnstateChanging(value);
                ReportPropertyChanging("state");
                _state = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("state");
                OnstateChanged();
            }
        }
        private global::System.String _state;
        partial void OnstateChanging(global::System.String value);
        partial void OnstateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String country
        {
            get
            {
                return _country;
            }
            set
            {
                OncountryChanging(value);
                ReportPropertyChanging("country");
                _country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("country");
                OncountryChanged();
            }
        }
        private global::System.String _country;
        partial void OncountryChanging(global::System.String value);
        partial void OncountryChanged();

        #endregion

    }

    #endregion

    
}
