using System.Numerics;

namespace Nixill.Units;

public interface INumericMultiplicationOperators<TSelf> : IMultiplyOperators<TSelf, double, TSelf>,
    IMultiplyOperators<TSelf, float, TSelf>, IMultiplyOperators<TSelf, byte, TSelf>,
    IMultiplyOperators<TSelf, sbyte, TSelf>, IMultiplyOperators<TSelf, short, TSelf>,
    IMultiplyOperators<TSelf, ushort, TSelf>, IMultiplyOperators<TSelf, int, TSelf>,
    IMultiplyOperators<TSelf, uint, TSelf>, IMultiplyOperators<TSelf, long, TSelf>,
    IMultiplyOperators<TSelf, ulong, TSelf>, IMultiplyOperators<TSelf, nint, TSelf>,
    IMultiplyOperators<TSelf, nuint, TSelf>
  where TSelf : INumericMultiplicationOperators<TSelf>
{
  public static abstract TSelf operator *(double left, TSelf right);
  public static abstract TSelf operator *(float left, TSelf right);
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

public interface INumericDivisionOperators<TSelf> : IDivisionOperators<TSelf, double, TSelf>,
    IDivisionOperators<TSelf, float, TSelf>, IDivisionOperators<TSelf, byte, TSelf>,
    IDivisionOperators<TSelf, sbyte, TSelf>, IDivisionOperators<TSelf, short, TSelf>,
    IDivisionOperators<TSelf, ushort, TSelf>, IDivisionOperators<TSelf, int, TSelf>,
    IDivisionOperators<TSelf, uint, TSelf>, IDivisionOperators<TSelf, long, TSelf>,
    IDivisionOperators<TSelf, ulong, TSelf>, IDivisionOperators<TSelf, nint, TSelf>,
    IDivisionOperators<TSelf, nuint, TSelf>
  where TSelf : INumericDivisionOperators<TSelf>
{
  public static abstract double operator /(TSelf left, TSelf right);
}

public interface IPrimaryFactorMeasure<TPrimary, TSecondary, TProduct> :
    IMultiplyOperators<TPrimary, TSecondary, TProduct>
  where TPrimary : IPrimaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TSecondary : ISecondaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TProduct : IProductMeasure<TPrimary, TSecondary, TProduct>
{ }

public interface ISecondaryFactorMeasure<TPrimary, TSecondary, TProduct> :
    IMultiplyOperators<TSecondary, TPrimary, TProduct>
  where TPrimary : IPrimaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TSecondary : ISecondaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TProduct : IProductMeasure<TPrimary, TSecondary, TProduct>
{ }

public interface IProductMeasure<TPrimary, TSecondary, TProduct> : IDivisionOperators<TProduct, TSecondary, TPrimary>
  where TPrimary : IPrimaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TSecondary : ISecondaryFactorMeasure<TPrimary, TSecondary, TProduct>
  where TProduct : IProductMeasure<TPrimary, TSecondary, TProduct>
{
  public static abstract TSecondary operator /(TProduct left, TPrimary right);
}

public interface ISquareRootMeasure<TSqrt, TSquare> : IMultiplyOperators<TSqrt, TSqrt, TSquare>
  where TSqrt : ISquareRootMeasure<TSqrt, TSquare>
  where TSquare : ISquareMeasure<TSqrt, TSquare>
{ }

public interface ISquareMeasure<TSqrt, TSquare> : IDivisionOperators<TSquare, TSqrt, TSqrt>
  where TSqrt : ISquareRootMeasure<TSqrt, TSquare>
  where TSquare : ISquareMeasure<TSqrt, TSquare>
{ }