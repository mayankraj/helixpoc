namespace Sitecore.HeroHelixPOC.Foundation.DependencyInjection.Infrastructure
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;

    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("Sitecore.HeroHelixPOC.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Sitecore.HeroHelixPOC.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Sitecore.HeroHelixPOC.Foundation.*");
        }
    }
}