namespace Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The home.
    /// </summary>
    public class Home
    {
        /// <summary>
        /// Gets the realty.
        /// </summary>
        public Realty Realty { get; private set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public string Details { get; private set; }

        /// <summary>
        /// Gets the interested people.
        /// </summary>
        public List<Interested> InterestedPeople { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        /// <param name="realty">
        /// The realty.
        /// </param>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="details">
        /// The details.
        /// </param>
        public Home(Realty realty, string address, string details)
        {
            this.Realty = realty;
            realty.Homes.Add(this);

            this.Address = address;
            this.Details = details;
            this.InterestedPeople = new List<Interested>();
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="details">
        /// The details.
        /// </param>
        public void Update(string address, string details)
        {
            this.Address = address;
            this.Details = details;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        public void Delete()
        {
            foreach (var interested in this.InterestedPeople)
            {
                interested.Homes.Remove(this); // Desvinculo la casa del interesado
            }
        }
    }
}
