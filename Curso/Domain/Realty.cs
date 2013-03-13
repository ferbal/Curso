namespace Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The realty.
    /// </summary>
    public class Realty
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public string Details { get; private set; }

        /// <summary>
        /// Gets the manager.
        /// </summary>
        public Manager Manager { get; private set; }

        /// <summary>
        /// Gets the homes.
        /// </summary>
        public List<Home> Homes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Realty"/> class.
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
        public Realty(string address, string details, Manager manager)
        {
            this.Address = address;
            this.Details = details;
            this.Hire(manager);
            this.Homes = new List<Home>();
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
        /// <param name="newManager">
        /// The new manager.
        /// </param>
        public void Update(string address, string details, Manager newManager)
        {
            this.Address = address;
            this.Details = details;
            this.Fire();
            this.Hire(newManager);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        public void Delete()
        {
            this.Manager.Realties.Remove(this);
            foreach (var home in this.Homes)
            {
                home.Delete();
            }
        }

        /// <summary>
        /// The hire.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        private void Hire(Manager manager)
        {
            this.Manager = manager;
            this.Manager.Realties.Add(this);
        }

        /// <summary>
        /// The fire.
        /// </summary>
        private void Fire()
        {
            this.Manager.Realties.Remove(this); // Sacamos al viejo manager
        }
    }
}
