namespace Services
{
    using System.Collections.Generic;

    using Domain;
    using Domain.Repository;

    /// <summary>
    /// The manager service.
    /// </summary>
    public class ManagerService
    {
        /// <summary>
        /// The manager repository.
        /// </summary>
        private ManagerRepository managerRepository = new ManagerRepository();

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

        public Manager Get(int id)
        {
            return this.managerRepository.Get(id);
        }

        public void Create(string name, int age) // TIP: Que pasaria si en vez de 2 parametros, el manager tuviera 100???
        {
            var manager = new Manager(name, age);
            managerRepository.Add(manager);
        }

        public void Update(int id, string name, int age)
        {
            var manager = managerRepository.Get(id);
            manager.Update(name, age);
        }
    }
}
