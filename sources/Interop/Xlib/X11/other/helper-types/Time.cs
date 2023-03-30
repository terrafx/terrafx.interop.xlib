// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Time : IComparable, IComparable<Time>, IEquatable<Time>, IFormattable
{
    public readonly void* Value;

    public Time(void* value)
    {
        Value = value;
    }

    public static Time NULL => new Time(null);

    public static bool operator ==(Time left, Time right) => left.Value == right.Value;

    public static bool operator !=(Time left, Time right) => left.Value != right.Value;

    public static bool operator <(Time left, Time right) => left.Value < right.Value;

    public static bool operator <=(Time left, Time right) => left.Value <= right.Value;

    public static bool operator >(Time left, Time right) => left.Value > right.Value;

    public static bool operator >=(Time left, Time right) => left.Value >= right.Value;

    public static explicit operator Time(void* value) => new Time(value);

    public static implicit operator void*(Time value) => value.Value;

    public static explicit operator Time(byte value) => new Time(unchecked((void*)(value)));

    public static explicit operator byte(Time value) => (byte)(value.Value);

    public static explicit operator Time(short value) => new Time(unchecked((void*)(value)));

    public static explicit operator short(Time value) => (short)(value.Value);

    public static explicit operator Time(int value) => new Time(unchecked((void*)(value)));

    public static explicit operator int(Time value) => (int)(value.Value);

    public static explicit operator Time(long value) => new Time(unchecked((void*)(value)));

    public static explicit operator long(Time value) => (long)(value.Value);

    public static explicit operator Time(nint value) => new Time(unchecked((void*)(value)));

    public static implicit operator nint(Time value) => (nint)(value.Value);

    public static explicit operator Time(sbyte value) => new Time(unchecked((void*)(value)));

    public static explicit operator sbyte(Time value) => (sbyte)(value.Value);

    public static explicit operator Time(ushort value) => new Time(unchecked((void*)(value)));

    public static explicit operator ushort(Time value) => (ushort)(value.Value);

    public static explicit operator Time(uint value) => new Time(unchecked((void*)(value)));

    public static explicit operator uint(Time value) => (uint)(value.Value);

    public static explicit operator Time(ulong value) => new Time(unchecked((void*)(value)));

    public static explicit operator ulong(Time value) => (ulong)(value.Value);

    public static explicit operator Time(nuint value) => new Time(unchecked((void*)(value)));

    public static implicit operator nuint(Time value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Time other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Time.");
    }

    public int CompareTo(Time other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Time other) && Equals(other);

    public bool Equals(Time other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
