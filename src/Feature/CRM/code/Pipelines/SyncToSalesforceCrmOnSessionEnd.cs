﻿using Sitecore.Pipelines.SessionEnd;

namespace Sitecore.HeroHelixPOC.Feature.CRM.Pipelines
{
    public class SyncToSalesforceCrmOnSessionEnd
    {
        public void Process(SessionEndArgs args)
        {
            var syncToSalesforceCrm = new TriggerDefPipelineBatch.SyncToSalesforceCrm();
            syncToSalesforceCrm.Sync();
        }
    }
}