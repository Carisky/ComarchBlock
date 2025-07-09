using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComarchBlock
{
    internal static class MessageSender
    {
        const int CREATE_NO_WINDOW = 0x08000000;
        const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;
        const uint TOKEN_DUPLICATE = 0x0002;
        const uint MAXIMUM_ALLOWED = 0x02000000;

        public static void Send(string userName, string message)
        {
            IntPtr server = IntPtr.Zero;
            if (!WTSEnumerateSessions(server, 0, 1, out IntPtr ppSessionInfo, out int sessionCount))
                return;

            try
            {
                int structSize = Marshal.SizeOf<WTS_SESSION_INFO>();
                IntPtr current = ppSessionInfo;

                for (int i = 0; i < sessionCount; i++)
                {
                    var session = Marshal.PtrToStructure<WTS_SESSION_INFO>(current);
                    current += structSize;

                    if (!WTSQuerySessionInformation(server, session.SessionID, WTS_INFO_CLASS.WTSUserName, out IntPtr userPtr, out _))
                        continue;

                    string name = Marshal.PtrToStringAnsi(userPtr);
                    WTSFreeMemory(userPtr);

                    if (string.Equals(name, userName, StringComparison.OrdinalIgnoreCase))
                    {
                        LaunchPopup(session.SessionID, message);
                        break;
                    }
                }
            }
            finally
            {
                WTSFreeMemory(ppSessionInfo);
            }
        }

        static void LaunchPopup(int sessionId, string message)
        {
            Process targetProc = Process.GetProcesses()
                .FirstOrDefault(p => p.SessionId == sessionId && p.ProcessName.Equals("explorer", StringComparison.OrdinalIgnoreCase));
            if (targetProc == null)
                return;

            IntPtr hProcess = OpenProcess(ProcessAccessFlags.QueryInformation, false, targetProc.Id);
            if (hProcess == IntPtr.Zero)
                return;

            if (!OpenProcessToken(hProcess, TOKEN_DUPLICATE, out IntPtr userToken))
            {
                CloseHandle(hProcess);
                return;
            }

            SECURITY_ATTRIBUTES sa = new SECURITY_ATTRIBUTES();
            sa.nLength = Marshal.SizeOf<SECURITY_ATTRIBUTES>();
            if (!DuplicateTokenEx(userToken, MAXIMUM_ALLOWED, ref sa, 2, 1, out IntPtr duplicatedToken))
            {
                CloseHandle(userToken);
                CloseHandle(hProcess);
                return;
            }

            string exePath = Process.GetCurrentProcess().MainModule!.FileName;
            var si = new STARTUPINFO { cb = Marshal.SizeOf<STARTUPINFO>(), lpDesktop = "winsta0\\default" };
            var pi = new PROCESS_INFORMATION();
            string cmd = $"\"{exePath}\" --popup \"{message.Replace("\"", "\\\"")}\"";

            CreateProcessAsUser(duplicatedToken, null, cmd, IntPtr.Zero, IntPtr.Zero, false,
                CREATE_NO_WINDOW | CREATE_UNICODE_ENVIRONMENT, IntPtr.Zero, null, ref si, out pi);

            CloseHandle(duplicatedToken);
            CloseHandle(userToken);
            CloseHandle(hProcess);
        }

        public static void ShowPopup(string message)
        {
            var form = new Form
            {
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(Screen.PrimaryScreen!.Bounds.Width - 350, Screen.PrimaryScreen!.Bounds.Height - 150),
                Width = 300,
                Height = 100,
                BackColor = Color.Gray,
                Opacity = 0.8,
                ShowInTaskbar = false
            };

            var label = new Label
            {
                Dock = DockStyle.Fill,
                Text = message,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White
            };

            form.Controls.Add(label);
            Application.Run(form);
        }

        #region Native
        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSEnumerateSessions(IntPtr hServer, int Reserved, int Version, out IntPtr ppSessionInfo, out int pCount);

        [DllImport("wtsapi32.dll")]
        static extern bool WTSQuerySessionInformation(IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass, out IntPtr ppBuffer, out int pBytesReturned);

        [DllImport("wtsapi32.dll")]
        static extern void WTSFreeMemory(IntPtr pointer);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, ref SECURITY_ATTRIBUTES lpTokenAttributes, int ImpersonationLevel, int TokenType, out IntPtr phNewToken);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        [StructLayout(LayoutKind.Sequential)]
        struct WTS_SESSION_INFO
        {
            public int SessionID;
            [MarshalAs(UnmanagedType.LPStr)] public string pWinStationName;
            public WTS_CONNECTSTATE_CLASS State;
        }

        enum WTS_CONNECTSTATE_CLASS
        {
            WTSActive,
            WTSConnected,
            WTSConnectQuery,
            WTSShadow,
            WTSDisconnected,
            WTSIdle,
            WTSListen,
            WTSReset,
            WTSDown,
            WTSInit
        }

        enum WTS_INFO_CLASS
        {
            WTSUserName = 5
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFO
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public int dwX, dwY, dwXSize, dwYSize;
            public int dwXCountChars, dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput, hStdOutput, hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [Flags]
        enum ProcessAccessFlags : uint
        {
            QueryInformation = 0x0400
        }
        #endregion
    }
}
