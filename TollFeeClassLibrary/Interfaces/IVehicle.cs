namespace TollFeeClassLibrary.Interfaces;

public interface IVehicle
{
    string GetVehicleType();

    bool IsTollFree();
}
