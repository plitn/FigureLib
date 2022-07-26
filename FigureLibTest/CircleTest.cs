using System;
using FigureLib;
using NUnit.Framework;

namespace FigureLibTest;

[TestFixture]
public class CircleTest
{

    /// <summary>
    /// Проверяем, упадет ли эксепшн, при отрицательном радиусе
    /// </summary>
    [Test]
    public void Constructor_NegativeRadius_ArgumentException()
    {
        Circle circle;
        var ex = Assert.Throws<ArgumentException>(() => circle = new Circle(-10));
        Assert.That(ex.Message, Is.EqualTo("Отрицательный радиус круга"));
    }

    /// <summary>
    /// Проверяем, считается ли площадь при нулевом радиусе
    /// </summary>
    [Test]
    public void GetSquare_ZeroRadius_ZeroSquare()
    {
        Circle circle = new Circle(0);
        Assert.That(circle.GetSquare(), Is.EqualTo(0d));
    }

    /// <summary>
    /// Проверяем формулу площади
    /// </summary>
    [Test]
    public void GetSquare_RandomDoubleRadius_Square()
    {
        double radius = 14.453;
        Circle circle = new Circle(radius);
        Assert.That(circle.GetSquare(), Is.EqualTo(Math.PI * Math.Pow(14.453, 2)));
    }
}