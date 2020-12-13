using System.Diagnostics;

namespace PrismApp.Models
{
    public class ProcessInfo
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Info { get; set; }
        public string Priority { get; set; }

        public ProcessModuleCollection Modules { get; set; }

        public Process ThisProcess { get; set; }
        public int Id { get; set; }
        public ProcessStartInfo StartInfo { get; set; }

        public ProcessInfo(Process process)
        {
            this.ThisProcess = process;
        }

        public void RefreshInfo()
        {
            Name = ThisProcess.ProcessName;
            Info = ThisProcess.ToString();
            Id = ThisProcess.Id;
            
            
            StartInfo = ThisProcess.StartInfo;
            try
            {
                Modules = ThisProcess.Modules;
            }
            catch
            {
                Modules = null;
            }

            try
            {
                if (ThisProcess.MainModule != null) FileName = ThisProcess.MainModule.FileName;
            }
            catch
            {
                FileName = "Access Denied";
            }

            try
            {
                Priority = ThisProcess.PriorityClass.ToString();
            }
            catch 
            {
                Priority = "Access Denied";
            }
            
        }
    }
}
