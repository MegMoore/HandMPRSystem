﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandMPRSystem.Models;

namespace HandMPRSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<HandMPRSystem.Models.Client> Clients { get; set; } = default!;

        public DbSet<HandMPRSystem.Models.Order> Orders { get; set; } = default!;

        public DbSet<HandMPRSystem.Models.Product> Products { get; set; } = default!;

        public DbSet<HandMPRSystem.Models.Pantograph> Pantographs { get; set; } = default!;

        public DbSet<HandMPRSystem.Models.Orderline> Orderlines { get; set; } = default!;

        public DbSet<HandMPRSystem.Models.Quilt> Quilts { get; set; } = default!;
    }
}
