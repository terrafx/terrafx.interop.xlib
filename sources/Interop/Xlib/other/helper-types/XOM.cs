// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XOM : IComparable, IComparable<XOM>, IEquatable<XOM>, IFormattable
    {
        public readonly void* Value;

        public XOM(void* value)
        {
            Value = value;
        }

        public static XOM NULL => new XOM(null);

        public static bool operator ==(XOM left, XOM right) => left.Value == right.Value;

        public static bool operator !=(XOM left, XOM right) => left.Value != right.Value;

        public static bool operator <(XOM left, XOM right) => left.Value < right.Value;

        public static bool operator <=(XOM left, XOM right) => left.Value <= right.Value;

        public static bool operator >(XOM left, XOM right) => left.Value > right.Value;

        public static bool operator >=(XOM left, XOM right) => left.Value >= right.Value;

        public static explicit operator XOM(void* value) => new XOM(value);

        public static implicit operator void*(XOM value) => value.Value;

        public static explicit operator XOM(byte value) => new XOM((void*)(value));

        public static explicit operator byte(XOM value) => (byte)(value.Value);

        public static explicit operator XOM(short value) => new XOM((void*)(value));

        public static explicit operator short(XOM value) => (short)(value.Value);

        public static explicit operator XOM(int value) => new XOM((void*)(value));

        public static explicit operator int(XOM value) => (int)(value.Value);

        public static explicit operator XOM(long value) => new XOM((void*)(value));

        public static explicit operator long(XOM value) => (long)(value.Value);

        public static explicit operator XOM(nint value) => new XOM((void*)(value));

        public static implicit operator nint(XOM value) => (nint)(value.Value);

        public static explicit operator XOM(sbyte value) => new XOM((void*)(value));

        public static explicit operator sbyte(XOM value) => (sbyte)(value.Value);

        public static explicit operator XOM(ushort value) => new XOM((void*)(value));

        public static explicit operator ushort(XOM value) => (ushort)(value.Value);

        public static explicit operator XOM(uint value) => new XOM((void*)(value));

        public static explicit operator uint(XOM value) => (uint)(value.Value);

        public static explicit operator XOM(ulong value) => new XOM((void*)(value));

        public static explicit operator ulong(XOM value) => (ulong)(value.Value);

        public static explicit operator XOM(nuint value) => new XOM((void*)(value));

        public static implicit operator nuint(XOM value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is XOM other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XOM.");
        }

        public int CompareTo(XOM other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is XOM other) && Equals(other);

        public bool Equals(XOM other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
