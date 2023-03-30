// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib;

public readonly unsafe partial struct KeySym : IComparable, IComparable<KeySym>, IEquatable<KeySym>, IFormattable
{
    public readonly void* Value;

    public KeySym(void* value)
    {
        Value = value;
    }

    public static KeySym NULL => new KeySym(null);

    public static bool operator ==(KeySym left, KeySym right) => left.Value == right.Value;

    public static bool operator !=(KeySym left, KeySym right) => left.Value != right.Value;

    public static bool operator <(KeySym left, KeySym right) => left.Value < right.Value;

    public static bool operator <=(KeySym left, KeySym right) => left.Value <= right.Value;

    public static bool operator >(KeySym left, KeySym right) => left.Value > right.Value;

    public static bool operator >=(KeySym left, KeySym right) => left.Value >= right.Value;

    public static explicit operator KeySym(void* value) => new KeySym(value);

    public static implicit operator void*(KeySym value) => value.Value;

    public static explicit operator KeySym(byte value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator byte(KeySym value) => (byte)(value.Value);

    public static explicit operator KeySym(short value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator short(KeySym value) => (short)(value.Value);

    public static explicit operator KeySym(int value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator int(KeySym value) => (int)(value.Value);

    public static explicit operator KeySym(long value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator long(KeySym value) => (long)(value.Value);

    public static explicit operator KeySym(nint value) => new KeySym(unchecked((void*)(value)));

    public static implicit operator nint(KeySym value) => (nint)(value.Value);

    public static explicit operator KeySym(sbyte value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator sbyte(KeySym value) => (sbyte)(value.Value);

    public static explicit operator KeySym(ushort value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator ushort(KeySym value) => (ushort)(value.Value);

    public static explicit operator KeySym(uint value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator uint(KeySym value) => (uint)(value.Value);

    public static explicit operator KeySym(ulong value) => new KeySym(unchecked((void*)(value)));

    public static explicit operator ulong(KeySym value) => (ulong)(value.Value);

    public static explicit operator KeySym(nuint value) => new KeySym(unchecked((void*)(value)));

    public static implicit operator nuint(KeySym value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is KeySym other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of KeySym.");
    }

    public int CompareTo(KeySym other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is KeySym other) && Equals(other);

    public bool Equals(KeySym other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
