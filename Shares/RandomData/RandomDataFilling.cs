using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomData
{
    public static class RandomDataFilling
    {


        public static async Task< List<Item>> GenerateItems()
        {
            List<Item> items = new List<Item>();
            List<int> list = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(10, 100001);
                list.Add(randomNumber);
            }

            foreach (var item in list)
            {
                if (list.Contains(item))
                {
                    items.Add(new Item { Id = item, Name = $"Name_{Guid.NewGuid()}" });
                }
            }

            return items;
        }
    }
}
