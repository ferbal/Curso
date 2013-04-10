namespace Repository.Impl
{
    using System.Collections.Generic;

    using Domain;
    using Domain.Exceptions;

    using Repository.Interfaces;


    public class InterestedRepository : BaseRepository<Interested>, IInterestedRepository
    {

        public InterestedRepository(HibernateSessionFactory hibernateSessionFactory) : base(hibernateSessionFactory)
        {
        }
    }
}
