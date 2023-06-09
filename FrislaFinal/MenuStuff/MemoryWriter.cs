using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class MemoryWriter
{
    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    private static extern bool CloseHandle(IntPtr hObject);

    public static void WriteMemory(string processName, IntPtr baseAddress, byte[] buffer)
    {
        Process process = Process.GetProcessesByName(processName)[0];
        IntPtr processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, process.Id);

        int bytesWritten;
        WriteProcessMemory(processHandle, baseAddress, buffer, (uint)buffer.Length, out bytesWritten);

        CloseHandle(processHandle);
    }
}
