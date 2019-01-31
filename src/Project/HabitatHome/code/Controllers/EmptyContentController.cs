using System;
using System.Web.Mvc;

namespace Sitecore.HeroHelixPOC.Website.Controllers
{
    public class EmptyContentController : Controller
    {
        public ActionResult Render()
        {
            return new EmptyResult();
        }
    }
}