using System;

using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Xml;
using System.Globalization;

namespace Prototype
{
	
    static class Program
    {
        
        public static string filepath = "/home/pi/Client/Files/"; //"/home/pi/Client/Files/"
	

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
		    
        }
    }
}

