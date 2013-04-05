namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Repository.Interfaces;
    using Repository.Impl;


    public class InmuebleService : IInmuebleService
    {
        private readonly InmuebleRepository repoHome;
        
        public InmuebleService(InmuebleRepository inmuebleRepository)
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

        public void Create(string address, string detail)
        {
            this.repoHome.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var inmueble = new Home(null,address,detail);
                this.repoHome.Add(inmueble);
            });
        }

        public void Update(int id, string address, string detail)
        {
            this.repoHome.GetSessionFactory().TransactionalInterceptor(() =>
            {
                var inmueble = this.repoHome.Get(id);
                inmueble.Update(address, detail);
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
