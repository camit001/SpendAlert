using Microsoft.EntityFrameworkCore;

namespace SpendAlert.Models
{
    public class SpendAlertDbContext :DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendAlertDbContext(DbContextOptions<SpendAlertDbContext> options)
            :base(options)  
        {
            
        }
    }
}
