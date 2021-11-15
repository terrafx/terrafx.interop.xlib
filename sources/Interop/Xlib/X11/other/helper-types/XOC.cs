// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct XOC : IComparable, IComparable<XOC>, IEquatable<XOC>, IFormattable
    {
        public readonly void* Value;

        public XOC(void* value)
        {
            Value = value;
        }

        public static XOC NULL => new XOC(null);

        public static bool operator ==(XOC left, XOC right) => left.Value == right.Value;

        public static bool operator !=(XOC left, XOC right) => left.Value != right.Value;

        public static bool operator <(XOC left, XOC right) => left.Value < right.Value;

        public static bool operator <=(XOC left, XOC right) => left.Value <= right.Value;

        public static bool operator >(XOC left, XOC right) => left.Value > right.Value;

        public static bool operator >=(XOC left, XOC right) => left.Value >= right.Value;

        public static explicit operator XOC(void* value) => new XOC(value);

        public static implicit operator void*(XOC value) => value.Value;

        public static explicit operator XOC(byte value) => new XOC((void*)(value));

        public static explicit operator byte(XOC value) => (byte)(value.Value);

        public static explicit operator XOC(short value) => new XOC((void*)(value));

        public static explicit operator short(XOC value) => (short)(value.Value);

        public static explicit operator XOC(int value) => new XOC((void*)(value));

        public static explicit operator int(XOC value) => (int)(value.Value);

        public static explicit operator XOC(long value) => new XOC((void*)(value));

        public static explicit operator long(XOC value) => (long)(value.Value);

        public static explicit operator XOC(nint value) => new XOC((void*)(value));

        public static implicit operator nint(XOC value) => (nint)(value.Value);

        public static explicit operator XOC(sbyte value) => new XOC((void*)(value));

        public static explicit operator sbyte(XOC value) => (sbyte)(value.Value);

        public static explicit operator XOC(ushort value) => new XOC((void*)(value));

        public static explicit operator ushort(XOC value) => (ushort)(value.Value);

        public static explicit operator XOC(uint value) => new XOC((void*)(value));

        public static explicit operator uint(XOC value) => (uint)(value.Value);

        public static explicit operator XOC(ulong value) => new XOC((void*)(value));

        public static explicit operator ulong(XOC value) => (ulong)(value.Value);

        public static explicit operator XOC(nuint value) => new XOC((void*)(value));

        public static implicit operator nuint(XOC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is XOC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XOC.");
        }

        public int CompareTo(XOC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is XOC other) && Equals(other);

        public bool Equals(XOC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
