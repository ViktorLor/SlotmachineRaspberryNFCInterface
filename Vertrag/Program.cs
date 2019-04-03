using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
	static class Program
	//final version, ready for tests!
	{
		public static string paintball = "300751";
		public static string splatMaster = "300752";
		public static string bubble = "300753";
		public static string archery = "300754";
		public static string UID = null;
		public static string name = null;
		public static string surname = null;
		public static int age = 0;
		public static string filepathSend = "/home/pi/Clientvertrag/Files/SendData/";			//Changed filestructure
		public static string filepathResponse = "/home/pi/Clientvertrag/Files/Response/";
		public static string filepathSource = "/home/pi/Clientvertrag/Files/Source/";
		public static string filepath = "/home/pi/Clientvertrag/Files/";
		public static int foreignsystem = 104;
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			
		}
	}
}
