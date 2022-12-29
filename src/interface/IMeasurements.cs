using System.Numerics;

namespace Nixill.Units;

public interface ILinearMeasurement<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>,
  IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>,
  IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, double>, INumericDivisionOperators<TSelf>,
  INumericMultiplicationOperators<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>,
  IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>
where TSelf : ILinearMeasurement<TSelf>
{
  public static abstract ILinearUnit<TSelf> SIUnit { get; }

  public ILinearUnit<TSelf> Unit { get; }
  public double Amount { get; }

  public ILinearMeasurement<TSelf> WithOtherUnit(ILinearUnit<TSelf> unit);

  public bool Equals(object? other);
  public int GetHashCode();

  public string? ToString();
}
