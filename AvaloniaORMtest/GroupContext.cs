using System;
using AvaloniaORMtest.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaORMtest;

public class GroupContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Group> Groups { get; set; }

    public string DbPath { get; }

    public GroupContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "groupContext.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     // modelBuilder.Entity<User>
    // }
}