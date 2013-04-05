namespace Domain.NH.Mappings
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// The manager mapping.
    /// </summary>
    public class InmuebleMapping : ClassMap<Home>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerMapping"/> class.
        /// </summary>
        public InmuebleMapping()
        {
            this.Id(inmueble => inmueble.Id).GeneratedBy.Increment();
            this.Map(inmueble => inmueble.Address).Not.Nullable().Length(50).Not.LazyLoad();            
            this.Map(inmueble => inmueble.Details).Not.Nullable().Not.LazyLoad();
            //this.References(inmueble => inmueble.Realty).Not.Nullable().Not.LazyLoad();            
            //this.HasMany(inmueble => inmueble.InterestedPeople).AsBag().Table("Interested").KeyColumn("Interested_Id").Inverse().LazyLoad();

            // References(manager => manager.Link).Nullable().Not.LazyLoad();
            // HasManyToMany(manager => manager.MuchosAMuchos).AsBag().ParentKeyColumn("Manager_Id").ChildKeyColumn("Otro_Id").Table("UserToRole").LazyLoad();
            // HasMany(user => user.UnoAMuchos).AsBag().Table("Nombre").KeyColumn("Manager_Id").LazyLoad();
        }
    }
}
