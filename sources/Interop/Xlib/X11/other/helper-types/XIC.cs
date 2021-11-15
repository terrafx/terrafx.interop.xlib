// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct XIC : IComparable, IComparable<XIC>, IEquatable<XIC>, IFormattable
    {
        public readonly void* Value;

        public XIC(void* value)
        {
            Value = value;
        }

        public static XIC NULL => new XIC(null);

        public static bool operator ==(XIC left, XIC right) => left.Value == right.Value;

        public static bool operator !=(XIC left, XIC right) => left.Value != right.Value;

        public static bool operator <(XIC left, XIC right) => left.Value < right.Value;

        public static bool operator <=(XIC left, XIC right) => left.Value <= right.Value;

        public static bool operator >(XIC left, XIC right) => left.Value > right.Value;

        public static bool operator >=(XIC left, XIC right) => left.Value >= right.Value;

        public static explicit operator XIC(void* value) => new XIC(value);

        public static implicit operator void*(XIC value) => value.Value;

        public static explicit operator XIC(byte value) => new XIC((void*)(value));

        public static explicit operator byte(XIC value) => (byte)(value.Value);

        public static explicit operator XIC(short value) => new XIC((void*)(value));

        public static explicit operator short(XIC value) => (short)(value.Value);

        public static explicit operator XIC(int value) => new XIC((void*)(value));

        public static explicit operator int(XIC value) => (int)(value.Value);

        public static explicit operator XIC(long value) => new XIC((void*)(value));

        public static explicit operator long(XIC value) => (long)(value.Value);

        public static explicit operator XIC(nint value) => new XIC((void*)(value));

        public static implicit operator nint(XIC value) => (nint)(value.Value);

        public static explicit operator XIC(sbyte value) => new XIC((void*)(value));

        public static explicit operator sbyte(XIC value) => (sbyte)(value.Value);

        public static explicit operator XIC(ushort value) => new XIC((void*)(value));

        public static explicit operator ushort(XIC value) => (ushort)(value.Value);

        public static explicit operator XIC(uint value) => new XIC((void*)(value));

        public static explicit operator uint(XIC value) => (uint)(value.Value);

        public static explicit operator XIC(ulong value) => new XIC((void*)(value));

        public static explicit operator ulong(XIC value) => (ulong)(value.Value);

        public static explicit operator XIC(nuint value) => new XIC((void*)(value));

        public static implicit operator nuint(XIC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is XIC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of XIC.");
        }

        public int CompareTo(XIC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is XIC other) && Equals(other);

        public bool Equals(XIC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
