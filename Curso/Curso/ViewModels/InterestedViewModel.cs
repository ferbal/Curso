namespace Curso.ViewModels
{
    using System.Collections.Generic;
    using Domain;

    public class InterestedViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public IList<Home> Homes { get; set; }

        public InterestedViewModel(int id, string name, string phone, IList<Home> homes)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Homes = homes;
        }

        public InterestedViewModel() { }
    }
}
