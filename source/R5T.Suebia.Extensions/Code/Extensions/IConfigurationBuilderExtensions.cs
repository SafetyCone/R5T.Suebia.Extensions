using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace R5T.Suebia.Extensions
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddJsonSecretsFilePath(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider, string fileName)
        {
            var secretsFilePathProvider = configurationServiceProvider.GetRequiredService<ISecretsFilePathProvider>();

            var filePath = secretsFilePathProvider.GetSecretsFilePath(fileName);

            configurationBuilder.AddJsonFile(filePath);

            return configurationBuilder;
        }
    }
}
