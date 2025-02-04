﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavVideos.Models
{
    public class FavVideosContext : DbContext
    {
        public FavVideosContext() { }
        public FavVideosContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FavVideo> FavVideosTable { get; set; }
    }
}
