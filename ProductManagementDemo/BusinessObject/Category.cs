﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public partial class Category
    {
        public Category() => Products = new HashSet<Product>();

        public Category(int catId, string catName)
        {
            this.CategoryId = catId;
            this.CategoryName = catName;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
