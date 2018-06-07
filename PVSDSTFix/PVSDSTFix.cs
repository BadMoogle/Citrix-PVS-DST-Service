using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PVSDSTFix
{
    public partial class PVSDSTFix : ServiceBase
    {

        public PVSDSTFix()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 300000; // 5 minutes
            timer.Start();
            this.OnTimer();
        }

        protected override void OnStop()
        {
            
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            Process gpProcess = new Process();
            gpProcess.StartInfo.FileName = "gpupdate.exe";
            gpProcess.StartInfo.Arguments = "/force";
            gpProcess.Start();
        }

        public void OnTimer()
        {
            Process gpProcess = new Process();
            gpProcess.StartInfo.FileName = "gpupdate.exe";
            gpProcess.StartInfo.Arguments = "/force";
            gpProcess.Start();
        }
    }
}
