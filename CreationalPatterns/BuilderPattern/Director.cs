using BuilderPattern.Interfaces;
using BuilderPattern.Enums;

namespace BuilderPattern;

public class Director
{
    private IBuilder? _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMilleniumFalcon()
    {
        _builder?.SetName("Millenium Falcon");
        _builder?.SetColor("Grey");
        _builder?.SetWidth(30f);
        _builder?.SetHeight(80f);
        _builder?.SetDepth(5f);
        _builder?.SetLightSpeed();
        _builder?.SetSpeed(1000f);
        _builder?.SetMovementType(MovementTypeEnum.Air);
    }

    public void BuildTIEFighter()
    {
        _builder?.SetName("TIE Fighter");
        _builder?.SetColor("Grey and black");
        _builder?.SetWidth(10f);
        _builder?.SetHeight(10f);
        _builder?.SetDepth(10f);
        _builder?.SetSpeed(800f);
        _builder?.SetMovementType(MovementTypeEnum.Air);
    }

    public void BuildARTT()
    {
        _builder?.SetName("AR-TT");
        _builder?.SetColor("Grey");
        _builder?.SetWidth(2f);
        _builder?.SetHeight(5f);
        _builder?.SetDepth(2f);
        _builder?.SetSpeed(10f);
        _builder?.SetMovementType(MovementTypeEnum.Ground);
    }
}
