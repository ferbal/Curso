namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Repository.Interfaces;
    using Repository.Impl;


    public class RealtyService : IRealtyService
    {
        private readonly RealtyRepository repoRealty;
        
        public RealtyService(RealtyRepository realtyRepository)
        {
            this.repoRealty = realtyRepository;        
        }

        public IList<Realty> GetAll()
        {
            IList<Realty> result = null;
            this.repoRealty.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoRealty.GetAll();
            });

            return result;
        }

        public Realty Get(int id)
        {
            Realty result = null;
            this.repoRealty.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoRealty.Get(id);
            });
            return result;
        }

        public void Create(int id, string name, string address, string detail, Manager manager)
        {
            this.repoRealty.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var realty = new Realty(id,name,address,detail,manager);
                this.repoRealty.Add(realty);
            });                        
        }

        public void Update(int id, string name, string address, string detail,Manager manager)
        {
            this.repoRealty.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var realty = this.repoRealty.Get(id);
                realty.Update(name,address, detail, manager);
            });
        }

        public void Delete(int id)
        {
            this.repoRealty.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var realty = this.repoRealty.Get(id);               
                this.repoRealty.Delete(realty);
                realty.Delete();
            });
        }
    }
}
