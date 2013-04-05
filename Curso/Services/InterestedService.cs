namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Repository.Interfaces;
    using Repository.Impl;


    public class InterestedService : IInterestedService
    {
        private readonly InterestedRepository repoInterested;
        
        public InterestedService(InterestedRepository interestedRepository)
        {
            this.repoInterested = interestedRepository;        
        }

        public IList<Interested> GetAll()
        {
            IList<Interested> result = null;
            this.repoInterested.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoInterested.GetAll();
            });

            return result;
        }

        public Interested Get(int id)
        {
            Interested result = null;
            this.repoInterested.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoInterested.Get(id);
            });
            return result;
        }

        public void Create(string name, string phone)
        {
            this.repoInterested.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var interested = new Interested(name,phone);
                this.repoInterested.Add(interested);
            });
        }

        public void Update(int id, string name, string phone)
        {
            this.repoInterested.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var interested = this.repoInterested.Get(id);
                interested.Update(name, phone);
            });
        }

        public void Delete(int id)
        {
            this.repoInterested.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var interested = this.repoInterested.Get(id);               
                this.repoInterested.Delete(interested);
                interested.Delete();
            });
        }
    }
}
