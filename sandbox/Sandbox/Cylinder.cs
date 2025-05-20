
class Cylinder
{
    private Circle _circle;
    private double _height;

    public Cylinder()
    {
        _height = 0;
        _circle = null;
    }
    public Cylinder(Circle circle)
    {
        _circle = circle;
        _height = 0.0;
    }
    public Cylinder(double height)
    {
        _height = height;
        _circle = null;
    }
    public Cylinder(double height, Circle circle)
    {
        _circle = circle;
        _height = height;
    }
    public void SetCircle(Circle circle)
    {
        _circle = circle;
        SetHeight(10);
    }
    public void SetHeight(double height)
    {

        _height = height;
    }
    public double GetVolume()
    {
        return _circle.GetArea() * _height;
        //double radius = _circle.GetRadius();
        //return Math.PI * radius * radius * _height;
    }
}