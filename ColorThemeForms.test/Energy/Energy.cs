using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ColorThemeForms.test
{
    static class Energy
    {
        [DllImport("powrprof.dll")]
        public static extern uint PowerSetActiveScheme(IntPtr UserPowerKey, ref Guid SchemeGuid);

        public static void onHighPerformance()
        {
            Guid HighPerformance = new Guid("8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
            PowerSetActiveScheme(IntPtr.Zero, ref HighPerformance);
        }

        public static void onLowPerformance()
        {
            Guid PowerSaver = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");
            PowerSetActiveScheme(IntPtr.Zero, ref PowerSaver);
        }

        public static void onAmdBalans()
        {
            Guid PowerSaver = new Guid("9897998c-92de-4669-853f-b7cd3ecb2790");
            PowerSetActiveScheme(IntPtr.Zero, ref PowerSaver);
        }
    }
}
