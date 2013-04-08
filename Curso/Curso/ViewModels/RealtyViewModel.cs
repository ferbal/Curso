namespace Curso.ViewModels
{
    using System.Collections.Generic;
    using Domain;

    public class RealtyViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Details { get; set; }

        public Manager Manager {get; set;}

        public IList<Home> Homes { get; set; }

        public RealtyViewModel(int id, string name, string address, string details, Manager manager)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Details = details;
            this.Manager = manager;            
            this.Homes = new List<Home>();
        }

        public RealtyViewModel() { }
    }
}
