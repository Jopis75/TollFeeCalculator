using TollFee.ClassLibrary.Enums;

namespace TollFee.ClassLibrary.Vehicles;

public class Motorbike : Vehicle
{
    public override string GetVehicleType()
    {
        return ToString();
    }

    public override bool IsTollFree() => true;

    public override string ToString()
    {
        return VehicleType.Motorbike.ToString();
    }
}