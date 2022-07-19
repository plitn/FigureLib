namespace FigureLib;

public class Circle : IFigure
{
    public  double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Отрицательный радиус круга");
        }

        Radius = radius;
    }
    public double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2d);
    }
}