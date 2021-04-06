using Microsoft.EntityFrameworkCore;
using Swagger_API.Models;
using Swagger_API.Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options) { }

        public DbSet<BatchAclReadGroupsTable> BatchAclReadGroupsTables { get; set; }
        public DbSet<BatchAclReadUsersTable> BatchAclReadUsersTables { get; set; }
        public DbSet<BatchAclTable> BatchAclTables { get; set; }
        public DbSet<BatchAttributeTable> BatchAttributeTables { get; set; }
        public DbSet<BatchTable> BatchTables { get; set; }
        public DbSet<BatchBusinessUnitTable> BatchBusinessUnitTables { get; set; }
    }
}
