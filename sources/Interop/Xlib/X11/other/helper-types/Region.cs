// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Region : IComparable, IComparable<Region>, IEquatable<Region>, IFormattable
{
    public readonly void* Value;

    public Region(void* value)
    {
        Value = value;
    }

    public static Region NULL => new Region(null);

    public static bool operator ==(Region left, Region right) => left.Value == right.Value;

    public static bool operator !=(Region left, Region right) => left.Value != right.Value;

    public static bool operator <(Region left, Region right) => left.Value < right.Value;

    public static bool operator <=(Region left, Region right) => left.Value <= right.Value;

    public static bool operator >(Region left, Region right) => left.Value > right.Value;

    public static bool operator >=(Region left, Region right) => left.Value >= right.Value;

    public static explicit operator Region(void* value) => new Region(value);

    public static implicit operator void*(Region value) => value.Value;

    public static explicit operator Region(byte value) => new Region(unchecked((void*)(value)));

    public static explicit operator byte(Region value) => (byte)(value.Value);

    public static explicit operator Region(short value) => new Region(unchecked((void*)(value)));

    public static explicit operator short(Region value) => (short)(value.Value);

    public static explicit operator Region(int value) => new Region(unchecked((void*)(value)));

    public static explicit operator int(Region value) => (int)(value.Value);

    public static explicit operator Region(long value) => new Region(unchecked((void*)(value)));

    public static explicit operator long(Region value) => (long)(value.Value);

    public static explicit operator Region(nint value) => new Region(unchecked((void*)(value)));

    public static implicit operator nint(Region value) => (nint)(value.Value);

    public static explicit operator Region(sbyte value) => new Region(unchecked((void*)(value)));

    public static explicit operator sbyte(Region value) => (sbyte)(value.Value);

    public static explicit operator Region(ushort value) => new Region(unchecked((void*)(value)));

    public static explicit operator ushort(Region value) => (ushort)(value.Value);

    public static explicit operator Region(uint value) => new Region(unchecked((void*)(value)));

    public static explicit operator uint(Region value) => (uint)(value.Value);

    public static explicit operator Region(ulong value) => new Region(unchecked((void*)(value)));

    public static explicit operator ulong(Region value) => (ulong)(value.Value);

    public static explicit operator Region(nuint value) => new Region(unchecked((void*)(value)));

    public static implicit operator nuint(Region value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Region other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Region.");
    }

    public int CompareTo(Region other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Region other) && Equals(other);

    public bool Equals(Region other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
