
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Mike.Utilities.Desktop
{
    public class Calculadora
    {

        public const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr handle);

        public static void TentarChamar()
        {
            try
            {

                ProcessStartInfo processStartInfo =

                new ProcessStartInfo("calc.exe");

                processStartInfo.WindowStyle = ProcessWindowStyle.Normal;

                Process process = new Process();

                process.StartInfo = processStartInfo;

                process.Start();

                process.WaitForExit(); 

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }
        
		
        public static void ChamarCalculadora()
        {

            try
            {
                /*
                 
                 ProcessStartInfo processStartInfo =

                new ProcessStartInfo("calc.exe");

                processStartInfo.WindowStyle = ProcessWindowStyle.Normal;

                Process process = new Process();

                process.StartInfo = processStartInfo;

                process.Start();

                process.WaitForExit(); /
                 
                 */
                Process[] ps = Process.GetProcessesByName("calc");
                if (ps.Length == 0)
                {
                    System.Diagnostics.Process.Start("calc.exe");
                }
                else
                {
                    BringToForeground(ps[0].MainWindowHandle);
                }      


            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        
        }

        private static void BringToForeground(IntPtr extHandle)
        {
            try
            {

                if (IsIconic(extHandle))
                {
                    ShowWindow(extHandle, SW_RESTORE);
                }
                SetForegroundWindow(extHandle);

            }
            catch (CustomException erro)
            {
                throw new CustomException(erro.Message);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
          
        }
        
    }
}
