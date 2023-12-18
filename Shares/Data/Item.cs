﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class Item : IItem
    {
        public Item()
        {
            
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name} ";
        }
    }
}
