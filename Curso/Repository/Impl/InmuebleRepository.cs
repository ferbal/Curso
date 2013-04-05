namespace Repository.Impl
{
    using System.Collections.Generic;

    using Domain;
    using Domain.Exceptions;

    using Repository.Interfaces;

    public class InmuebleRepository : BaseRepository<Home>, IInmuebleRepository
    {
        public InmuebleRepository(HibernateSessionFactory hibernateSessionFactory) : base(hibernateSessionFactory)
        {   
        }
    }
}
