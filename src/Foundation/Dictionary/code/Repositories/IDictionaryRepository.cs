using Sitecore.HeroHelixPOC.Foundation.Dictionary.Models;
using Sitecore.Sites;

namespace Sitecore.HeroHelixPOC.Foundation.Dictionary.Repositories
{
  public interface IDictionaryRepository
  {
    Models.Dictionary Get(SiteContext site);
  }
}