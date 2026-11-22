using TollFee.ClassLibrary.Interfaces;

namespace TollFee.ClassLibrary.Vehicles;

public abstract class Vehicle : IVehicle
{
    public abstract string GetVehicleType();

    public abstract bool IsTollFree();
}
