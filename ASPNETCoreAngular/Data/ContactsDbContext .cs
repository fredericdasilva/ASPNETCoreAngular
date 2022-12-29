using ASPNETCoreAngular.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreAngular.Data
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options)
        { }
    }
}
