﻿namespace FigureLib;

public class Triangle : IFigure
{
    public double ASide { get; }
    public double BSide { get; }
    public double CSide { get; }
    private double perimeter;

    /// <summary>
    /// Конструктор фигуры треугольник
    /// </summary>
    /// <param name="aSide">Сторона "A" треугольника</param>
    /// <param name="bSide">Сторона "B" треугольника</param>
    /// <param name="cSide">Сторона "C" треугольника</param>
    /// <exception cref="ArgumentException">
    /// Выбрасываем, если хотя бы одна из сторон отрицательна
    /// или же такого треугольника не может существовать
    /// </exception>
    public Triangle(double aSide, double bSide, double cSide)
    {
        if (aSide < 0)
        {
            throw new ArgumentException("Сторона меньше нуля", nameof(aSide));
        }

        if (bSide < 0)
        {
            throw new ArgumentException("Сторона меньше нуля", nameof(bSide));
        }

        if (cSide < 0)
        {
            throw new ArgumentException("Сторона меньше нуля", nameof(cSide));
        }
        
        if (!(aSide + bSide > cSide && bSide + cSide > aSide && aSide + cSide > bSide))
        {
            throw new ArgumentException("Треугольника с такими сторонами не существует");
        }

        ASide = aSide;
        BSide = bSide;
        CSide = cSide;
        this.perimeter = (ASide + BSide + CSide) / 2d;
    }
    
    public double GetSquare()
    {
        return Math.Sqrt(perimeter * (perimeter - ASide) * (perimeter - BSide) * (perimeter - CSide));
    }

    /// <summary>
    /// Проверка на правильность треугольника
    /// </summary>
    /// <returns>true, если треугольник правильный, иначе false</returns>
    public bool IsRight()
    {
        return Math.Pow(ASide, 2) == Math.Pow(BSide, 2) + Math.Pow(CSide, 2) ||
               Math.Pow(BSide, 2) == Math.Pow(ASide, 2) + Math.Pow(CSide, 2) ||
               Math.Pow(CSide, 2) == Math.Pow(BSide, 2) + Math.Pow(ASide, 2);
    }
}