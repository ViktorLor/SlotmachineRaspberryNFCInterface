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
using System.Threading;

namespace Automat_GUI
{
	public partial class Form1 : Form
	{
		public static string rescan = null;
		public static int number = 1;

		public Form1()
		{
			InitializeComponent();
			Thread scan = new Thread(scanner);
			scan.Start();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_user.Text = Program.surname + " " + Program.name;
			lbl_saldo.Text = string.Format("{0:F2}", Program.saldo);
			lbl_limit.Text = string.Format("{0:F2}", Program.limit);
			
			/*this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;*/
		}

		private void btn_minus_Click(object sender, EventArgs e)
		{
			int cnt = 0;
			int extra = 0;
			int fullcnt = 0;
			double fullprice = 0;
			int.TryParse(lbl_anz.Text, out cnt);
			int.TryParse(lbl_freegame.Text, out extra);

			if (cnt > 1)
			{
				cnt--;
			}

			if (cnt < Program.remember && cnt % 4 != 0)
			{
				Program.remember -= 4;
				extra--;
			}

			number = cnt;
			lbl_anz.Text = cnt.ToString();
			fullcnt = cnt + extra;
			fullprice = cnt * Program.price;
			lbl_freegame.Text = extra.ToString();
			lbl_display_fullcnt.Text = fullcnt.ToString();
			lbl_fullprice.Text = string.Format("{0:F2}", fullprice);
		}

		private void btn_plus_Click(object sender, EventArgs e)
		{
			int cnt = 0;
			int extra = 0;
			int fullcnt = 0;
			double fullprice = 0;
			int.TryParse(lbl_anz.Text, out cnt);
			int.TryParse(lbl_freegame.Text, out extra);

			if (cnt < 40)
			{
				cnt++;
			}

			if (cnt > Program.remember && (cnt % 4) == 0)
			{
				Program.remember += 4;
				extra++;
			}

			number = cnt;
			lbl_anz.Text = cnt.ToString();
			fullcnt = cnt + extra;
			fullprice = cnt * Program.price;
			lbl_freegame.Text = extra.ToString();
			lbl_display_fullcnt.Text = fullcnt.ToString();
			lbl_fullprice.Text = string.Format("{0:F2}", fullprice);
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public static string NFC_in()
		{
			string id = null;
			//Process process1 = Process.Start("/bin/bash", "-c \"/home/pi/Client/a.out\"");
			//process1.WaitForExit();
			
			string text = File.ReadAllText(Program.filepath + "UID.txt", Encoding.UTF8);
			string[] lines = File.ReadAllLines(Program.filepath + "UID.txt", Encoding.UTF8);
			id = lines[0];

			//if (File.Exists(Program.filepath + "UID.txt"))
			//	File.Delete(Program.filepath + "UID.txt");

			return id;
		}

		private void scanner()
		{
			while (rescan == null)
			{
				rescan = NFC_in();
			}
			if (rescan == Program.UID)
			{
				wait(10000);
				int cnt;
				int.TryParse(lbl_display_fullcnt.Text, out cnt);
				//Protokoll.BookData(Protokoll.ipadress, Protokoll.port);
				//if (File.Exists(Program.filepathSend + "cmdbook.txt"))
				//	File.Delete(Program.filepathSend + "cmdbook.txt");
				automat(cnt);

				if (this.InvokeRequired)
					this.Invoke(new MethodInvoker(delegate
					{
						this.Close();
					}));
				else
				{
					this.Close();
				}
			}
			else
			{
				if (this.InvokeRequired)
					this.Invoke(new MethodInvoker(delegate
					{
						this.Close();
					}));
				else
				{
					this.Close();
				}
			}
		}

		private void automat(int num)
		{
			for (int i = 0; i < num; i++)
			{
				//script
				wait(100);
			}
		}

		public static void wait(int min)
		{
			System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
			if (min == 0 || min < 0) return;
			timer1.Interval = min;
			timer1.Enabled = true;
			timer1.Start();
			timer1.Tick += (s, e) =>
			{
				timer1.Enabled = false;
				timer1.Stop();
			};
			while (timer1.Enabled)
			{
				Application.DoEvents();
			}
		}
	}
}