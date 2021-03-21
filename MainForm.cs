using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfMonFormSecond
{
    public partial class MainForm : Form
    {
        // Napravi instanci od potrebnite klasi
        DoClassCpuRam doClassCpuRam = new DoClassCpuRam();
        DoClassInternetConnection doClassInternetConnection = new DoClassInternetConnection();
        NotifyIcon niCPU;
        NotifyIcon niRAM;

        public MainForm()
        {
            // startuvaj ja aplikacijata i pocni gi dvata treda
            InitializeComponent();
            StartMethod();

            // minimiziraj ja aplikacijata, sokrij ja od prozorec i od taskbar
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Hide();

            // pokazi gi dvete ikoni
            niCPU = doClassCpuRam._notifyIconCpu;
            niRAM = doClassCpuRam._notifyIconRam;

            // stavi im meni na ikonite na desen klik
            niCPU.ContextMenuStrip = CPUcontextMenuStrip;
            niRAM.ContextMenuStrip = RAMcontextMenuStrip;

            niCPU.Visible = true;
            niRAM.Visible = true;
        }

        public void StartMethod()
        {
            doClassCpuRam.StartThreads();
            doClassInternetConnection.StartThreads();
        }

        // nacin za izlez od aplikacijata preku forma na exit button
        private void Exit_button_Click(object sender, EventArgs e)
        {
            doClassCpuRam.CloseAppMethod();
            doClassInternetConnection.ClosePing();

            if(niCPU.Visible)
            {
                niCPU.Dispose();
            }
            if(niRAM.Visible)
            {
                niRAM.Dispose();
            }

            Application.Exit();
        }

        // izlez od CPU tredot, pravi proverka na kraj, ako i tredot za RAM e zatvoren, ja gasi cela aplikacija
        private void ExitCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(doClassCpuRam._threadTelemetryCpu.IsAlive)
            {
                doClassCpuRam._threadTelemetryCpu.Abort();
                doClassCpuRam._notifyIconCpu.Dispose();
            }
            if(doClassCpuRam._threadTelemetryRam.IsAlive == false)
            {
                doClassCpuRam.CloseAppMethod();
                Application.Exit();
            }
        }

        // izlez od RAM tredot, pravi proverka na kraj, ako i tredot za CPU e zatvoren, ja gasi cela aplikacija
        private void RAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(doClassCpuRam._threadTelemetryRam.IsAlive)
            {
                doClassCpuRam._threadTelemetryRam.Abort();
                doClassCpuRam._notifyIconRam.Dispose();
            }
            if(doClassCpuRam._threadTelemetryCpu.IsAlive == false)
            {
                doClassCpuRam.CloseAppMethod();
                Application.Exit();
            }
        }
    }
}
