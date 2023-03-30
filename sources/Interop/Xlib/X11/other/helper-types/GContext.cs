// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct GContext : IComparable, IComparable<GContext>, IEquatable<GContext>, IFormattable
{
    public readonly void* Value;

    public GContext(void* value)
    {
        Value = value;
    }

    public static GContext NULL => new GContext(null);

    public static bool operator ==(GContext left, GContext right) => left.Value == right.Value;

    public static bool operator !=(GContext left, GContext right) => left.Value != right.Value;

    public static bool operator <(GContext left, GContext right) => left.Value < right.Value;

    public static bool operator <=(GContext left, GContext right) => left.Value <= right.Value;

    public static bool operator >(GContext left, GContext right) => left.Value > right.Value;

    public static bool operator >=(GContext left, GContext right) => left.Value >= right.Value;

    public static explicit operator GContext(void* value) => new GContext(value);

    public static implicit operator void*(GContext value) => value.Value;

    public static explicit operator GContext(byte value) => new GContext(unchecked((void*)(value)));

    public static explicit operator byte(GContext value) => (byte)(value.Value);

    public static explicit operator GContext(short value) => new GContext(unchecked((void*)(value)));

    public static explicit operator short(GContext value) => (short)(value.Value);

    public static explicit operator GContext(int value) => new GContext(unchecked((void*)(value)));

    public static explicit operator int(GContext value) => (int)(value.Value);

    public static explicit operator GContext(long value) => new GContext(unchecked((void*)(value)));

    public static explicit operator long(GContext value) => (long)(value.Value);

    public static explicit operator GContext(nint value) => new GContext(unchecked((void*)(value)));

    public static implicit operator nint(GContext value) => (nint)(value.Value);

    public static explicit operator GContext(sbyte value) => new GContext(unchecked((void*)(value)));

    public static explicit operator sbyte(GContext value) => (sbyte)(value.Value);

    public static explicit operator GContext(ushort value) => new GContext(unchecked((void*)(value)));

    public static explicit operator ushort(GContext value) => (ushort)(value.Value);

    public static explicit operator GContext(uint value) => new GContext(unchecked((void*)(value)));

    public static explicit operator uint(GContext value) => (uint)(value.Value);

    public static explicit operator GContext(ulong value) => new GContext(unchecked((void*)(value)));

    public static explicit operator ulong(GContext value) => (ulong)(value.Value);

    public static explicit operator GContext(nuint value) => new GContext(unchecked((void*)(value)));

    public static implicit operator nuint(GContext value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is GContext other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of GContext.");
    }

    public int CompareTo(GContext other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is GContext other) && Equals(other);

    public bool Equals(GContext other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
