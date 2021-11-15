// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct Font : IComparable, IComparable<Font>, IEquatable<Font>, IFormattable
    {
        public readonly void* Value;

        public Font(void* value)
        {
            Value = value;
        }

        public static Font NULL => new Font(null);

        public static bool operator ==(Font left, Font right) => left.Value == right.Value;

        public static bool operator !=(Font left, Font right) => left.Value != right.Value;

        public static bool operator <(Font left, Font right) => left.Value < right.Value;

        public static bool operator <=(Font left, Font right) => left.Value <= right.Value;

        public static bool operator >(Font left, Font right) => left.Value > right.Value;

        public static bool operator >=(Font left, Font right) => left.Value >= right.Value;

        public static explicit operator Font(void* value) => new Font(value);

        public static implicit operator void*(Font value) => value.Value;

        public static explicit operator Font(byte value) => new Font((void*)(value));

        public static explicit operator byte(Font value) => (byte)(value.Value);

        public static explicit operator Font(short value) => new Font((void*)(value));

        public static explicit operator short(Font value) => (short)(value.Value);

        public static explicit operator Font(int value) => new Font((void*)(value));

        public static explicit operator int(Font value) => (int)(value.Value);

        public static explicit operator Font(long value) => new Font((void*)(value));

        public static explicit operator long(Font value) => (long)(value.Value);

        public static explicit operator Font(nint value) => new Font((void*)(value));

        public static implicit operator nint(Font value) => (nint)(value.Value);

        public static explicit operator Font(sbyte value) => new Font((void*)(value));

        public static explicit operator sbyte(Font value) => (sbyte)(value.Value);

        public static explicit operator Font(ushort value) => new Font((void*)(value));

        public static explicit operator ushort(Font value) => (ushort)(value.Value);

        public static explicit operator Font(uint value) => new Font((void*)(value));

        public static explicit operator uint(Font value) => (uint)(value.Value);

        public static explicit operator Font(ulong value) => new Font((void*)(value));

        public static explicit operator ulong(Font value) => (ulong)(value.Value);

        public static explicit operator Font(nuint value) => new Font((void*)(value));

        public static implicit operator nuint(Font value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is Font other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Font.");
        }

        public int CompareTo(Font other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is Font other) && Equals(other);

        public bool Equals(Font other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
