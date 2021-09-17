using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleTesting
{
  public class Enums
  {
    public enum TriangleTypeBySides
    {
      Equilateral,
      Isosceles,
      Scalene // no sides same length
    }

    public enum TriangleTypeByAngles
    {
      Acute, // all angles <90
      Right,
      Obtuse, // one angle >90
      Unknown
    }
  }
}
