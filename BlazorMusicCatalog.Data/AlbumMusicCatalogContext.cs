﻿using BlazorMusicCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Data
{
    public class AlbumMusicCatalogContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=DESARROLLO;Initial Catalog=AlbumMusicCatalog;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}