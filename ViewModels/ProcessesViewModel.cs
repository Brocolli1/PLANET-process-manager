using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using PrismApp.Models;

namespace PrismApp.ViewModels
{
    public class ProcessesViewModel : BindableBase
    {
        public DelegateCommand RefreshCommand { get; private set; }

        public List<ProcessInfo> ListedProcesses { get; set; }
        public List<(int,Task)> Monitored { get; set; }
        private Thread refresher;
        public ProcessesViewModel()
        {
            /*refresher = new Thread(RefreshCycle);
            refresher.Start();*/
            Monitored = new List<(int,Task)>();

            RefreshCommand = new DelegateCommand(RefreshProcesses);
            
            ListedProcesses = new List<ProcessInfo>();
            RefreshProcesses();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);
        }

        public void RefreshProcesses()
        {
            ParseProcesses(Process.GetProcesses());
            //refresher.Suspend();
            foreach (var process in ListedProcesses)
            {
                process.RefreshInfo();
            }
            //refresher.Resume();
        }

        public void RefreshCycle()
        {
            /*while(true)
            {
                Thread.Sleep(5000);
                RefreshProcesses();
                MessageBox.Show("Refreshed");
            }*/
        }

        private void ParseProcesses(Process[] infos)
        {
            ListedProcesses.Clear();
            foreach (var info in infos)
            {
                
                ListedProcesses.Add(new ProcessInfo(info));
            }
        }

        public void Sort()
        {
            ListedProcesses.Sort((a, b) => a.Id - b.Id);
        }

        public static void KillProcess(int processId)
        {
            try
            {
                Process.GetProcessById(processId).Kill();
            }
            catch
            {
                MessageBox.Show("Can't kill process, access denied");
            }
        }

        public static void SetProcessPriorityToHigh(int processId)
        {
            Process.GetProcessById(processId).PriorityClass = ProcessPriorityClass.High;
        }
    

        public static void SetProcessPriorityToLow(int processId)
        { 
            Process.GetProcessById(processId).PriorityClass = ProcessPriorityClass.BelowNormal;
        }

        public static void StartProcess(ProcessStartInfo StartInfo)
        {
            if (StartInfo.FileName != "")
                Process.Start(StartInfo);
        }

        public void MonitorProcess(ProcessInfo selectedItem)
        {
            Monitored.Add((selectedItem.Id, Task.Run(() =>
                {
                    selectedItem.ThisProcess.WaitForExit();
                    selectedItem.ThisProcess.Start();
                }
                )));
        }

        public static void StopMonitoring(int id)
        {
            throw new NotImplementedException();
        }
    }
}

