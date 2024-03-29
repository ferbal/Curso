namespace Services
{
    using System.Collections.Generic;

    using Domain;

    public interface IInterestedService
    {
        IList<Interested> GetAll();

        Interested Get(int id);

        void Create(string name, string phone);

        void Update(int id, string name, string phone,IList<Home> homes);

        void Delete(int id);

        void DelHomeFromList(int interestedId,int homeId);
    }
}