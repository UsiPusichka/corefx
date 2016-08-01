// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using System.Text;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.SecurityLsa, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool LookupAccountNameW(
            string machineName, string accountName, byte[] sid,
            ref int sidLen, 
            [Out] StringBuilder domainName, ref uint domainNameLen, out int peUse);
    }
}
