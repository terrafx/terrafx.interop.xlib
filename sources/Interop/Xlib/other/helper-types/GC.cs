// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct GC : IComparable, IComparable<GC>, IEquatable<GC>, IFormattable
    {
        public readonly void* Value;

        public GC(void* value)
        {
            Value = value;
        }

        public static GC NULL => new GC(null);

        public static bool operator ==(GC left, GC right) => left.Value == right.Value;

        public static bool operator !=(GC left, GC right) => left.Value != right.Value;

        public static bool operator <(GC left, GC right) => left.Value < right.Value;

        public static bool operator <=(GC left, GC right) => left.Value <= right.Value;

        public static bool operator >(GC left, GC right) => left.Value > right.Value;

        public static bool operator >=(GC left, GC right) => left.Value >= right.Value;

        public static explicit operator GC(void* value) => new GC(value);

        public static implicit operator void*(GC value) => value.Value;

        public static explicit operator GC(byte value) => new GC((void*)(value));

        public static explicit operator byte(GC value) => (byte)(value.Value);

        public static explicit operator GC(short value) => new GC((void*)(value));

        public static explicit operator short(GC value) => (short)(value.Value);

        public static explicit operator GC(int value) => new GC((void*)(value));

        public static explicit operator int(GC value) => (int)(value.Value);

        public static explicit operator GC(long value) => new GC((void*)(value));

        public static explicit operator long(GC value) => (long)(value.Value);

        public static explicit operator GC(nint value) => new GC((void*)(value));

        public static implicit operator nint(GC value) => (nint)(value.Value);

        public static explicit operator GC(sbyte value) => new GC((void*)(value));

        public static explicit operator sbyte(GC value) => (sbyte)(value.Value);

        public static explicit operator GC(ushort value) => new GC((void*)(value));

        public static explicit operator ushort(GC value) => (ushort)(value.Value);

        public static explicit operator GC(uint value) => new GC((void*)(value));

        public static explicit operator uint(GC value) => (uint)(value.Value);

        public static explicit operator GC(ulong value) => new GC((void*)(value));

        public static explicit operator ulong(GC value) => (ulong)(value.Value);

        public static explicit operator GC(nuint value) => new GC((void*)(value));

        public static implicit operator nuint(GC value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is GC other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of GC.");
        }

        public int CompareTo(GC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is GC other) && Equals(other);

        public bool Equals(GC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
