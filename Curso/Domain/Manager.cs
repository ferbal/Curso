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
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the age.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Gets the realties.
        /// </summary>
        public List<Realty> Realties { get; private set; }

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
        public void Update(string name, int age)
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
        public void Delete()
        {
            if (this.Realties.Count > 0)
            {
                throw new ManagerHasRealtiesException();
            }
        }
    }
}
