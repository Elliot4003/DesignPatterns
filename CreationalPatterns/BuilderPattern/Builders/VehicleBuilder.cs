using BuilderPattern.Enums;
using BuilderPattern.Interfaces;
using BuilderPattern.Products;

namespace BuilderPattern.Builders;

public class VehicleBuilder : IBuilder
{
    private Vehicle _product = new Vehicle();

    public void Reset()
    {
        _product = new Vehicle();
    }

    public void SetMovementType(MovementTypeEnum movementType)
    {
        _product.MovementType = movementType;
    }

    public void SetColor(string color)
    {
        _product.Color = color;
    }

    public void SetDepth(float depth)
    {
        _product.Depth = depth;
    }

    public void SetHeight(float height)
    {
        _product.Height = height;
    }

    public void SetLightSpeed()
    {
        _product.LightSpeed = true;
    }

    public void SetName(string name)
    {
        _product.Name = name;
    }

    public void SetSpeed(float speed)
    {
        _product.Speed = speed;
    }

    public void SetWidth(float width)
    {
        _product.Width = width;
    }

    public Vehicle GetVehicle()
    {
        var product = _product;
        Reset();
        return product;
    }
}