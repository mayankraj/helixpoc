﻿using Sitecore.Analytics;   
using System.Web.Mvc;

namespace Sitecore.HeroHelixPOC.Foundation.SitecoreExtensions.Attributes
{
    public class SkipAnalyticsTrackingAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest() && Tracker.IsActive)
            {
                Tracker.Current?.CurrentPage?.Cancel();
            }
        }
    }
}