// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Colormap : IComparable, IComparable<Colormap>, IEquatable<Colormap>, IFormattable
{
    public readonly void* Value;

    public Colormap(void* value)
    {
        Value = value;
    }

    public static Colormap NULL => new Colormap(null);

    public static bool operator ==(Colormap left, Colormap right) => left.Value == right.Value;

    public static bool operator !=(Colormap left, Colormap right) => left.Value != right.Value;

    public static bool operator <(Colormap left, Colormap right) => left.Value < right.Value;

    public static bool operator <=(Colormap left, Colormap right) => left.Value <= right.Value;

    public static bool operator >(Colormap left, Colormap right) => left.Value > right.Value;

    public static bool operator >=(Colormap left, Colormap right) => left.Value >= right.Value;

    public static explicit operator Colormap(void* value) => new Colormap(value);

    public static implicit operator void*(Colormap value) => value.Value;

    public static explicit operator Colormap(byte value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator byte(Colormap value) => (byte)(value.Value);

    public static explicit operator Colormap(short value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator short(Colormap value) => (short)(value.Value);

    public static explicit operator Colormap(int value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator int(Colormap value) => (int)(value.Value);

    public static explicit operator Colormap(long value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator long(Colormap value) => (long)(value.Value);

    public static explicit operator Colormap(nint value) => new Colormap(unchecked((void*)(value)));

    public static implicit operator nint(Colormap value) => (nint)(value.Value);

    public static explicit operator Colormap(sbyte value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator sbyte(Colormap value) => (sbyte)(value.Value);

    public static explicit operator Colormap(ushort value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator ushort(Colormap value) => (ushort)(value.Value);

    public static explicit operator Colormap(uint value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator uint(Colormap value) => (uint)(value.Value);

    public static explicit operator Colormap(ulong value) => new Colormap(unchecked((void*)(value)));

    public static explicit operator ulong(Colormap value) => (ulong)(value.Value);

    public static explicit operator Colormap(nuint value) => new Colormap(unchecked((void*)(value)));

    public static implicit operator nuint(Colormap value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Colormap other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Colormap.");
    }

    public int CompareTo(Colormap other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Colormap other) && Equals(other);

    public bool Equals(Colormap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
