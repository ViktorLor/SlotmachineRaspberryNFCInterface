﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Automat_GUI
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			/*this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;*/
			this.Activated += AfterLoading;
		}

		private void AfterLoading(object sender, EventArgs e)
		{
			Application.DoEvents();
			this.Activated -= AfterLoading;
			while (Program.UID == null)
			{
				this.Show();
				lbl_nfc.Text = "Bitte NFC-Scan durchführen";
				while (Program.UID == null)
				{
					Program.UID = Form1.NFC_in();
				}
				getnameHelper();

				if (Program.UID != null)
				{
					Program.name = readName();
					Program.surname = readSurname();
					Program.saldo = readSaldo();
					Program.limit = readLimit();

					Form1 frm = new Form1();
					frm.Location = this.Location;
					frm.StartPosition = FormStartPosition.Manual;
					frm.ShowDialog();
					this.Hide();
					this.Show();
				}

				Program.UID = null;
			}
		}

		private string readName()
		{
			string name = "";
			string text = File.ReadAllText(Program.filepathResponse + "responsegetname.txt", Encoding.UTF8);
			string[] lines = File.ReadAllLines(Program.filepathResponse + "responsegetname.txt", Encoding.UTF8); 
			string[] help_1 = lines[2].Split('>'); 
			string help_2 = help_1[1];
			foreach (char c in help_2) 
			{
				if (c != '<')
					name += c;
				else
					break;
			}
			return name;
		}

		private string readSurname()
		{
			string surname = "";
			string text = File.ReadAllText(Program.filepathResponse + "responsegetname.txt", Encoding.UTF8); 
			string[] lines = File.ReadAllLines(Program.filepathResponse + "responsegetname.txt", Encoding.UTF8); 
			string[] help_1 = lines[1].Split('>');
			string help_2 = help_1[1];
			foreach (char c in help_2) 
			{
				if (c != '<')
					surname += c;
				else
					break;
			}
			return surname;
		}

		private double readSaldo()
		{
			double s = 0;
			string text = File.ReadAllText(Program.filepathResponse + "responsesaldo.txt", Encoding.UTF8);   
			string[] lines = File.ReadAllLines(Program.filepathResponse + "responsesaldo.txt", Encoding.UTF8); 
			string[] help_1 = lines[3].Split('>');
			string[] help_2 = help_1[1].Split('<');

			double.TryParse(help_2[0], out s);

			return s / 100;
		}

		private double readLimit()
		{
			double l = 0;
			string text = File.ReadAllText(Program.filepathResponse + "responsesaldo.txt", Encoding.UTF8); 
			string[] lines = File.ReadAllLines(Program.filepathResponse + "responsesaldo.txt", Encoding.UTF8); 
			string[] help_1 = lines[4].Split('>');
			string[] help_2 = help_1[1].Split('<');

			double.TryParse(help_2[0], out l);
			return l / 100;
		}

		public void getnameHelper()
		{
			string fileName = "getname.txt";

			string sourceFile = System.IO.Path.Combine(Program.filepathSource, fileName);
			string targetFile = System.IO.Path.Combine(Program.filepathSend, fileName);

			string text = File.ReadAllText(sourceFile);
			text = text.Replace("%uid%", Program.UID);
			File.WriteAllText(targetFile, text);

			Protokoll.getNameData();
		}
	}
}