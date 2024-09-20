using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.Data;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Models;

public class VehicleModel
{
    private readonly WestcoastCarsContext _context;
    // constructors
    public VehicleModel(WestcoastCarsContext context){
        _context = context;
    }
    public async Task<List<VehicleViewModel>> GetVehicles(){
        //hämta data någonstans ifrån
        var list = await _context.Vehicles.ToListAsync();
        return list;
    }
    public VehicleViewModel Find(int id){
        return new VehicleViewModel {Id=2, RegNo="DEF456", Make="Ford", Model="Mustang", ModelYear=2020};
    }
}
