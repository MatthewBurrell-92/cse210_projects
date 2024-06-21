using System;

public class Square : Shape
{
private float _side;

public Square(string color, float side) : base(color)
{
    _color = color;
    _side = side;
}
public override float GetArea()
{
    float area = _side * _side;
    return area;
}
}