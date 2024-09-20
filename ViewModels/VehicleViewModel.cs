namespace WestCoast_Cars.ViewModels;

public class VehicleViewModel
{
    public int Id { get; set; }
    public string RegNo { get; set; } = "";
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public int ModelYear { get; set; }
    public int? Milage { get; set; }
    public string? Comment { get; set; }
}
