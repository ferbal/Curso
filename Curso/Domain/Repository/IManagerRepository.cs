namespace Domain.Repository
{
    using System.Collections.Generic;

    /// <summary>
    /// The ManagerRepository interface.
    /// </summary>
    public interface IManagerRepository
    {
        /// <summary>
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
        /// <param name="id">
        /// The id.
        /// </param>
        void Delete(int id);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The System.Collections.Generic.List`1[T -&gt; Domain.Manager].
        /// </returns>
        List<Manager> GetAll();
    }
}