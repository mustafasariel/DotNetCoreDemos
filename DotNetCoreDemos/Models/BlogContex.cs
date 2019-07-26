using DotNetCoreDemos.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDemos.Models
{
    public class BlogContex : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public BlogContex(DbContextOptions<BlogContex> options):base(options)
        {

        }
    }
}