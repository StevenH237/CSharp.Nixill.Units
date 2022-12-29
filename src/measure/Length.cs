using System.Numerics;
using Nixill.Units.Extensions;

namespace Nixill.Units;

public struct LengthUnit : ILinearUnit<Length>
{
  public double Scale { get; set; }
  public string Name { get; set; }
  public string Abbreviation { get; set; }

  public LengthUnit(double scale, string name, string abbreviation)
  {
    Scale = scale;
    Name = name;
    Abbreviation = abbreviation;
  }

  public static LengthUnit Meter = new(1, "meter", "m");
  public static LengthUnit Kilometer = new(1000, "kilometer", "km");
  public static LengthUnit Centimeter = new(0.01, "centimeter", "cm");
  public static LengthUnit Millimeter = new(0.001, "millimeter", "mm");
  public static LengthUnit Inch = new(0.0254, "inch", "in");
  public static LengthUnit Foot = new(0.3048, "foot", "ft");
  public static LengthUnit Yard = new(0.9144, "yard", "yd");
  public static LengthUnit Mile = new(1609.344, "mile", "mi");
  public static LengthUnit NauticalMile = new(1852, "nautical mile", "nmi");
}

public struct Length : ILinearMeasurement<Length>
{
  public static ILinearUnit<Length> SIUnit => LengthUnit.Meter;
  public static Length AdditiveIdentity => new(0);
  public static double MultiplicativeIdentity => 1;

  public Length(ILinearUnit<Length> unit, double amount)
  {
    Unit = unit;
    Amount = amount;
  }

  public Length(double amount)
  {
    Unit = SIUnit;
    Amount = amount;
  }

  public ILinearUnit<Length> Unit { get; set; }
  public double Amount { get; set; }

  public int CompareTo(Length other)
  {
    throw new NotImplementedException();
  }

  public ILinearMeasurement<Length> WithOtherUnit(ILinearUnit<Length> unit) =>
    new Length(unit, this.Amount * Unit.Scale / unit.Scale);

  public double AmountWithOtherUnit(ILinearUnit<Length> unit) =>
    this.Amount * Unit.Scale / unit.Scale;

  public static Length operator +(Length value) => value;
  public static Length operator +(Length left, Length right)
    => new Length(left.Unit, left.Amount + right.AmountWithOtherUnit(left.Unit));

  public static Length operator -(Length value) => new Length(value.Unit, -value.Amount);
  public static Length operator -(Length left, Length right)
    => new Length(left.Unit, left.Amount - right.AmountWithOtherUnit(left.Unit));

  public static Length operator *(double left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(float left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(byte left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(sbyte left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(short left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(ushort left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(int left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(uint left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(long left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(ulong left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(nint left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(nuint left, Length right) => new Length(right.Unit, right.Amount * left);
  public static Length operator *(Length left, double right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, float right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, byte right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, sbyte right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, short right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, ushort right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, int right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, uint right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, long right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, ulong right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, nint right) => new Length(left.Unit, left.Amount * right);
  public static Length operator *(Length left, nuint right) => new Length(left.Unit, left.Amount * right);

  public static double operator /(Length left, Length right) => left.Amount / right.AmountWithOtherUnit(left.Unit);
  public static Length operator /(Length left, double right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, float right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, byte right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, sbyte right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, short right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, ushort right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, int right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, uint right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, long right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, ulong right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, nint right) => new Length(left.Unit, left.Amount / right);
  public static Length operator /(Length left, nuint right) => new Length(left.Unit, left.Amount / right);

  public static Length operator %(Length left, Length right)
    => new Length(left.Unit, left.Amount % right.AmountWithOtherUnit(left.Unit));

  public static bool operator ==(Length left, Length right) => left.Amount == right.AmountWithOtherUnit(left.Unit);
  public static bool operator !=(Length left, Length right) => left.Amount != right.AmountWithOtherUnit(left.Unit);
  public static bool operator <(Length left, Length right) => left.Amount < right.AmountWithOtherUnit(left.Unit);
  public static bool operator >(Length left, Length right) => left.Amount > right.AmountWithOtherUnit(left.Unit);
  public static bool operator <=(Length left, Length right) => left.Amount <= right.AmountWithOtherUnit(left.Unit);
  public static bool operator >=(Length left, Length right) => left.Amount >= right.AmountWithOtherUnit(left.Unit);

  public override bool Equals(object? obj)
  {
    if (obj is Length len) return Amount == len.Amount;
    else return false;
  }

  public override int GetHashCode()
    => (Unit, Amount).GetHashCode();

  public override string? ToString()
    => $"{Amount} {Unit.Abbreviation}";
}
