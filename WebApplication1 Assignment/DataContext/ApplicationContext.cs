using Microsoft.EntityFrameworkCore;
using WebApplication1_Assignment.Model;

namespace WebApplication1_Assignment.DataContext
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        { 

        }
        public DbSet<TaskList> taskLists { get; set; }
    }
}
