using System;

namespace Day5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1- Oyuncu kayıt");
            Console.WriteLine("2- Oyuncu güncelle");
            Console.WriteLine("3- Oyuncu sil");
            Console.WriteLine("4- Oyun satın al");
            Console.WriteLine("5- Kampanya ekle");
            Console.WriteLine("6- Kampanya güncelle");
            Console.WriteLine("7- Kampanya sil");
            var selection = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "İsmail",
                Surname = "Gümüş",
                DateOfBirth = new DateTime(1984, 4, 9),
                NationalityId = "11122233344"
            };

            Product product = new Product()
            {
                Id = 2,
                ProductName = "BeeKeeper's World",
                Price = 99.99
            };

            Campaign campaign = new Campaign()
            {
                Id = 3,
                CampaignName = "Bahar Kampanyası",
                Discount = 49.99
            };

            IBaseService<Customer> customerManager = new CustomerManager();

            IProductService productManager = new ProductManager();

            IBaseService<Campaign> campaignManager = new CampaignManager();

            switch (selection)
            {
                case 1:
                    customerManager.Add(customer);
                    break;
                case 2:
                    customerManager.Update(customer);
                    break;
                case 3:
                    customerManager.Delete(customer);
                    break;
                case 4:
                    if (campaign.Discount > 0)
                    {
                        productManager.Sell(product, customer, campaign);
                    }
                    else
                    {
                        productManager.Sell(product, customer);
                    }
                    break;
                case 5:
                    campaignManager.Add(campaign);
                    break;
                case 6:
                    campaignManager.Update(campaign);
                    break;
                case 7:
                    campaignManager.Delete(campaign);
                    break;
            }
        }
    }
}
