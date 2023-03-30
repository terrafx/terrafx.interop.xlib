// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Pixmap : IComparable, IComparable<Pixmap>, IEquatable<Pixmap>, IFormattable
{
    public readonly void* Value;

    public Pixmap(void* value)
    {
        Value = value;
    }

    public static Pixmap NULL => new Pixmap(null);

    public static bool operator ==(Pixmap left, Pixmap right) => left.Value == right.Value;

    public static bool operator !=(Pixmap left, Pixmap right) => left.Value != right.Value;

    public static bool operator <(Pixmap left, Pixmap right) => left.Value < right.Value;

    public static bool operator <=(Pixmap left, Pixmap right) => left.Value <= right.Value;

    public static bool operator >(Pixmap left, Pixmap right) => left.Value > right.Value;

    public static bool operator >=(Pixmap left, Pixmap right) => left.Value >= right.Value;

    public static explicit operator Pixmap(void* value) => new Pixmap(value);

    public static implicit operator void*(Pixmap value) => value.Value;

    public static explicit operator Pixmap(byte value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator byte(Pixmap value) => (byte)(value.Value);

    public static explicit operator Pixmap(short value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator short(Pixmap value) => (short)(value.Value);

    public static explicit operator Pixmap(int value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator int(Pixmap value) => (int)(value.Value);

    public static explicit operator Pixmap(long value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator long(Pixmap value) => (long)(value.Value);

    public static explicit operator Pixmap(nint value) => new Pixmap(unchecked((void*)(value)));

    public static implicit operator nint(Pixmap value) => (nint)(value.Value);

    public static explicit operator Pixmap(sbyte value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator sbyte(Pixmap value) => (sbyte)(value.Value);

    public static explicit operator Pixmap(ushort value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator ushort(Pixmap value) => (ushort)(value.Value);

    public static explicit operator Pixmap(uint value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator uint(Pixmap value) => (uint)(value.Value);

    public static explicit operator Pixmap(ulong value) => new Pixmap(unchecked((void*)(value)));

    public static explicit operator ulong(Pixmap value) => (ulong)(value.Value);

    public static explicit operator Pixmap(nuint value) => new Pixmap(unchecked((void*)(value)));

    public static implicit operator nuint(Pixmap value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Pixmap other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Pixmap.");
    }

    public int CompareTo(Pixmap other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Pixmap other) && Equals(other);

    public bool Equals(Pixmap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
