using System;

namespace SAE.J2534
{
    public static class Extensions
    {
        public static IntPtr IntPtr_Add( IntPtr ptr, int offset ) 
        { 
            return (IntPtr)( (UInt64)ptr + (UInt64)offset);
        }

        public static bool IsNullOrWhiteSpace( string str )
        { 
            return ( str == null || str.Trim().Length == 0 );
        }
    }
}
