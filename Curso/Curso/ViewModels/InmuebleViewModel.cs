namespace Curso.ViewModels
{
    using System.Collections.Generic;
    using Domain;

    public class InmuebleViewModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Details { get; set; }

        public Realty Realty { get; set; }

        public int InterestedId { get; set; } 

        public IList<Interested> InterestedPeople { get; set; }

        public InmuebleViewModel(int id, string address, string details, Realty realty)
        {
            this.Id = id;
            this.Address = address;
            this.Details = details;
            this.Realty = realty;
            this.InterestedPeople = new List<Interested>();
        }

        public InmuebleViewModel() { }
    }
}
