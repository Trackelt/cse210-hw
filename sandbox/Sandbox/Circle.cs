
class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 0.0;
    }
    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}