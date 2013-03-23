﻿namespace Domain
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
        public virtual Realty Realty { get; private set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public virtual string Address { get; private set; }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public virtual string Details { get; private set; }

        /// <summary>
        /// Gets the interested people.
        /// </summary>
        public virtual IList<Interested> InterestedPeople { get; private set; }

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
                this.RemoveInterested(interested); // Desvinculo la casa del interesado
            }

            this.Realty.Homes.Remove(this);
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="interested">
        /// The interested.
        /// </param>
        public void AddInterested(Interested interested)
        {
            // TODO: Completar
        }

        /// <summary>
        /// The remove interested.
        /// </summary>
        /// <param name="interested">
        /// The interested.
        /// </param>
        public void RemoveInterested(Interested interested)
        {
            // TODO: Completar
        }

        /// <summary>
        /// The assign.
        /// </summary>
        /// <param name="realty">
        /// The realty.
        /// </param>
        private void Assign(Realty realty)
        {
            this.Realty = realty;
            realty.Homes.Add(this);
        }
    }
}
