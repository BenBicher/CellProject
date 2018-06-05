using System;
using System.ServiceModel;
using System.Runtime.InteropServices;

namespace Cell.Host
{
    public class Program
    {
        #region ConsoleAppCollapseFunction:
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5; 
        #endregion

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            // Hide The Window
            ShowWindow(handle, SW_HIDE);

            ServiceHost host = new ServiceHost(typeof(Cell.Service.CellService));
            host.Open();
            Console.WriteLine("Hit Any Key To Close");
            Console.ReadKey();
            host.Close();
        }
    }
}