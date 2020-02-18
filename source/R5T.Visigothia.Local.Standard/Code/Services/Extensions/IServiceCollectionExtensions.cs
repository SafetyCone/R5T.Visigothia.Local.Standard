using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Visigothia.Local.Default;


namespace R5T.Visigothia.Local.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a local <see cref="IUserProfileDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddLocalUserProfileDirectoryProvider(this IServiceCollection services)
        {
            services.AddEnvironmentBasedUserProfileDirectoryPathProvider();

            return services;
        }

        /// <summary>
        /// Adds a local <see cref="IUserProfileDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IUserProfileDirectoryPathProvider> AddLocalUserProfileDirectoryProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IUserProfileDirectoryPathProvider>(() => services.AddLocalUserProfileDirectoryProvider());
            return serviceAction;
        }
    }
}
