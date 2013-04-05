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
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public virtual string Address { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public virtual string Details { get; set; }

        /// <summary>
        /// Gets or sets the manager.
        /// </summary>
        public virtual Manager Manager { get; set; }

        public virtual int Manager_Id { get; set; }

        /// <summary>
        /// Gets or sets the homes.
        /// </summary>
        public virtual IList<Home> Homes { get; set; }

        /// <summary>
        /// Only for NHibernate
        /// </summary>
        public Realty()
        {
        }

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
        public Realty(int id, string name, string address, string details, Manager manager)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Details = details;
            if (this.Id != 0)
            {
                this.Hire(manager);
            }
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
        public virtual void Update(string name, string address, string details, Manager newManager)
        {
            this.Name = name;
            this.Address = address;
            this.Details = details;
            this.Fire();
            this.Hire(newManager);
        }        

        /// <summary>
        /// The delete.
        /// </summary>
        public virtual void Delete()
        {
            this.Fire();
            if (this.Homes != null)
            {
                foreach (var home in this.Homes)
                {
                    home.Delete();
                }
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
            if (this.Id!=0)
            {
                this.Manager = manager;
                
                //this.Manager.Realties.Add(this);
            }
        }

        /// <summary>
        /// The fire.
        /// </summary>
        private void Fire()
        {
            if (this.Manager != null)
            {
                this.Manager.Realties.Remove(this); // Sacamos al viejo manager
            }
        }
    }
}
