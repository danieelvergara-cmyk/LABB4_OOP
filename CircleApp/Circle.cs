class Circle
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
