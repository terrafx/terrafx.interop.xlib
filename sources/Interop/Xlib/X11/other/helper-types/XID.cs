// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct XID : IComparable, IComparable<XID>, IEquatable<XID>, IFormattable
    {
        public readonly void* Value;

        public XID(void* value)
        {
            Value = value;
        }

        public static XID NULL => new XID(null);

        public static bool operator ==(XID left, XID right) => left.Value == right.Value;

        public static bool operator !=(XID left, XID right) => left.Value != right.Value;

        public static bool operator <(XID left, XID right) => left.Value < right.Value;

        public static bool operator <=(XID left, XID right) => left.Value <= right.Value;

        public static bool operator >(XID left, XID right) => left.Value > right.Value;

        public static bool operator >=(XID left, XID right) => left.Value >= right.Value;

        public static explicit operator XID(void* value) => new XID(value);

        public static implicit operator void*(XID value) => value.Value;

        public static explicit operator XID(byte value) => new XID((void*)(value));

        public static explicit operator byte(XID value) => (byte)(value.Value);

        public static explicit operator XID(short value) => new XID((void*)(value));

        public static explicit operator short(XID value) => (short)(value.Value);

        public static explicit operator XID(int value) => new XID((void*)(value));

        public static explicit operator int(XID value) => (int)(value.Value);

        public static explicit operator XID(long value) => new XID((void*)(value));

        public static explicit operator long(XID value) => (long)(value.Value);

        public static explicit operator XID(nint value) => new XID((void*)(value));

        public static implicit operator nint(XID value) => (nint)(value.Value);

        public static explicit operator XID(sbyte value) => new XID((void*)(value));

        public static explicit operator sbyte(XID value) => (sbyte)(value.Value);

        public static explicit operator XID(ushort value) => new XID((void*)(value));

        public static explicit operator ushort(XID value) => (ushort)(value.Value);

        public static explicit operator XID(uint value) => new XID((void*)(value));

        public static explicit operator uint(XID value) => (uint)(value.Value);

        public static explicit operator XID(ulong value) => new XID((void*)(value));

        public static explicit operator ulong(XID value) => (ulong)(value.Value);

        public static explicit operator XID(nuint value) => new XID((void*)(value));

        public static implicit operator nuint(XID value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is XID other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XID.");
        }

        public int CompareTo(XID other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is XID other) && Equals(other);

        public bool Equals(XID other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
