using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    public class CampaignManager:IBaseService<Campaign>
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " eklendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " güncellendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " silindi");
        }
    }
}
