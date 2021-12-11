using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_app_asp_net_mvc_export_excel.Models
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopContext() : base("ShopEntity")
        { }
    }
}