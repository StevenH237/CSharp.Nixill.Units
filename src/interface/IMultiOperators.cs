using System.Numerics;

namespace Nixill.Units;

public interface INumericMultiplicationOperators<TSelf> : IMultiplyOperators<TSelf, double, TSelf>,
    IMultiplyOperators<TSelf, float, TSelf>, IMultiplyOperators<TSelf, decimal, TSelf>,
    IMultiplyOperators<TSelf, byte, TSelf>, IMultiplyOperators<TSelf, sbyte, TSelf>,
    IMultiplyOperators<TSelf, short, TSelf>, IMultiplyOperators<TSelf, ushort, TSelf>,
    IMultiplyOperators<TSelf, int, TSelf>, IMultiplyOperators<TSelf, uint, TSelf>,
    IMultiplyOperators<TSelf, long, TSelf>, IMultiplyOperators<TSelf, ulong, TSelf>,
    IMultiplyOperators<TSelf, nint, TSelf>, IMultiplyOperators<TSelf, nuint, TSelf>
  where TSelf : INumericMultiplicationOperators<TSelf>
{
  public static abstract TSelf operator *(double left, TSelf right);
  public static abstract TSelf operator *(float left, TSelf right);
  public static abstract TSelf operator *(decimal left, TSelf right);
  public static abstract TSelf operator *(byte left, TSelf right);
  public static abstract TSelf operator *(sbyte left, TSelf right);
  public static abstract TSelf operator *(short left, TSelf right);
  public static abstract TSelf operator *(ushort left, TSelf right);
  public static abstract TSelf operator *(int left, TSelf right);
  public static abstract TSelf operator *(uint left, TSelf right);
  public static abstract TSelf operator *(long left, TSelf right);
  public static abstract TSelf operator *(ulong left, TSelf right);
  public static abstract TSelf operator *(nint left, TSelf right);
  public static abstract TSelf operator *(nuint left, TSelf right);
}

public interface INumericDivisionOperators<TSelf> :
    IDivisionOperators<TSelf, double, TSelf>, IDivisionOperators<TSelf, float, TSelf>,
    IDivisionOperators<TSelf, decimal, TSelf>, IDivisionOperators<TSelf, byte, TSelf>,
    IDivisionOperators<TSelf, sbyte, TSelf>, IDivisionOperators<TSelf, short, TSelf>,
    IDivisionOperators<TSelf, ushort, TSelf>, IDivisionOperators<TSelf, int, TSelf>,
    IDivisionOperators<TSelf, uint, TSelf>, IDivisionOperators<TSelf, long, TSelf>,
    IDivisionOperators<TSelf, ulong, TSelf>, IDivisionOperators<TSelf, nint, TSelf>,
    IDivisionOperators<TSelf, nuint, TSelf>
  where TSelf : INumericDivisionOperators<TSelf>
{
  public static abstract double operator /(TSelf left, TSelf right);
}