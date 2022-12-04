﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ShoseEmporium.Models;

namespace ShoseEmporium.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ShoseEmporium.Models.Shose> Shose { get; set; }
        public DbSet<ShoseEmporium.Models.Vendor> Vendors { get; set; }


    }
}
