﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomData
{
    public static class RandomDataFilling
    {


        public static List<Item> GenerateItems()
        {
            List<Item> items = new List<Item>();
            List<int> list = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(1, 10000);
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