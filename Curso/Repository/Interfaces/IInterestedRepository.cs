namespace Repository.Interfaces
{
    using Domain;

    /// <summary>
    /// The InterestedRepository interface.
    /// </summary>
    public interface IInterestedRepository
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The Domain.Interested.
        /// </returns>
        Interested Get(int id);

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="interested">
        /// The interested.
        /// </param>
        void Add(Interested interested);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        void Delete(int id);
    }
}