using System.Numerics;

namespace Nixill.Units;

public interface ILinearMeasurement<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>,
  IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>,
  IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, double>, INumericDivisionOperators<TSelf>,
  INumericMultiplicationOperators<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>,
  IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>
where TSelf : ILinearMeasurement<TSelf>
{

}
