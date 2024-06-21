using System;

public class Circle : Shape
{
private float _radius;

public Circle(string color, float radius) : base(color)
{
    _color = color;
    _radius = radius;
}
public override float GetArea()
{
    float area = (float)(3.14 * _radius * _radius);
    return area;
}
}