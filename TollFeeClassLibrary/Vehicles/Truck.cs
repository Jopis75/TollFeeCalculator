using TollFeeClassLibrary.Enums;

namespace TollFeeClassLibrary.Vehicles;

public class Truck : Vehicle
{
    public override string GetVehicleType()
    {
        return ToString();
    }

    public override bool IsTollFree() => false;

    public override string ToString()
    {
        return VehicleType.Truck.ToString();
    }
}
