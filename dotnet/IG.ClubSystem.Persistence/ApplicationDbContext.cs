﻿using Microsoft.EntityFrameworkCore;

namespace IG.ClubSystem.Persistence;

public class ApplicationDbContext(DbContextOptions options): DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
