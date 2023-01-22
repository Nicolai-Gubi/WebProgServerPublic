﻿using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Models
{
    public class ItemDbContext: DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
    }
}
