using TollFee.ClassLibrary.Enums;

namespace TollFee.ClassLibrary.Vehicles;

public class Car : Vehicle
{
    public override string GetVehicleType()
    {
        return ToString();
    }

    public override bool IsTollFree() => false;

    public override string ToString()
    {
        return VehicleType.Car.ToString();
    }
}
