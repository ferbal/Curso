namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Repository.Interfaces;
    using Repository.Impl;



    public class InmuebleService : IInmuebleService
    {
        private readonly IInmuebleRepository repoHome;
        
        public InmuebleService(IInmuebleRepository inmuebleRepository)
        {
            this.repoHome = inmuebleRepository;        
        }

        public IList<Home> GetAll()
        {
            IList<Home> result = null;
            this.repoHome.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoHome.GetAll();
            });

            return result;
        }

        public Home Get(int id)
        {
            Home result = null;
            this.repoHome.GetSessionFactory().SessionInterceptor(() =>
            {
                result = this.repoHome.Get(id);
            });
            return result;
        }

        public void Create(int pos,string address, string detail,Realty realty)
        {
            this.repoHome.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var inmueble = new Home(pos,address,detail,realty);
                this.repoHome.Add(inmueble);
            });
        }

        public void Update(int id, string address, string detail,Realty realty)
        {
            this.repoHome.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var inmueble = this.repoHome.Get(id);
                inmueble.Update(address, detail,realty);
            });
        }

        public void Delete(int id)
        {
            this.repoHome.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var inmueble = this.repoHome.Get(id);               
                this.repoHome.Delete(inmueble);
                inmueble.Delete();
            });
        }
    }
}
