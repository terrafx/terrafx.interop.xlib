// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Mask : IComparable, IComparable<Mask>, IEquatable<Mask>, IFormattable
{
    public readonly void* Value;

    public Mask(void* value)
    {
        Value = value;
    }

    public static Mask NULL => new Mask(null);

    public static bool operator ==(Mask left, Mask right) => left.Value == right.Value;

    public static bool operator !=(Mask left, Mask right) => left.Value != right.Value;

    public static bool operator <(Mask left, Mask right) => left.Value < right.Value;

    public static bool operator <=(Mask left, Mask right) => left.Value <= right.Value;

    public static bool operator >(Mask left, Mask right) => left.Value > right.Value;

    public static bool operator >=(Mask left, Mask right) => left.Value >= right.Value;

    public static explicit operator Mask(void* value) => new Mask(value);

    public static implicit operator void*(Mask value) => value.Value;

    public static explicit operator Mask(byte value) => new Mask(unchecked((void*)(value)));

    public static explicit operator byte(Mask value) => (byte)(value.Value);

    public static explicit operator Mask(short value) => new Mask(unchecked((void*)(value)));

    public static explicit operator short(Mask value) => (short)(value.Value);

    public static explicit operator Mask(int value) => new Mask(unchecked((void*)(value)));

    public static explicit operator int(Mask value) => (int)(value.Value);

    public static explicit operator Mask(long value) => new Mask(unchecked((void*)(value)));

    public static explicit operator long(Mask value) => (long)(value.Value);

    public static explicit operator Mask(nint value) => new Mask(unchecked((void*)(value)));

    public static implicit operator nint(Mask value) => (nint)(value.Value);

    public static explicit operator Mask(sbyte value) => new Mask(unchecked((void*)(value)));

    public static explicit operator sbyte(Mask value) => (sbyte)(value.Value);

    public static explicit operator Mask(ushort value) => new Mask(unchecked((void*)(value)));

    public static explicit operator ushort(Mask value) => (ushort)(value.Value);

    public static explicit operator Mask(uint value) => new Mask(unchecked((void*)(value)));

    public static explicit operator uint(Mask value) => (uint)(value.Value);

    public static explicit operator Mask(ulong value) => new Mask(unchecked((void*)(value)));

    public static explicit operator ulong(Mask value) => (ulong)(value.Value);

    public static explicit operator Mask(nuint value) => new Mask(unchecked((void*)(value)));

    public static implicit operator nuint(Mask value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Mask other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Mask.");
    }

    public int CompareTo(Mask other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Mask other) && Equals(other);

    public bool Equals(Mask other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
