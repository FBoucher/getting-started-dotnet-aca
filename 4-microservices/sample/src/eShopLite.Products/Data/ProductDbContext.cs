﻿using eShopLite.DataEntities;

using Microsoft.EntityFrameworkCore;

namespace eShopLite.Products.Data;

public class ProductDbContext : DbContext
{
    public ProductDbContext (DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Product { get; set; } = default!;
}
