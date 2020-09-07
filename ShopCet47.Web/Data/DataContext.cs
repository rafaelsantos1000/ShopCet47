using Microsoft.EntityFrameworkCore;
using ShopCet47.Web.Data.Entities;

namespace ShopCet47.Web.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Product> Products { get; set; }


    }
}
