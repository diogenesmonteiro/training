using System.ComponentModel.DataAnnotations;

namespace Mooda.Domain.Configurations
{
    public class DbConnectionStrings
    {
        public const string ConnectionStringName = "MAIN";

        public string DbConnectionString { get; private set; }

        public DbConnectionStrings() { }

        public void SetProperties(string launchDbApiConnectionString)
            => DbConnectionString = launchDbApiConnectionString;
    }
}
