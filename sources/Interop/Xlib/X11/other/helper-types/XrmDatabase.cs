// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XrmDatabase : IComparable, IComparable<XrmDatabase>, IEquatable<XrmDatabase>, IFormattable
{
    public readonly void* Value;

    public XrmDatabase(void* value)
    {
        Value = value;
    }

    public static XrmDatabase NULL => new XrmDatabase(null);

    public static bool operator ==(XrmDatabase left, XrmDatabase right) => left.Value == right.Value;

    public static bool operator !=(XrmDatabase left, XrmDatabase right) => left.Value != right.Value;

    public static bool operator <(XrmDatabase left, XrmDatabase right) => left.Value < right.Value;

    public static bool operator <=(XrmDatabase left, XrmDatabase right) => left.Value <= right.Value;

    public static bool operator >(XrmDatabase left, XrmDatabase right) => left.Value > right.Value;

    public static bool operator >=(XrmDatabase left, XrmDatabase right) => left.Value >= right.Value;

    public static explicit operator XrmDatabase(void* value) => new XrmDatabase(value);

    public static implicit operator void*(XrmDatabase value) => value.Value;

    public static explicit operator XrmDatabase(byte value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator byte(XrmDatabase value) => (byte)(value.Value);

    public static explicit operator XrmDatabase(short value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator short(XrmDatabase value) => (short)(value.Value);

    public static explicit operator XrmDatabase(int value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator int(XrmDatabase value) => (int)(value.Value);

    public static explicit operator XrmDatabase(long value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator long(XrmDatabase value) => (long)(value.Value);

    public static explicit operator XrmDatabase(nint value) => new XrmDatabase(unchecked((void*)(value)));

    public static implicit operator nint(XrmDatabase value) => (nint)(value.Value);

    public static explicit operator XrmDatabase(sbyte value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator sbyte(XrmDatabase value) => (sbyte)(value.Value);

    public static explicit operator XrmDatabase(ushort value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator ushort(XrmDatabase value) => (ushort)(value.Value);

    public static explicit operator XrmDatabase(uint value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator uint(XrmDatabase value) => (uint)(value.Value);

    public static explicit operator XrmDatabase(ulong value) => new XrmDatabase(unchecked((void*)(value)));

    public static explicit operator ulong(XrmDatabase value) => (ulong)(value.Value);

    public static explicit operator XrmDatabase(nuint value) => new XrmDatabase(unchecked((void*)(value)));

    public static implicit operator nuint(XrmDatabase value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XrmDatabase other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XrmDatabase.");
    }

    public int CompareTo(XrmDatabase other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XrmDatabase other) && Equals(other);

    public bool Equals(XrmDatabase other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
