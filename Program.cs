using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LAB7.Models.Entities;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new MMABooksContext())
        {
            // Retrieve customers from the database
            var customers = context.Customers.ToList();

            // Print the names of customers
            Console.WriteLine("List of Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}

public class MMABooksContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // connection string 
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vorti\Downloads\MMABooks.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
    }
}



public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    
}