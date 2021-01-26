using System;
using Day5Homework.Abstract;
using Day5Homework.Entity;

namespace Day5Homework.Concrete
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
