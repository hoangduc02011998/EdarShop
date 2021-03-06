﻿
using System.Data.Entity;

using EdarShop.Model.Models;

namespace EdarShop.Data
{
    public class EdarShopDbContext:DbContext
    {
        public EdarShopDbContext() : base("EdarShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistics> VisitorStatisticses { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
