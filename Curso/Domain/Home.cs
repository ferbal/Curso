namespace Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The home.
    /// </summary>
    public class Home
    {
        public virtual int Id { get; set; }
        /// <summary>
        /// Gets the realty.
        /// </summary>
        public virtual Realty Realty { get; set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public virtual string Details { get; set; }

        /// <summary>
        /// Gets the interested people.
        /// </summary>
        public virtual IList<Interested> InterestedPeople { get; set; }

        public Home()
        {
        }

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
        public Home(int id, string address, string details, Realty realty)
        {
            this.Id = id;
            this.Assign(realty);
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
        public virtual void Update(string address, string details, Realty realty)
        {
            this.Address = address;
            this.Details = details;
            this.Assign(realty);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        public virtual void Delete()
        {
            if (this.InterestedPeople != null)
            {
                foreach (var interested in this.InterestedPeople)
                {
                    this.RemoveInterested(interested); // Desvinculo la casa del interesado
                }
            }
            if (this.Realty != null)
            {
                this.Realty.Homes.Remove(this);
            }
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="interested">
        /// The interested.
        /// </param>
        public virtual void AddInterested(Interested interested)
        {
            this.InterestedPeople.Add(interested);
        }

        /// <summary>
        /// The remove interested.
        /// </summary>
        /// <param name="interested">
        /// The interested.
        /// </param>
        public virtual void RemoveInterested(Interested interested)
        {
            // TODO: Completar
        }

        /// <summary>
        /// The assign.
        /// </summary>
        /// <param name="realty">
        /// The realty.
        /// </param>
        public virtual void Assign(Realty realty)
        {
            this.Realty = realty;
            //realty.Homes.Add(this);
        }
    }
}
