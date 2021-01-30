using System;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migrating started at {DateTime.Now}");

            // Details of migrating the database

            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
        }
    }
}
