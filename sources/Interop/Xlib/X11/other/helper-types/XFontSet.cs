// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public unsafe partial struct XFontSet : IComparable, IComparable<XFontSet>, IEquatable<XFontSet>, IFormattable
{
    public readonly void* Value;

    public XFontSet(void* value)
    {
        Value = value;
    }

    public static XFontSet NULL => new XFontSet(null);

    public static bool operator ==(XFontSet left, XFontSet right) => left.Value == right.Value;

    public static bool operator !=(XFontSet left, XFontSet right) => left.Value != right.Value;

    public static bool operator <(XFontSet left, XFontSet right) => left.Value < right.Value;

    public static bool operator <=(XFontSet left, XFontSet right) => left.Value <= right.Value;

    public static bool operator >(XFontSet left, XFontSet right) => left.Value > right.Value;

    public static bool operator >=(XFontSet left, XFontSet right) => left.Value >= right.Value;

    public static explicit operator XFontSet(void* value) => new XFontSet(value);

    public static implicit operator void*(XFontSet value) => value.Value;

    public static explicit operator XFontSet(byte value) => new XFontSet((void*)(value));

    public static explicit operator byte(XFontSet value) => (byte)(value.Value);

    public static explicit operator XFontSet(short value) => new XFontSet((void*)(value));

    public static explicit operator short(XFontSet value) => (short)(value.Value);

    public static explicit operator XFontSet(int value) => new XFontSet((void*)(value));

    public static explicit operator int(XFontSet value) => (int)(value.Value);

    public static explicit operator XFontSet(long value) => new XFontSet((void*)(value));

    public static explicit operator long(XFontSet value) => (long)(value.Value);

    public static explicit operator XFontSet(nint value) => new XFontSet((void*)(value));

    public static implicit operator nint(XFontSet value) => (nint)(value.Value);

    public static explicit operator XFontSet(sbyte value) => new XFontSet((void*)(value));

    public static explicit operator sbyte(XFontSet value) => (sbyte)(value.Value);

    public static explicit operator XFontSet(ushort value) => new XFontSet((void*)(value));

    public static explicit operator ushort(XFontSet value) => (ushort)(value.Value);

    public static explicit operator XFontSet(uint value) => new XFontSet((void*)(value));

    public static explicit operator uint(XFontSet value) => (uint)(value.Value);

    public static explicit operator XFontSet(ulong value) => new XFontSet((void*)(value));

    public static explicit operator ulong(XFontSet value) => (ulong)(value.Value);

    public static explicit operator XFontSet(nuint value) => new XFontSet((void*)(value));

    public static implicit operator nuint(XFontSet value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XFontSet other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XFontSet.");
    }

    public int CompareTo(XFontSet other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XFontSet other) && Equals(other);

    public bool Equals(XFontSet other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
