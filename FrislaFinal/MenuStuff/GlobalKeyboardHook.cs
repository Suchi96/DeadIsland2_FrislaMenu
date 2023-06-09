using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

public class GlobalKeyboardHook
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;
    private const int WM_SYSKEYDOWN = 0x0104;
    private const int WM_SYSKEYUP = 0x0105;

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    private LowLevelKeyboardProc keyboardProc;
    private IntPtr hookId = IntPtr.Zero;

    public event EventHandler<KeyEventArgs> KeyDown;
    public event EventHandler<KeyEventArgs> KeyUp;

    public GlobalKeyboardHook()
    {
        keyboardProc = HookCallback;
        hookId = SetHook(keyboardProc);
    }

    public void Unhook()
    {
        UnhookWindowsHookEx(hookId);
    }

    private IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (Process currentProcess = Process.GetCurrentProcess())
        using (ProcessModule currentModule = currentProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(currentModule.ModuleName), 0);
        }
    }

    private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN))
        {
            int keyCode = Marshal.ReadInt32(lParam);
            KeyEventArgs args = new KeyEventArgs((Keys)keyCode);
            KeyDown?.Invoke(this, args);

            if (args.Handled)
                return (IntPtr)1;
        }
        else if (nCode >= 0 && (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP))
        {
            int keyCode = Marshal.ReadInt32(lParam);
            KeyEventArgs args = new KeyEventArgs((Keys)keyCode);
            KeyUp?.Invoke(this, args);

            if (args.Handled)
                return (IntPtr)1;
        }

        return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
    }

    #region Native Methods

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    #endregion
}

public class KeyEventArgs : EventArgs
{
    public Keys KeyCode { get; }
    public bool Handled { get; set; }

    public KeyEventArgs(Keys keyCode)
    {
        KeyCode = keyCode;
    }
}