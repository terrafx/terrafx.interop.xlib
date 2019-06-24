// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XSelectionRequestEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public XDisplay* display;

        [NativeTypeName("Window")]
        public UIntPtr owner;

        [NativeTypeName("Window")]
        public UIntPtr requestor;

        [NativeTypeName("Atom")]
        public UIntPtr selection;

        [NativeTypeName("Atom")]
        public UIntPtr target;

        [NativeTypeName("Atom")]
        public UIntPtr property;

        [NativeTypeName("Time")]
        public UIntPtr time;
    }
}