namespace Services
{
    using System.Collections.Generic;

    using Domain;

    public interface IRealtyService
    {
        IList<Realty> GetAll();

        Realty Get(int id);

        void Create(int id,string name, string address, string detail, Manager manager);

        void Update(int id, string name, string address, string detail, Manager manager);

        void Delete(int id);
    }
}