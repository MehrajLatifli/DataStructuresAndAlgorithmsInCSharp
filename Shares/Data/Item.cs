﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class Item : IItem, IComparable<Item>
    {
        public Item()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}  ";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Item other = (Item)obj;
            return Id == other.Id && string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ (Name ?? "").GetHashCode(StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(Item? other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}