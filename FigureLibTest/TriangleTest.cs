using System;
using FigureLib;
using NUnit.Framework;

namespace FigureLibTest;

[TestFixture]
public class TriangleTest
{
    /// <summary>
    /// Проверяем, упадет ли эксепшн при отрицательной A стороне
    /// </summary>
    [Test]
    public void Constructor_NegativeASide_Exception()
    {
        Triangle tr;
        var ex = Assert.Throws<ArgumentException>(() => tr = new Triangle(-1, 12, 13));
        Assert.That(ex.Message, Is.EqualTo("Сторона меньше нуля (Parameter 'aSide')"));
    }
    
    /// <summary>
    /// Проверяем, упадет ли эксепшн при отрицательной B стороне
    /// </summary>
    [Test]
    public void Constructor_NegativeBSide_Exception()
    {
        Triangle tr;
        var ex = Assert.Throws<ArgumentException>(() => tr = new Triangle(12, -1, 13));
        Assert.That(ex.Message, Is.EqualTo("Сторона меньше нуля (Parameter 'bSide')"));
    }
    
    /// <summary>
    /// Проверяем, упадет ли эксепшн при отрицательной C стороне
    /// </summary>
    [Test]
    public void Constructor_NegativeCSide_Exception()
    {
        Triangle tr;
        var ex = Assert.Throws<ArgumentException>(() => tr = new Triangle(12, 13, -1));
        Assert.That(ex.Message, Is.EqualTo("Сторона меньше нуля (Parameter 'cSide')"));
    }
    
    /// <summary>
    /// Проверяем, упадет ли эксепшн при всех отрицательных сторонах
    /// </summary>
    [Test]
    public void Constructor_NegativeAllSides_Exception()
    {
        Triangle tr;
        var ex = Assert.Throws<ArgumentException>(() => tr = new Triangle(-1, -1, -1));
        Assert.That(ex.Message, Is.EqualTo("Сторона меньше нуля (Parameter 'aSide')"));
    }

    /// <summary>
    /// Проверяем, упадет ли эксепшн, если треугольника не существует
    /// </summary>
    [Test]
    public void Constructor_DoesntExistTriangle_Exception()
    {
        Triangle tr;
        var ex = Assert.Throws<ArgumentException>(() => tr = new Triangle(40, 20, 61));
        Assert.That(ex.Message, Is.EqualTo("Треугольника с такими сторонами не существует"));
    }

    /// <summary>
    /// Проверяем, будет ли прямоугольным прямоугольный треугольник
    /// </summary>
    [Test]
    public void IsRight_RightTriangle_True()
    {
        Triangle tr = new Triangle(3, 4, 5);
        Assert.That(tr.IsRight, Is.EqualTo(true));
    }

    /// <summary>
    /// Проверяем, будет ли прямоугольным рандомный треугольник
    /// </summary>
    [Test]
    public void IsRight_SimpleTriangle_False()
    {
        Triangle tr = new Triangle(12, 4, 9);
        Assert.That(tr.IsRight, Is.EqualTo(false));
    }

    /// <summary>
    /// Проверяем подсчет площади треугольника
    /// </summary>
    [Test]
    public void GetSquare_SimpleTriangle_Square()
    {
        Triangle tr = new Triangle(12, 4, 9);
        
        Assert.That(tr.GetSquare(), Is.AtLeast(13.63589));
    }
}