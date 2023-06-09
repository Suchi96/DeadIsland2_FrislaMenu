using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading.Tasks;
using static FrislaFinal.Bools;
using static FrislaFinal.GetAddress;

namespace FrislaFinal
{
    internal class SigScan
    {
        public static Process DI2_PROCESS = null;
        public static Mem MemLib = new Mem();

        public static string GEngine_BaseAddress = "";
        public static string GEngine_AssemblyAddress = "";
       

    

        public static async Task ConnectWorld() // AOB SCAN ONCE IT FOUND PROCESS THEN STORE BASE ADDRESS
        {
            if (!IsWorldConnectionAttempting)
            {
                IsWorldConnectionAttempting = true;

                var GEngineHook = await MemLib.AoBScan(MemLib.mProc.MainModule.BaseAddress.ToInt64(),
                MemLib.mProc.MainModule.BaseAddress.ToInt64() + MemLib.mProc.MainModule.ModuleMemorySize,
                "48 8b 05 ? ? ? ? 48 8b d1 48 8b 88 ? ? ? ? 48 85 c9 74 ? 48 8b 01 48 ff 60 ? 83 ba ? ? ? ? ? 0f 95 c0", true, true, true, "");

                long Address = GEngineHook[0];
                GEngine_AssemblyAddress = (Address.ToString("X2"));
                GEngine_BaseAddress = (Address + MemLib.ReadInt((Address + 3).ToString("X2")) + 7).ToString("X2");
;



                Debug.WriteLine(


              "GEngine_BaseAddress: " + GEngine_BaseAddress
              + "\n" + "\n" +
              "GEngine_AssemblyAddress: " + GEngine_AssemblyAddress

              );


                IsWorldConnectionAttempting = false;

            }
        }
    }
}
