﻿using Sitecore.Configuration;

namespace Sitecore.HeroHelixPOC.Feature.CRM.ExperienceProfile.CustomApiController
{
    public class ExperienceProfileSalesforceCustomerIntelligenceManager
    {
        public static ExperienceProfileSalesforceXdbContactService ContactService
        {
            get
            {
                return Factory.CreateObject(FormatProviderPath("contactService"), true) as ExperienceProfileSalesforceXdbContactService;
            }
        }

        private static string FormatProviderPath(string providerName)
        {
            return string.Format("experienceProfile/providers/{0}", (object)providerName);
        }
    }
}