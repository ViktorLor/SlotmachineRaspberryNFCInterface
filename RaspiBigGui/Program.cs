using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Prototype
{
    static class Program
    {
	    public static string filepathSend = "/home/pi/Client/Files/SendData/";			//Changed filestructure
	    public static string filepathResponse = "/home/pi/Client/Files/Response/";
	    public static string filepathSource = "/home/pi/Client/Files/Source/";
        public static string filepath = "/home/pi/Client/Files/";
        public static int foreignsystem = 104;
		public static string UID = null;
		public static string name = null;
		public static string surname = null;
		public static int age = 0;
		public static double saldo = 0;
		public static double limit = 0;

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

