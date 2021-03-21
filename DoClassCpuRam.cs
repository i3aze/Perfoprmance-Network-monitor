using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PerfMonFormSecond
{
    public class DoClassCpuRam
    {
        // global variables that can be used in multiple places
        public Icon _IconCpu;
        public readonly NotifyIcon _notifyIconCpu = new NotifyIcon();
        public Icon _IconRam;
        public readonly NotifyIcon _notifyIconRam = new NotifyIcon();
        public Thread _threadTelemetryCpu;
        public Thread _threadTelemetryRam;
        string user = Environment.UserName;

        // start the threads
        public void StartThreads()
        {
            try 
            {
                _threadTelemetryCpu = new Thread(new ThreadStart(GetValuesCPU));
                _threadTelemetryRam = new Thread(new ThreadStart(GetValuesRAM));

                _threadTelemetryCpu.IsBackground = true;
                _threadTelemetryRam.IsBackground = true;
                _threadTelemetryCpu.Start();
                _threadTelemetryRam.Start();
            }
            catch (ThreadStartException tse)
            {
                tse.Message.ToString();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        // get and put CPU values on the taskbar
        public void GetValuesCPU()
        {
            float cpuCount;
            PerformanceCounter perfCPUCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while (true)
            {
                Thread.Sleep(1000);
                cpuCount = perfCPUCount.NextValue();
                WriteDataToFileSW("CPU Usage", cpuCount.ToString("0.00") + "%");
                
                if (float.Parse(cpuCount.ToString("0.00")) > 0 && float.Parse(cpuCount.ToString("0.00")) <= 6.25)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon6x25.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 6.25 && float.Parse(cpuCount.ToString("0.00")) <= 12.5)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon12x5.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 12.5 && float.Parse(cpuCount.ToString("0.00")) <= 18.75)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon18x75.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 18.75 && float.Parse(cpuCount.ToString("0.00")) <= 25)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon25.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 25 && float.Parse(cpuCount.ToString("0.00")) <= 31.25)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon31x25.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 31.25 && float.Parse(cpuCount.ToString("0.00")) <= 37.5)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon37x5.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 37.5 && float.Parse(cpuCount.ToString("0.00")) <= 43.75)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon43x75.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 43.75 && float.Parse(cpuCount.ToString("0.00")) <= 50)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon50.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 50 && float.Parse(cpuCount.ToString("0.00")) <= 56.25)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon56x25.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 56.25 && float.Parse(cpuCount.ToString("0.00")) <= 62.5)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon62x5.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 62.5 && float.Parse(cpuCount.ToString("0.00")) <= 68.75)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon68x75.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 68.75 && float.Parse(cpuCount.ToString("0.00")) <= 75)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon75.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 75 && float.Parse(cpuCount.ToString("0.00")) <= 81.25)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon81x25.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 81.25 && float.Parse(cpuCount.ToString("0.00")) <= 87.5)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon87x5.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 87.5 && float.Parse(cpuCount.ToString("0.00")) <= 93.75)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon93x75.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
                if (float.Parse(cpuCount.ToString("0.00")) > 93.75 && float.Parse(cpuCount.ToString("0.00")) <= 100)
                {
                    _IconCpu = new Icon("IconsCPU\\Icon100.ico");
                    _notifyIconCpu.Icon = _IconCpu;
                    _notifyIconCpu.Visible = true;
                    _notifyIconCpu.Text = "CPU Usage: " + cpuCount.ToString("0.00") + "%";
                }
            }
        }

        // get and put RAM values on the taskbar
        public void GetValuesRAM()
        {
            float ramCount;
            PerformanceCounter perfRAMCount = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            while (true)
            {
                Thread.Sleep(1000);
                ramCount = perfRAMCount.NextValue();
                WriteDataToFileSW("RAM Usage", ramCount.ToString("0.00") + "%");

                if (float.Parse(ramCount.ToString("0.00")) > 0 && float.Parse(ramCount.ToString("0.00")) <= 6.25)
                {
                    _IconRam = new Icon("IconsRAM\\Icon6x25.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 6.25 && float.Parse(ramCount.ToString("0.00")) <= 12.5)
                {
                    _IconRam = new Icon("IconsRAM\\Icon12x5.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 12.5 && float.Parse(ramCount.ToString("0.00")) <= 18.75)
                {
                    _IconRam = new Icon("IconsRAM\\Icon18x75.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 18.75 && float.Parse(ramCount.ToString("0.00")) <= 25)
                {
                    _IconRam = new Icon("IconsRAM\\Icon25.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 25 && float.Parse(ramCount.ToString("0.00")) <= 31.25)
                {
                    _IconRam = new Icon("IconsRAM\\Icon31x25.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 31.25 && float.Parse(ramCount.ToString("0.00")) <= 37.5)
                {
                    _IconRam = new Icon("IconsRAM\\Icon37x5.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 37.5 && float.Parse(ramCount.ToString("0.00")) <= 43.75)
                {
                    _IconRam = new Icon("IconsRAM\\Icon43x75.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 43.75 && float.Parse(ramCount.ToString("0.00")) <= 50)
                {
                    _IconRam = new Icon("IconsRAM\\Icon50.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 50 && float.Parse(ramCount.ToString("0.00")) <= 56.25)
                {
                    _IconRam = new Icon("IconsRAM\\Icon56x25.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 56.25 && float.Parse(ramCount.ToString("0.00")) <= 62.5)
                {
                    _IconRam = new Icon("IconsRAM\\Icon62x5.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 62.5 && float.Parse(ramCount.ToString("0.00")) <= 68.75)
                {
                    _IconRam = new Icon("IconsRAM\\Icon68x75.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 68.75 && float.Parse(ramCount.ToString("0.00")) <= 75)
                {
                    _IconRam = new Icon("IconsRAM\\Icon75.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 75 && float.Parse(ramCount.ToString("0.00")) <= 81.25)
                {
                    _IconRam = new Icon("IconsRAM\\Icon81x25.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 81.25 && float.Parse(ramCount.ToString("0.00")) <= 87.5)
                {
                    _IconRam = new Icon("IconsRAM\\Icon87x5.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 87.5 && float.Parse(ramCount.ToString("0.00")) <= 93.75)
                {
                    _IconRam = new Icon("IconsRAM\\Icon93x75.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
                if (float.Parse(ramCount.ToString("0.00")) > 93.75 && float.Parse(ramCount.ToString("0.00")) <= 100)
                {
                    _IconRam = new Icon("IconsRAM\\Icon100.ico");
                    _notifyIconRam.Icon = _IconRam;
                    _notifyIconRam.Visible = true;
                    _notifyIconRam.Text = "RAM Usage: " + ramCount.ToString("0.00") + "%";
                }
            }
        }

        private static ReaderWriterLockSlim Lock = new ReaderWriterLockSlim();

        // method that writes in a file. the method lets both threads write down simultaneously
        public void WriteDataToFileSW(string telemetry, string value)
        {
            Lock.EnterWriteLock();
            try
            {
                using (StreamWriter sw = File.AppendText("C:\\Users\\" + user + "\\Documents\\CPU-RAM Telemetry.csv"))
                {
                    string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    var line = String.Format("{0}; {1}; {2}", dateTime, telemetry, value);
                    sw.WriteLine(line);
                }
            }
            catch(IOException ioe)
            {
                ioe.Message.ToString();
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Lock.ExitWriteLock();
            }
        }

        // stop the threads, remove the icons
        public void CloseAppMethod()
        {
            try
            {
                if(_threadTelemetryCpu.IsAlive)
                {
                    _threadTelemetryCpu.Abort();
                }
                if(_threadTelemetryRam.IsAlive)
                {
                    _threadTelemetryRam.Abort();
                }
                if(_notifyIconCpu.Visible)
                {
                    _notifyIconCpu.Dispose();
                }
                if(_notifyIconRam.Visible)
                {
                    _notifyIconRam.Dispose();
                }
            }
            catch(ThreadAbortException tae)
            {
                tae.Message.ToString();
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
