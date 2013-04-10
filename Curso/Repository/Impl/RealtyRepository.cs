namespace Repository.Impl
{
    using System.Collections.Generic;

    using Domain;
    using Domain.Exceptions;

    using Repository.Interfaces;

    public class RealtyRepository : BaseRepository<Realty>, IRealtyRepository
    {
        public RealtyRepository(HibernateSessionFactory hibernateSessionFactory) : base(hibernateSessionFactory)
        {
        }
    }
}
