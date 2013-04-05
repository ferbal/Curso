namespace Services
{
    using System.Collections.Generic;

    using Domain;

    public interface IInmuebleService
    {
        IList<Home> GetAll();

        Home Get(int id);

        void Create(string address, string detail);

        void Update(int id, string address, string detail);

        void Delete(int id);
    }
}