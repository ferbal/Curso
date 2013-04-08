namespace Services
{
    using System.Collections.Generic;

    using Domain;

    public interface IInmuebleService
    {
        IList<Home> GetAll();

        Home Get(int id);

        void Create(int pos,string address, string detail, Realty realty);

        void Update(int id, string address, string detail, Realty realty);

        void Delete(int id);
    }
}