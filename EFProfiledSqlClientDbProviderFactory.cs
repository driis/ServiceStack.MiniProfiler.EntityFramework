using System.Data.SqlClient;

namespace ServiceStack.MiniProfiler.EntityFramework
{
    /// <summary>
    /// Specific implementation of EFProfiledDbProviderFactory&lt;SqlClientFactory&gt; to enable profiling
    /// </summary>
    public class EFProfiledSqlClientDbProviderFactory
        : EFProfiledDbProviderFactory<SqlClientFactory>
    {
        private EFProfiledSqlClientDbProviderFactory()
        { }

        /// <summary>
        /// Every provider factory must have an Instance public field
        /// </summary>
        public static new EFProfiledSqlClientDbProviderFactory Instance = new EFProfiledSqlClientDbProviderFactory();

    }
}
