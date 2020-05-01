using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace BankApp
{
    class BankContext : DbContext // inheriting from database contex its a special class
    {
        public DbSet<Account> Accounts { get; set; } // creating a Account table. set is another name of table 
        public DbSet<Transaction> Transactions { get; set; } // creating Transaction Table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // database getting configuring we will tell where to store data change parent behaviour (override)
        {

           optionsBuilder.UseSqlServer(@"Data Source =localhost; User Id=sa; Password=Sami1499!; Initial Catalog=BankAPR20; Integrated Security=False;");
          
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)// model is another name of table
        {
            // tell the database how to create table .Entity is another name of table. tell the rules how to create table
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Accounts");//define name of table Accounts
                entity.HasKey(a => a.AccountNumber);// make AccountNumber is primary key
            entity.Property(a => a.AccountNumber).ValueGeneratedOnAdd();//when there is new Account it will automaticly generate increased the number and generate new number
            entity.Property(a => a.EmailAdress).IsRequired().HasMaxLength(100);// make email nut nullable and length max 100
            entity.Property(a => a.AccountName).IsRequired().HasMaxLength(250);
            entity.Property(a => a.AccountType).IsRequired();
            }

            );
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transactions");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
                entity.Property(t => t.Amount).IsRequired();
            }


            );
        }
    }
}
