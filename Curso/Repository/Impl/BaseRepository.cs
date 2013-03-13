namespace Repository.Impl
{
    using System.Collections.Generic;

    /// <summary>
    /// The base repository.
    /// </summary>
    /// <typeparam name="T">The domain class</typeparam>
    public abstract class BaseRepository<T> where T : class
    {
        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The T.
        /// </returns>
        public T Get(int id)
        {
            return (T)this.GetSessionFactory().GetSession().Get(typeof(T), id);
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The System.Collections.Generic.IList`1[T -&gt; T].
        /// </returns>
        public IList<T> GetAll()
        {
            return this.GetSessionFactory().GetSession().CreateCriteria(typeof(T)).List<T>();
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        public void Add(T o)
        {
            this.GetSessionFactory().GetSession().Save(o);
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        public void Remove(T o)
        {
            this.GetSessionFactory().GetSession().Delete(o);
        }

        /// <summary>
        /// The hibernate session factory.
        /// </summary>
        private IHibernateSessionFactory hibernateSessionFactory;

        /// <summary>
        /// The get session factory.
        /// </summary>
        /// <returns>
        /// The Repository.IHibernateSessionFactory.
        /// </returns>
        public IHibernateSessionFactory GetSessionFactory()
        {
            return this.hibernateSessionFactory;
        }

        /// <summary>
        /// The set session factory.
        /// </summary>
        /// <param name="nhibSessionFactory">
        /// The nhib session factory.
        /// </param>
        protected void SetSessionFactory(IHibernateSessionFactory nhibSessionFactory)
        {
            this.hibernateSessionFactory = nhibSessionFactory;
        }
    }
}
