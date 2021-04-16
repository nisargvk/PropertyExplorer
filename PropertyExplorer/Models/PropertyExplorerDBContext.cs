using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public class PropertyExplorerDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
 
        public PropertyExplorerDBContext(DbContextOptions<PropertyExplorerDBContext> options) : base(options) { }
        public Microsoft.EntityFrameworkCore.DbSet<User> user { get; set; }
        
    }
}
