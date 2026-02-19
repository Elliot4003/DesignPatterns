
using BuilderPattern.Enums;

namespace BuilderPattern.Interfaces;

public interface IBuilder
{
    void Reset();
    void SetName(string name);
    void SetWidth(float width);
    void SetDepth(float depth);
    void SetHeight(float height);
    void SetSpeed(float speed);
    void SetColor(string color);
    void SetLightSpeed();
    void SetMovementType(MovementTypeEnum movementType);
}

