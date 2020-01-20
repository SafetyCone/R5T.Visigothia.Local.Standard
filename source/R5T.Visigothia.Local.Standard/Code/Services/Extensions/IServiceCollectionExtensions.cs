using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Visigothia.Local.Default;


namespace R5T.Visigothia.Local.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EnvironmentBasedUserProfileDirectoryPathProvider"/> implementation of the <see cref="IUserProfileDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddLocalUserProfileDirectoryProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, EnvironmentBasedUserProfileDirectoryPathProvider>();

            return services;
        }
    }
}
