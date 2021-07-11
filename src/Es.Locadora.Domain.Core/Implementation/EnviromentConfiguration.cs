using Es.Locadora.Domain.Core.Interfaces;
using System;

namespace Es.Locadora.Domain.Core.Implementation
{
    public class EnviromentConfiguration : IEnviromentConfiguration
    {
        public string Secret => Environment.GetEnvironmentVariable("SECRET");

        public string ConnectionString => Environment.GetEnvironmentVariable("CONNECTION_STRING");
    }
}
