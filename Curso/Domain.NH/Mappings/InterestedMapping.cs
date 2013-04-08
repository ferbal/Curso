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
            this.HasManyToMany(interested => interested.Homes).AsBag().ParentKeyColumn("Home_Id").ChildKeyColumn("Interested_Id").Table("InterestedHouse").Not.LazyLoad();
        }
    }
}
