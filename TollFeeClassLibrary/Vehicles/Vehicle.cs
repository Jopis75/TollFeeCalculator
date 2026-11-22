using TollFeeClassLibrary.Interfaces;

namespace TollFeeClassLibrary.Vehicles;

public abstract class Vehicle : IVehicle
{
    public abstract string GetVehicleType();

    public abstract bool IsTollFree();
}
