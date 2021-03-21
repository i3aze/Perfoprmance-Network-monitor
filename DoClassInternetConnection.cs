using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;

namespace PerfMonFormSecond
{
    class DoClassInternetConnection
    {
        public Icon _IconInternetConnection;
        public readonly NotifyIcon _notifyIconInternetConnection = new NotifyIcon();
        Thread _threadPing;
        private static ReaderWriterLockSlim Lock = new ReaderWriterLockSlim();
        string user = Environment.UserName;

        // start the threads
        public void StartThreads()
        {
            _threadPing = new Thread(new ThreadStart(PingGoogle));
            _threadPing.Start();
        }

        // method that pings google each second and calls the method that writtes in the csv file
        public void PingGoogle()
        {
            Ping myPing = new Ping();
            PingReply reply;

            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                    reply = myPing.Send("8.8.8.8", 1000);

                    if (reply.Status == IPStatus.Success)
                    {
                        _IconInternetConnection = new Icon("IconsInternet\\ConnectedIcon.ico");
                        _notifyIconInternetConnection.Icon = _IconInternetConnection;
                        _notifyIconInternetConnection.Visible = true;
                        _notifyIconInternetConnection.Text = "Connected";
                        WriteDataToFileSW("Connected");
                    }
                }
                catch (PingException)
                {
                    _IconInternetConnection = new Icon("IconsInternet\\NotConnectedIcon.ico");
                    _notifyIconInternetConnection.Icon = _IconInternetConnection;
                    _notifyIconInternetConnection.Visible = true;
                    _notifyIconInternetConnection.Text = "Not Connected";
                    WriteDataToFileSW("Not Connected");
                }
                catch (Exception e)
                {
                    e.Message.ToString();
                }
            }
        }

        // write data in the csv file
        public void WriteDataToFileSW(string value)
        {
            Lock.EnterWriteLock();
            try
            {
                using (StreamWriter sw = File.AppendText("C:\\Users\\" + user + "\\Documents\\CPU-RAM Telemetry.csv"))
                {
                    string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    var line = String.Format("{0}; {1}; {2}", dateTime, "Internet connection", value);
                    sw.WriteLine(line);
                }
            }
            catch (IOException ioe)
            {
                ioe.Message.ToString();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                Lock.ExitWriteLock();
            }
        }

        public void ClosePing()
        {
            if(_threadPing.IsAlive)
            {
                _threadPing.Abort();
                Application.Exit();
            }
        }
    }
}
