using System.Numerics;

namespace Nixill.Units;

public interface ILinearMeasurement<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>,
  IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>,
  IModulusOperators<TSelf, TSelf, TSelf>, INumericDivisionOperators<TSelf>, INumericMultiplicationOperators<TSelf>,
  ISubtractionOperators<TSelf, TSelf, TSelf>
where TSelf : ILinearMeasurement<TSelf>
{

}
