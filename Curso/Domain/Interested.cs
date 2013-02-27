namespace Domain
{
    using System.Collections.Generic;

    /// <summary>
    /// The interested.
    /// </summary>
    public class Interested
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the phone.
        /// </summary>
        public string Phone { get; private set; }

        /// <summary>
        /// Gets the homes.
        /// </summary>
        public List<Home> Homes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interested"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="phone">
        /// The phone.
        /// </param>
        public Interested(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
            this.Homes = new List<Home>();
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="phone">
        /// The phone.
        /// </param>
        public void Update(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        public void Delete()
        {
            foreach (var home in this.Homes)
            {
                home.InterestedPeople.Remove(this);
            }
        }
    }
}
