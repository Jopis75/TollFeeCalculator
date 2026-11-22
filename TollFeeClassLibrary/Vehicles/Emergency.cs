using TollFeeClassLibrary.Enums;

namespace TollFeeClassLibrary.Vehicles;

public class Emergency : Vehicle
{
    public override string GetVehicleType()
    {
        return ToString();
    }

    public override bool IsTollFree() => true;

    public override string ToString()
    {
        return VehicleType.Emergency.ToString();
    }
}
