// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct XrmHashBucket : IComparable, IComparable<XrmHashBucket>, IEquatable<XrmHashBucket>, IFormattable
{
    public readonly void* Value;

    public XrmHashBucket(void* value)
    {
        Value = value;
    }

    public static XrmHashBucket NULL => new XrmHashBucket(null);

    public static bool operator ==(XrmHashBucket left, XrmHashBucket right) => left.Value == right.Value;

    public static bool operator !=(XrmHashBucket left, XrmHashBucket right) => left.Value != right.Value;

    public static bool operator <(XrmHashBucket left, XrmHashBucket right) => left.Value < right.Value;

    public static bool operator <=(XrmHashBucket left, XrmHashBucket right) => left.Value <= right.Value;

    public static bool operator >(XrmHashBucket left, XrmHashBucket right) => left.Value > right.Value;

    public static bool operator >=(XrmHashBucket left, XrmHashBucket right) => left.Value >= right.Value;

    public static explicit operator XrmHashBucket(void* value) => new XrmHashBucket(value);

    public static implicit operator void*(XrmHashBucket value) => value.Value;

    public static explicit operator XrmHashBucket(byte value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator byte(XrmHashBucket value) => (byte)(value.Value);

    public static explicit operator XrmHashBucket(short value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator short(XrmHashBucket value) => (short)(value.Value);

    public static explicit operator XrmHashBucket(int value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator int(XrmHashBucket value) => (int)(value.Value);

    public static explicit operator XrmHashBucket(long value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator long(XrmHashBucket value) => (long)(value.Value);

    public static explicit operator XrmHashBucket(nint value) => new XrmHashBucket(unchecked((void*)(value)));

    public static implicit operator nint(XrmHashBucket value) => (nint)(value.Value);

    public static explicit operator XrmHashBucket(sbyte value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator sbyte(XrmHashBucket value) => (sbyte)(value.Value);

    public static explicit operator XrmHashBucket(ushort value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator ushort(XrmHashBucket value) => (ushort)(value.Value);

    public static explicit operator XrmHashBucket(uint value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator uint(XrmHashBucket value) => (uint)(value.Value);

    public static explicit operator XrmHashBucket(ulong value) => new XrmHashBucket(unchecked((void*)(value)));

    public static explicit operator ulong(XrmHashBucket value) => (ulong)(value.Value);

    public static explicit operator XrmHashBucket(nuint value) => new XrmHashBucket(unchecked((void*)(value)));

    public static implicit operator nuint(XrmHashBucket value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is XrmHashBucket other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XrmHashBucket.");
    }

    public int CompareTo(XrmHashBucket other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is XrmHashBucket other) && Equals(other);

    public bool Equals(XrmHashBucket other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
