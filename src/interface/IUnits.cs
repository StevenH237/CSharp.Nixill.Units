using System.Numerics;

namespace Nixill.Units;

public interface ILinearUnit<TMeasure>
{
  public double Scale { get; set; }
  public string Name { get; set; }
  public string Abbreviation { get; set; }
}
