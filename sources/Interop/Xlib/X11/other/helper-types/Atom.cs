// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Xlib
{
    public unsafe partial struct Atom : IComparable, IComparable<Atom>, IEquatable<Atom>, IFormattable
    {
        public readonly void* Value;

        public Atom(void* value)
        {
            Value = value;
        }

        public static Atom NULL => new Atom(null);

        public static bool operator ==(Atom left, Atom right) => left.Value == right.Value;

        public static bool operator !=(Atom left, Atom right) => left.Value != right.Value;

        public static bool operator <(Atom left, Atom right) => left.Value < right.Value;

        public static bool operator <=(Atom left, Atom right) => left.Value <= right.Value;

        public static bool operator >(Atom left, Atom right) => left.Value > right.Value;

        public static bool operator >=(Atom left, Atom right) => left.Value >= right.Value;

        public static explicit operator Atom(void* value) => new Atom(value);

        public static implicit operator void*(Atom value) => value.Value;

        public static explicit operator Atom(byte value) => new Atom((void*)(value));

        public static explicit operator byte(Atom value) => (byte)(value.Value);

        public static explicit operator Atom(short value) => new Atom((void*)(value));

        public static explicit operator short(Atom value) => (short)(value.Value);

        public static explicit operator Atom(int value) => new Atom((void*)(value));

        public static explicit operator int(Atom value) => (int)(value.Value);

        public static explicit operator Atom(long value) => new Atom((void*)(value));

        public static explicit operator long(Atom value) => (long)(value.Value);

        public static explicit operator Atom(nint value) => new Atom((void*)(value));

        public static implicit operator nint(Atom value) => (nint)(value.Value);

        public static explicit operator Atom(sbyte value) => new Atom((void*)(value));

        public static explicit operator sbyte(Atom value) => (sbyte)(value.Value);

        public static explicit operator Atom(ushort value) => new Atom((void*)(value));

        public static explicit operator ushort(Atom value) => (ushort)(value.Value);

        public static explicit operator Atom(uint value) => new Atom((void*)(value));

        public static explicit operator uint(Atom value) => (uint)(value.Value);

        public static explicit operator Atom(ulong value) => new Atom((void*)(value));

        public static explicit operator ulong(Atom value) => (ulong)(value.Value);

        public static explicit operator Atom(nuint value) => new Atom((void*)(value));

        public static implicit operator nuint(Atom value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is Atom other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of Atom.");
        }

        public int CompareTo(Atom other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is Atom other) && Equals(other);

        public bool Equals(Atom other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
