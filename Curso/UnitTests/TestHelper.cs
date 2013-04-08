
namespace UnitTests
{
    using Domain;

    /// <summary>
    /// This class provides methods to help the test building
    /// </summary>
    public static class TestHelper
    {
        /// <summary>
        /// Creates a base Realty
        /// </summary>
        /// <returns>The Realty</returns>
        public static Realty GetBaseRealty()
        {
            return new Realty(2,"address", "details", "GetBaseManager()",null);
        }

        /// <summary>
        /// Creates a base Manager
        /// </summary>
        /// <returns>The Manager</returns>
        public static Manager GetBaseManager()
        {
            return new Manager("name", 50);
        }
    }
}
