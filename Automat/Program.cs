﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
	static class Program
	{
		public static double price = 0.50;
		public static int remember = 0;
		public static string UID = null;
		public static string name = null;
		public static string surname = null;
		public static double saldo = 0;
		public static double limit = 0;

		//public static string filepathSend = @"C:\Users\alexa\Documents\GitHub\DiplomClienten\DiplomClienten\Automat\Files\SendData\";          //Changed filestructure
		//public static string filepathResponse = @"C:\Users\alexa\Documents\GitHub\DiplomClienten\DiplomClienten\Automat\Files\Response\";	//testing purposes
		//public static string filepathSource = @"C:\Users\alexa\Documents\GitHub\DiplomClienten\DiplomClienten\Automat\Files\Source\";
		//public static string filepath = @"C:\Users\alexa\Documents\GitHub\DiplomClienten\DiplomClienten\Automat\Files\";
		public static string filepathSend = "/home/pi/Client/Files/SendData/";          //Changed filestructure
		public static string filepathResponse = "/home/pi/Client/Files/Response/";
		public static string filepathSource = "/home/pi/Client/Files/Source/";
		public static string filepath = "/home/pi/Client/Files/";
		public static int foreignsystem = 100;
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form2());
		}
	}
}
