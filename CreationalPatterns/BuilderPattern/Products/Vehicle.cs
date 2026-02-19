
using BuilderPattern.Enums;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Products;

public class Vehicle
{
    public string Name { get; set; } = "Spaceship";
    public float Width { get; set; }
    public float Depth { get; set; }
    public float Height { get; set; }
    public float Speed { get; set; }
    public string Color { get; set; } = "Not painted";
    public bool LightSpeed { get; set; } = false;
    public MovementTypeEnum MovementType { get; set; }
}