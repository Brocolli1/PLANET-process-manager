using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using PrismApp.Models;

namespace PrismApp.ViewModels
{
    public class ProcessesViewModel : BindableBase
    {
        public DelegateCommand RefreshCommand { get; private set; }
        public List<ProcessInfo> ListedProcesses { get; set; }
        public ProcessesViewModel()
        {
            RefreshCommand = new DelegateCommand(RefreshProcesses);
            ListedProcesses = new List<ProcessInfo>();
            RefreshProcesses();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);

            /*var timer = new System.Threading.Timer((e) =>
            {
                RefreshProcesses();
            }, null, startTimeSpan, periodTimeSpan);*/
        }

        public void RefreshProcesses()
        {
            ParseProcesses(Process.GetProcesses());
            foreach (var process in ListedProcesses)
            {
                process.RefreshInfo();
            }
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
            Process.GetProcessById(processId).Kill();
        }

        public static void SetProcessPriorityToHigh(int processId)
        {
            if (Process.GetProcessById(processId).PriorityClass != ProcessPriorityClass.High)
            {
                Process.GetProcessById(processId).PriorityClass = ProcessPriorityClass.High;
            }
        }

        public static void SetProcessPriorityToLow(int processId)
        {
            if (Process.GetProcessById(processId).PriorityClass != ProcessPriorityClass.BelowNormal)
            {
                Process.GetProcessById(processId).PriorityClass = ProcessPriorityClass.BelowNormal;
            }
        }

        public static void StartProcess(ProcessStartInfo StartInfo)
        {
            if (StartInfo.FileName != "")
                Process.Start(StartInfo);
        }
    }
}

