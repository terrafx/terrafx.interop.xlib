// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XcmsCCC : IComparable, IComparable<XcmsCCC>, IEquatable<XcmsCCC>, IFormattable
{
    public readonly void* Value;

    public XcmsCCC(void* value)
    {
        Value = value;
    }

    public static XcmsCCC NULL => new XcmsCCC(null);

    public static bool operator ==(XcmsCCC left, XcmsCCC right) => left.Value == right.Value;

    public static bool operator !=(XcmsCCC left, XcmsCCC right) => left.Value != right.Value;

    public static bool operator <(XcmsCCC left, XcmsCCC right) => left.Value < right.Value;

    public static bool operator <=(XcmsCCC left, XcmsCCC right) => left.Value <= right.Value;

    public static bool operator >(XcmsCCC left, XcmsCCC right) => left.Value > right.Value;

    public static bool operator >=(XcmsCCC left, XcmsCCC right) => left.Value >= right.Value;

    public static explicit operator XcmsCCC(void* value) => new XcmsCCC(value);

    public static implicit operator void*(XcmsCCC value) => value.Value;

    public static explicit operator XcmsCCC(byte value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator byte(XcmsCCC value) => (byte)(value.Value);

    public static explicit operator XcmsCCC(short value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator short(XcmsCCC value) => (short)(value.Value);

    public static explicit operator XcmsCCC(int value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator int(XcmsCCC value) => (int)(value.Value);

    public static explicit operator XcmsCCC(long value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator long(XcmsCCC value) => (long)(value.Value);

    public static explicit operator XcmsCCC(nint value) => new XcmsCCC(unchecked((void*)(value)));

    public static implicit operator nint(XcmsCCC value) => (nint)(value.Value);

    public static explicit operator XcmsCCC(sbyte value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator sbyte(XcmsCCC value) => (sbyte)(value.Value);

    public static explicit operator XcmsCCC(ushort value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator ushort(XcmsCCC value) => (ushort)(value.Value);

    public static explicit operator XcmsCCC(uint value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator uint(XcmsCCC value) => (uint)(value.Value);

    public static explicit operator XcmsCCC(ulong value) => new XcmsCCC(unchecked((void*)(value)));

    public static explicit operator ulong(XcmsCCC value) => (ulong)(value.Value);

    public static explicit operator XcmsCCC(nuint value) => new XcmsCCC(unchecked((void*)(value)));

    public static implicit operator nuint(XcmsCCC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XcmsCCC other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XcmsCCC.");
    }

    public int CompareTo(XcmsCCC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XcmsCCC other) && Equals(other);

    public bool Equals(XcmsCCC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
