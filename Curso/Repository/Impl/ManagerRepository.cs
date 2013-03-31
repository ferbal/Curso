namespace Repository.Impl
{
    using System.Collections.Generic;

    using Domain;
    using Domain.Exceptions;

    using Repository.Interfaces;

    /// <summary>
    /// The manager repository.
    /// </summary>
    public class ManagerRepository : BaseRepository<Manager>, IManagerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerRepository"/> class.
        /// </summary>
        /// <param name="hibernateSessionFactory">
        /// The hibernate session factory.
        /// </param>
        public ManagerRepository(HibernateSessionFactory hibernateSessionFactory) : base(hibernateSessionFactory)
        {   
        }

        /*
        /// <summary>
        /// The managers.
        /// </summary>
        private readonly List<Manager> managers = new List<Manager> { new Manager("Adriano Filgueira", 27), new Manager("Apolinario Figueroa", 25) };

        /// <summary>
        /// The id counter.
        /// </summary>
        private int idCounter = 1000;

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The Domain.Manager.
        /// </returns>
        /// <exception cref="ObjectNotFoundException"> If the manager is not found </exception>
        public Manager Get(int id)
        {
            foreach (var manager in this.managers)
            {
                if (manager.Id == id)
                {
                    return manager;
                }
            }

            throw new ObjectNotFoundException();
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        public void Add(Manager manager)
        {
            manager.Id = this.GetId();
            this.managers.Add(manager);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        public void Delete(Manager manager)
        {
            this.managers.Remove(manager);
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The System.Collections.Generic.List`1[T -&gt; Domain.Manager].
        /// </returns>
        public List<Manager> GetAll()
        {
            return this.managers;
        }

        /// <summary>
        /// The get id.
        /// </summary>
        /// <returns>
        /// The System.Int32.
        /// </returns>
        private int GetId()
        {
            this.idCounter++;
            return this.idCounter;
        }*/
    }
}
