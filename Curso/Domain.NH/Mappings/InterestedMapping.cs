namespace Domain.NH.Mappings
{
    using FluentNHibernate.Mapping;

    public class InterestedMapping : ClassMap<Interested>
    {
        public InterestedMapping()
        {
            this.Id(interested => interested.Id).Not.Nullable();
            this.Map(interested => interested.Name).Not.Nullable().Length(50).Not.LazyLoad();
            this.Map(interested => interested.Phone).Not.Nullable().Not.LazyLoad();
            //this.References(inmueble => inmueble.Realty).Not.Nullable().Not.LazyLoad();            
            //this.HasMany(inmueble => inmueble.InterestedPeople).AsBag().Table("Interested").KeyColumn("Interested_Id").Inverse().LazyLoad();

            // References(manager => manager.Link).Nullable().Not.LazyLoad();
            // HasManyToMany(manager => manager.MuchosAMuchos).AsBag().ParentKeyColumn("Manager_Id").ChildKeyColumn("Otro_Id").Table("UserToRole").LazyLoad();
            // HasMany(user => user.UnoAMuchos).AsBag().Table("Nombre").KeyColumn("Manager_Id").LazyLoad();
        }
    }
}
