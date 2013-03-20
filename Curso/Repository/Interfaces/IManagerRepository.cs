namespace Repository.Interfaces
{
    using System.Collections.Generic;

    using Domain;

    /// <summary>
    /// The ManagerRepository interface.
    /// </summary>
    public interface IManagerRepository : IRepository<Manager>
    {
        /*/// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The Domain.Manager.
        /// </returns>
        Manager Get(int id);

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        void Add(Manager manager);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        void Delete(Manager manager);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The System.Collections.Generic.List`1[T -&gt; Domain.Manager].
        /// </returns>
        List<Manager> GetAll();*/
    }
}