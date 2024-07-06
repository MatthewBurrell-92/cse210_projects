using System;

public class Rectangle : Shape
{
    private float _longSide;
    private float _shortSide;

    public Rectangle(string color, float longSide, float shortSide) : base(color)
    {
        _color = color;
        _longSide = longSide;
        _shortSide = shortSide;
    }
    public override float GetArea()
    {
        float area = _longSide * _shortSide;
        return area;
    }
}