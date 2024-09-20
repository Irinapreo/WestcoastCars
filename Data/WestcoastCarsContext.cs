using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Data;

public class WestcoastCarsContext : DbContext
{
    /*properties  */
    public DbSet<VehicleViewModel> Vehicles { get; set; }
    
    /*constructors  */
    
    public WestcoastCarsContext(DbContextOptions options) : base(options){}


}
