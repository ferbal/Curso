namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Repository.Interfaces;

    /// <summary>
    /// The manager service.
    /// </summary>
    public class ManagerService : IManagerService
    {
        /// <summary>
        /// The manager repository.
        /// </summary>
        private readonly IManagerRepository managerRepository;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerService"/> class.
        /// </summary>
        /// <param name="managerRepository">
        /// The manager repository.
        /// </param>
        public ManagerService(IManagerRepository managerRepository)
        {
            this.managerRepository = managerRepository;
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The System.Collections.Generic.List`1[T -&gt; Domain.Manager].
        /// </returns>
        public List<Manager> GetAll()
        {
            return this.managerRepository.GetAll();
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The Domain.Manager.
        /// </returns>
        public Manager Get(int id)
        {
            return this.managerRepository.Get(id);
        }

        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="age">
        /// The age.
        /// </param>
        public void Create(string name, int age) // TIP: Que pasaria si en vez de 2 parametros, el manager tuviera 100???
        {
            var manager = new Manager(name, age);
            this.managerRepository.Add(manager);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="age">
        /// The age.
        /// </param>
        public void Update(int id, string name, int age)
        {
            var manager = this.managerRepository.Get(id);
            manager.Update(name, age);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public void Delete(int id)
        {
            var manager = this.managerRepository.Get(id);
            manager.Delete();
            this.managerRepository.Delete(manager);
        }
    }
}
