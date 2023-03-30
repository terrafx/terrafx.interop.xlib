// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct Window : IComparable, IComparable<Window>, IEquatable<Window>, IFormattable
{
    public readonly void* Value;

    public Window(void* value)
    {
        Value = value;
    }

    public static Window NULL => new Window(null);

    public static bool operator ==(Window left, Window right) => left.Value == right.Value;

    public static bool operator !=(Window left, Window right) => left.Value != right.Value;

    public static bool operator <(Window left, Window right) => left.Value < right.Value;

    public static bool operator <=(Window left, Window right) => left.Value <= right.Value;

    public static bool operator >(Window left, Window right) => left.Value > right.Value;

    public static bool operator >=(Window left, Window right) => left.Value >= right.Value;

    public static explicit operator Window(void* value) => new Window(value);

    public static implicit operator void*(Window value) => value.Value;

    public static explicit operator Window(byte value) => new Window(unchecked((void*)(value)));

    public static explicit operator byte(Window value) => (byte)(value.Value);

    public static explicit operator Window(short value) => new Window(unchecked((void*)(value)));

    public static explicit operator short(Window value) => (short)(value.Value);

    public static explicit operator Window(int value) => new Window(unchecked((void*)(value)));

    public static explicit operator int(Window value) => (int)(value.Value);

    public static explicit operator Window(long value) => new Window(unchecked((void*)(value)));

    public static explicit operator long(Window value) => (long)(value.Value);

    public static explicit operator Window(nint value) => new Window(unchecked((void*)(value)));

    public static implicit operator nint(Window value) => (nint)(value.Value);

    public static explicit operator Window(sbyte value) => new Window(unchecked((void*)(value)));

    public static explicit operator sbyte(Window value) => (sbyte)(value.Value);

    public static explicit operator Window(ushort value) => new Window(unchecked((void*)(value)));

    public static explicit operator ushort(Window value) => (ushort)(value.Value);

    public static explicit operator Window(uint value) => new Window(unchecked((void*)(value)));

    public static explicit operator uint(Window value) => (uint)(value.Value);

    public static explicit operator Window(ulong value) => new Window(unchecked((void*)(value)));

    public static explicit operator ulong(Window value) => (ulong)(value.Value);

    public static explicit operator Window(nuint value) => new Window(unchecked((void*)(value)));

    public static implicit operator nuint(Window value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Window other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Window.");
    }

    public int CompareTo(Window other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Window other) && Equals(other);

    public bool Equals(Window other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
