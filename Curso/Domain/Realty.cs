namespace Domain
{
    /// <summary>
    /// The realty.
    /// </summary>
    public class Realty
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
        /// Gets the manager.
        /// </summary>
        public Manager Manager { get; private set; }

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
            this.Manager = manager;
            this.Manager.Realties.Add(this);
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

            this.Manager.Realties.Remove(this); // Sacamos al viejo manager

            this.Manager = newManager;
            this.Manager.Realties.Add(this);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        public void Delete()
        {
            this.Manager.Realties.Remove(this);
        }

        // TIP: el codigo de Update se parece bastante al del constructor, con cosas de Delete. ¿Podemos hacer algo?
    }
}
