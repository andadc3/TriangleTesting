using NUnit.Framework;
using TriangleTesting;
using static TriangleTesting.Enums;

namespace Test.TriangleTesting
{
  [TestFixture]
  public class Tests
  {
    private Trigonometric trig;

    [SetUp]
    public void Setup()
    {
      this.trig = new Trigonometric();
    }

    [TestCase(TriangleTypeBySides.Isosceles, 5.5, 6.5, 5.5)]
    [TestCase(TriangleTypeBySides.Equilateral, 5.5, 5.5, 5.5)]
    [TestCase(TriangleTypeBySides.Scalene, 5.5, 6.5, 7.5)]
    public void Test_TriangleTypeBySides_Is_Correctly_Determined(TriangleTypeBySides expectedType, double side1, double side2, double side3)
    {
      var triangleTypeBySides = this.trig.GetTriangleTypeBySides(side1, side2, side3);

      switch (expectedType)
      {
        case TriangleTypeBySides.Equilateral:
          Assert.IsTrue(triangleTypeBySides == TriangleTypeBySides.Equilateral);
          break;
        case TriangleTypeBySides.Isosceles:
          Assert.IsTrue(triangleTypeBySides == TriangleTypeBySides.Isosceles);
          break;
        case TriangleTypeBySides.Scalene:
          Assert.IsTrue(triangleTypeBySides == TriangleTypeBySides.Scalene);
          break;
        default:
          break;
      }
    }

    [TestCase(TriangleTypeByAngles.Right, 90, 50, 40)]
    [TestCase(TriangleTypeByAngles.Acute, 70, 80, 30)]
    [TestCase(TriangleTypeByAngles.Obtuse, 100, 50, 30)]
    public void Test_TriangleTypeByAngles_Is_Correctly_Determined(TriangleTypeByAngles expectedType, int degreesAngle1, int degreesAngle2, int degreesAngle3)
    {
      var triangleTypeByAngles = this.trig.GetTriangleTypeByAngles(degreesAngle1, degreesAngle2, degreesAngle3);

      switch (expectedType)
      {
        case TriangleTypeByAngles.Right:
          Assert.IsTrue(triangleTypeByAngles == TriangleTypeByAngles.Right);
          break;
        case TriangleTypeByAngles.Obtuse:
          Assert.IsTrue(triangleTypeByAngles == TriangleTypeByAngles.Obtuse);
          break;
        case TriangleTypeByAngles.Acute:
          Assert.IsTrue(triangleTypeByAngles == TriangleTypeByAngles.Acute);
          break;
        default:
          break;
      }
    }
  }
}