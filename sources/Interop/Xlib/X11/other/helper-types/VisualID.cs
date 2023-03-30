// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct VisualID : IComparable, IComparable<VisualID>, IEquatable<VisualID>, IFormattable
{
    public readonly void* Value;

    public VisualID(void* value)
    {
        Value = value;
    }

    public static VisualID NULL => new VisualID(null);

    public static bool operator ==(VisualID left, VisualID right) => left.Value == right.Value;

    public static bool operator !=(VisualID left, VisualID right) => left.Value != right.Value;

    public static bool operator <(VisualID left, VisualID right) => left.Value < right.Value;

    public static bool operator <=(VisualID left, VisualID right) => left.Value <= right.Value;

    public static bool operator >(VisualID left, VisualID right) => left.Value > right.Value;

    public static bool operator >=(VisualID left, VisualID right) => left.Value >= right.Value;

    public static explicit operator VisualID(void* value) => new VisualID(value);

    public static implicit operator void*(VisualID value) => value.Value;

    public static explicit operator VisualID(byte value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator byte(VisualID value) => (byte)(value.Value);

    public static explicit operator VisualID(short value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator short(VisualID value) => (short)(value.Value);

    public static explicit operator VisualID(int value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator int(VisualID value) => (int)(value.Value);

    public static explicit operator VisualID(long value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator long(VisualID value) => (long)(value.Value);

    public static explicit operator VisualID(nint value) => new VisualID(unchecked((void*)(value)));

    public static implicit operator nint(VisualID value) => (nint)(value.Value);

    public static explicit operator VisualID(sbyte value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator sbyte(VisualID value) => (sbyte)(value.Value);

    public static explicit operator VisualID(ushort value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator ushort(VisualID value) => (ushort)(value.Value);

    public static explicit operator VisualID(uint value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator uint(VisualID value) => (uint)(value.Value);

    public static explicit operator VisualID(ulong value) => new VisualID(unchecked((void*)(value)));

    public static explicit operator ulong(VisualID value) => (ulong)(value.Value);

    public static explicit operator VisualID(nuint value) => new VisualID(unchecked((void*)(value)));

    public static implicit operator nuint(VisualID value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VisualID other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VisualID.");
    }

    public int CompareTo(VisualID other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VisualID other) && Equals(other);

    public bool Equals(VisualID other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
