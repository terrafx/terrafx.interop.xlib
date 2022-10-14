// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XIM : IComparable, IComparable<XIM>, IEquatable<XIM>, IFormattable
{
    public readonly void* Value;

    public XIM(void* value)
    {
        Value = value;
    }

    public static XIM NULL => new XIM(null);

    public static bool operator ==(XIM left, XIM right) => left.Value == right.Value;

    public static bool operator !=(XIM left, XIM right) => left.Value != right.Value;

    public static bool operator <(XIM left, XIM right) => left.Value < right.Value;

    public static bool operator <=(XIM left, XIM right) => left.Value <= right.Value;

    public static bool operator >(XIM left, XIM right) => left.Value > right.Value;

    public static bool operator >=(XIM left, XIM right) => left.Value >= right.Value;

    public static explicit operator XIM(void* value) => new XIM(value);

    public static implicit operator void*(XIM value) => value.Value;

    public static explicit operator XIM(byte value) => new XIM((void*)(value));

    public static explicit operator byte(XIM value) => (byte)(value.Value);

    public static explicit operator XIM(short value) => new XIM((void*)(value));

    public static explicit operator short(XIM value) => (short)(value.Value);

    public static explicit operator XIM(int value) => new XIM((void*)(value));

    public static explicit operator int(XIM value) => (int)(value.Value);

    public static explicit operator XIM(long value) => new XIM((void*)(value));

    public static explicit operator long(XIM value) => (long)(value.Value);

    public static explicit operator XIM(nint value) => new XIM((void*)(value));

    public static implicit operator nint(XIM value) => (nint)(value.Value);

    public static explicit operator XIM(sbyte value) => new XIM((void*)(value));

    public static explicit operator sbyte(XIM value) => (sbyte)(value.Value);

    public static explicit operator XIM(ushort value) => new XIM((void*)(value));

    public static explicit operator ushort(XIM value) => (ushort)(value.Value);

    public static explicit operator XIM(uint value) => new XIM((void*)(value));

    public static explicit operator uint(XIM value) => (uint)(value.Value);

    public static explicit operator XIM(ulong value) => new XIM((void*)(value));

    public static explicit operator ulong(XIM value) => (ulong)(value.Value);

    public static explicit operator XIM(nuint value) => new XIM((void*)(value));

    public static implicit operator nuint(XIM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XIM other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XIM.");
    }

    public int CompareTo(XIM other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XIM other) && Equals(other);

    public bool Equals(XIM other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
