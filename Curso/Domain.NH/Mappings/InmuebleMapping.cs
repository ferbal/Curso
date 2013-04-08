namespace Domain.NH.Mappings
{
    using FluentNHibernate.Mapping;

    public class InmuebleMapping : ClassMap<Home>
    {
        
        public InmuebleMapping()
        {
            this.Id(inmueble => inmueble.Id).GeneratedBy.Increment();
            this.Map(inmueble => inmueble.Address).Not.Nullable().Length(50).Not.LazyLoad();            
            this.Map(inmueble => inmueble.Details).Not.Nullable().Not.LazyLoad();
            this.References(inmueble => inmueble.Realty).Not.Nullable().Not.LazyLoad();
            this.HasManyToMany(inmueble => inmueble.InterestedPeople).AsBag().ParentKeyColumn("Interested_Id").ChildKeyColumn("Home_Id").Table("InterestedHouse").Not.LazyLoad();            
        }
    }
}
