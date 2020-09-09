using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcadToolBar
{
    public static class ProcessTools
    {
        public static bool CheckProcByName(string name)
        {
            var allProcesses = Process.GetProcesses();

            return allProcesses.Any(process => process.ProcessName == name);
        }

        public static bool CheckProcWithPid(int pid)
        {
            var allProcesses = Process.GetProcesses();

            return allProcesses.Any(process => process.Id == pid);
        }

        public static void KillAllProcWithName(string name)
        {
            var processes = Process.GetProcessesByName(name);

            if (processes.Length == 0)
                return;
            foreach (var proc in processes)
            {
                if (proc.Id == Process.GetCurrentProcess().Id) continue;
                try
                {
                    proc.Kill();
                }
                catch
                {
                    //unused
                }
            }
        }
    }
}
