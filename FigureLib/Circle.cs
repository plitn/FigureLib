namespace FigureLib;

public class Circle : IFigure
{
    private  double Radius { get; set; }

    /// <summary>
    /// Конструктор Круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <exception cref="ArgumentException">Выбрасываем при отрицательном радиусе круга</exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Отрицательный радиус круга");
        }

        Radius = radius;
    }
    
    /// <summary>
    /// Метод для рассчета площади круга по стандартной формуле
    /// </summary>
    /// <returns>Площадь круга</returns>
    public double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2d);
    }
}