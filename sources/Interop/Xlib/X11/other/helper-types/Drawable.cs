// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Drawable : IComparable, IComparable<Drawable>, IEquatable<Drawable>, IFormattable
{
    public readonly void* Value;

    public Drawable(void* value)
    {
        Value = value;
    }

    public static Drawable NULL => new Drawable(null);

    public static bool operator ==(Drawable left, Drawable right) => left.Value == right.Value;

    public static bool operator !=(Drawable left, Drawable right) => left.Value != right.Value;

    public static bool operator <(Drawable left, Drawable right) => left.Value < right.Value;

    public static bool operator <=(Drawable left, Drawable right) => left.Value <= right.Value;

    public static bool operator >(Drawable left, Drawable right) => left.Value > right.Value;

    public static bool operator >=(Drawable left, Drawable right) => left.Value >= right.Value;

    public static explicit operator Drawable(void* value) => new Drawable(value);

    public static implicit operator void*(Drawable value) => value.Value;

    public static explicit operator Drawable(byte value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator byte(Drawable value) => (byte)(value.Value);

    public static explicit operator Drawable(short value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator short(Drawable value) => (short)(value.Value);

    public static explicit operator Drawable(int value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator int(Drawable value) => (int)(value.Value);

    public static explicit operator Drawable(long value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator long(Drawable value) => (long)(value.Value);

    public static explicit operator Drawable(nint value) => new Drawable(unchecked((void*)(value)));

    public static implicit operator nint(Drawable value) => (nint)(value.Value);

    public static explicit operator Drawable(sbyte value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator sbyte(Drawable value) => (sbyte)(value.Value);

    public static explicit operator Drawable(ushort value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator ushort(Drawable value) => (ushort)(value.Value);

    public static explicit operator Drawable(uint value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator uint(Drawable value) => (uint)(value.Value);

    public static explicit operator Drawable(ulong value) => new Drawable(unchecked((void*)(value)));

    public static explicit operator ulong(Drawable value) => (ulong)(value.Value);

    public static explicit operator Drawable(nuint value) => new Drawable(unchecked((void*)(value)));

    public static implicit operator nuint(Drawable value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Drawable other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Drawable.");
    }

    public int CompareTo(Drawable other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Drawable other) && Equals(other);

    public bool Equals(Drawable other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
