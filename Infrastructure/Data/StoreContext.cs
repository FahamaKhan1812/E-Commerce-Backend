﻿using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Data;
public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Products> Products { get; set; }
}
