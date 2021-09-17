/**
 * A very basic project with basic testing, used for the purpose of learning Jenkins.
 */

using System;
using static TriangleTesting.Enums;

namespace TriangleTesting
{
  public class Trigonometric
  {
    public static double eqSide1, eqSide2, eqSide3;

    static void Main(string[] args)
    {
      Console.WriteLine("Trigonometric");
    }

    /// <summary>
    /// Method that tests, based on three given values representing the sides of a triangle,
    /// the type of triangle it is.
    /// </summary>
    /// <param name="side1">The length for the first side of the triangle.</param>
    /// <param name="side2">The length for the second side of the triangle.</param>
    /// <param name="side3">The length for the third side of the triangle.</param>
    /// <returns></returns>
    public TriangleTypeBySides GetTriangleTypeBySides(double side1, double side2, double side3)
    {
      TriangleTypeBySides triangleType = TriangleTypeBySides.Scalene;

      if (side1 == side2 && side1 == side3)
      {
        triangleType = TriangleTypeBySides.Equilateral;
      }
      else if (side1 == side2 || side1 == side3 || side1 == side3)
      {
        triangleType = TriangleTypeBySides.Isosceles;
      }

      return triangleType;
    }

    /// <summary>
    /// Method that tests, based on three given values representing the angles of a triangle,
    /// the type of triangle it is.
    /// </summary>
    /// <param name="angle1">The degrees for the first angle of the triangle.</param>
    /// <param name="angle2">The degrees for the second angle of the triangle.</param>
    /// <param name="angle3">The degrees for the third angle of the triangle.</param>
    /// <returns></returns>
    public TriangleTypeByAngles GetTriangleTypeByAngles(int angle1, int angle2, int angle3)
    {
      TriangleTypeByAngles triangleType = TriangleTypeByAngles.Unknown;

      if (angle1 == 90 || angle2 == 90 || angle3 == 90)
      {
        triangleType = TriangleTypeByAngles.Right;
      }
      else if (angle1 < 90 && angle2 < 90 && angle3 < 90)
      {
        triangleType = TriangleTypeByAngles.Acute;
      }
      else if (angle1 > 90 || angle2 > 90 || angle3 > 90)
      {
        triangleType = TriangleTypeByAngles.Obtuse;
      }

      return triangleType;
    }
  }
}
