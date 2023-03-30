// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Cursor : IComparable, IComparable<Cursor>, IEquatable<Cursor>, IFormattable
{
    public readonly void* Value;

    public Cursor(void* value)
    {
        Value = value;
    }

    public static Cursor NULL => new Cursor(null);

    public static bool operator ==(Cursor left, Cursor right) => left.Value == right.Value;

    public static bool operator !=(Cursor left, Cursor right) => left.Value != right.Value;

    public static bool operator <(Cursor left, Cursor right) => left.Value < right.Value;

    public static bool operator <=(Cursor left, Cursor right) => left.Value <= right.Value;

    public static bool operator >(Cursor left, Cursor right) => left.Value > right.Value;

    public static bool operator >=(Cursor left, Cursor right) => left.Value >= right.Value;

    public static explicit operator Cursor(void* value) => new Cursor(value);

    public static implicit operator void*(Cursor value) => value.Value;

    public static explicit operator Cursor(byte value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator byte(Cursor value) => (byte)(value.Value);

    public static explicit operator Cursor(short value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator short(Cursor value) => (short)(value.Value);

    public static explicit operator Cursor(int value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator int(Cursor value) => (int)(value.Value);

    public static explicit operator Cursor(long value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator long(Cursor value) => (long)(value.Value);

    public static explicit operator Cursor(nint value) => new Cursor(unchecked((void*)(value)));

    public static implicit operator nint(Cursor value) => (nint)(value.Value);

    public static explicit operator Cursor(sbyte value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator sbyte(Cursor value) => (sbyte)(value.Value);

    public static explicit operator Cursor(ushort value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator ushort(Cursor value) => (ushort)(value.Value);

    public static explicit operator Cursor(uint value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator uint(Cursor value) => (uint)(value.Value);

    public static explicit operator Cursor(ulong value) => new Cursor(unchecked((void*)(value)));

    public static explicit operator ulong(Cursor value) => (ulong)(value.Value);

    public static explicit operator Cursor(nuint value) => new Cursor(unchecked((void*)(value)));

    public static implicit operator nuint(Cursor value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Cursor other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Cursor.");
    }

    public int CompareTo(Cursor other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Cursor other) && Equals(other);

    public bool Equals(Cursor other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
