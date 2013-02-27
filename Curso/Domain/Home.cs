namespace Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The home.
    /// </summary>
    public class Home
    {
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
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="details">
        /// The details.
        /// </param>
        public Home(string address, string details)
        {
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
        /// <param name="manager">
        /// The manager.
        /// </param>
        public void Update(string address, string details, Manager manager)
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
