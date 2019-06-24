// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

namespace TerraFX.Interop
{
    public static unsafe partial class libc
    {
        public const int CLOCK_REALTIME = 0;

        public const int CLOCK_MONOTONIC = 1;

        public const int CLOCK_PROCESS_CPUTIME_ID = 2;

        public const int CLOCK_THREAD_CPUTIME_ID = 3;
    }
}
