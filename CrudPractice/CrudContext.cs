﻿using Microsoft.EntityFrameworkCore;

namespace CrudPractice;

public class CrudContext : DbContext
{
  

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       base.OnConfiguring(optionsBuilder);
       optionsBuilder.UseSqlServer(ConnectionString);
   }

   private const string ConnectionString = "Server=localhost;Database=crud;Trusted_Connection=True;";
   
    public DbSet<User>? Users { get; set; }
}

public class User
{
    public User(Guid Id, string Name, string Email, string Password)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        this.Password = Password;
    }

    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }

    public void Deconstruct(out Guid Id, out string Name, out string Email, out string Password)
    {
        Id = this.Id;
        Name = this.Name;
        Email = this.Email;
        Password = this.Password;
    }
}