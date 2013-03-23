namespace Domain
{
    using System.Collections.Generic;

    using Domain.Exceptions;

    /// <summary>
    /// The manager.
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public virtual int Age { get; set; }

        /// <summary>
        /// Gets or sets the realties.
        /// </summary>
        public virtual IList<Realty> Realties { get; set; }

        /// <summary>
        /// Only for NHibernate
        /// </summary>
        public Manager()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="age">
        /// The age.
        /// </param>
        public Manager(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Realties = new List<Realty>();
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="age">
        /// The age.
        /// </param>
        public virtual void Update(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <exception cref="ManagerHasRealtiesException">
        /// Throws an exception if the manager has assigned realties
        /// </exception>
        public virtual void Delete()
        {
            if (this.Realties.Count > 0)
            {
                throw new ManagerHasRealtiesException();
            }
        }
    }
}
