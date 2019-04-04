using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Prototype
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_information.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Bold);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
			this.Activated += AfterLoading;
			this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
		}

        private void AfterLoading(object sender, EventArgs e)
        {
			Application.DoEvents(); //initialisieren
            this.Activated -= AfterLoading;
			while (Program.UID == null)
			{
				Program.UID = null;
				this.Show();
				lbl_information.Text = "Bitte NFC-Scan durchführen";
				while (Program.UID == null)
				{
					Program.UID = NFC_in();
				}

				if (Program.UID != null)				//doesnt work without it
				{
					getnameHelper();
					Program.name = readName();
					Program.surname = readSurname();
					Program.age = readAge();
					Program.saldo = readSaldo();
					Program.limit = readLimit();

					Form1 frm = new Form1(); //öffnen des nächsten fensters
					frm.Location = this.Location;
					frm.StartPosition = FormStartPosition.Manual;
					frm.ShowDialog();
					this.Hide();
					this.Show();
				}
				Program.UID = null;
			}
        }

        public static string NFC_in() //funktion zum auslesen der NFC-armbänder
        {
            string id = "s000000000000123";
			
            //Process process1 = Process.Start("/bin/bash", "-c \"sudo /home/pi/Client/Scanner.out\"");
            //process1.WaitForExit();

            string[] lines = File.ReadAllLines(Program.filepath + "UID.txt", Encoding.UTF8);
            id = lines[0];

			Form3.wait(500);

			if (id != "s000000000000")
				return id;
			else
				return null;
        }

        private string readName()
        {
            string name = "";
            string text =
                File.ReadAllText(Program.filepathResponse + "responsegetname.txt",
                    Encoding.UTF8); //einlesen der datenbank(produktliste
            string[] lines =
                File.ReadAllLines(Program.filepathResponse + "responsegetname.txt",
                    Encoding.UTF8); //trennen in die einzelnen zeilen
            string[] help_1 = lines[2].Split('>'); //information in festgelegter zeile
            string help_2 = help_1[1];
            foreach (char c in help_2) //elemente durchgehen bis das nächste beginnt
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
            string text =
                File.ReadAllText(Program.filepathResponse + "responsegetname.txt",
                    Encoding.UTF8); //einlesen der datenbank(produktliste
            string[] lines =
                File.ReadAllLines(Program.filepathResponse + "responsegetname.txt",
                    Encoding.UTF8); //trennen in die einzelnen zeilen
            string[] help_1 = lines[1].Split('>'); //information in festgelegter zeile
            string help_2 = help_1[1];
            foreach (char c in help_2) //elemente durchgehen bis das nächste beginnt
            {
                if (c != '<')
                    surname += c;
                else
                    break;
            }

            return surname;
        }

        private int readAge()
        {
            int age = 0;
            string d = "";
            string t;
            double h;
            DateTime date;
            DateTime today;
            TimeSpan diff;

            t = DateTime.Today.ToString("yyyy-MM-dd"); //heutiges datum abfragen

            string text =
                File.ReadAllText(Program.filepathResponse + "responsegetname.txt",
                    Encoding.UTF8); //einlesen der datenbank(produktliste
            string[] lines = File.ReadAllLines(Program.filepathResponse + "responsegetname.txt", Encoding.UTF8);
            string[] help_1 = lines[5].Split('>'); //information in festgelegter zeile
            string help_2 = help_1[1];
            foreach (char c in help_2) //elemente durchgehen bis das nächste beginnt
            {
                if (c != '<')
                    d += c;
                else
                    break;
            }

            date = DateTime.Parse(d);
            today = DateTime.Parse(t);
            diff = today - date; //alter in tage berechnen
            h = diff.TotalDays / 365.25;
            age = (int) h; //alter in jahren zurückgeben
            return age;
        }

        private double readSaldo()
        {
            string fileName = "saldo.txt";

            string sourceFile = System.IO.Path.Combine(Program.filepathSource, fileName);
            string targetFile = System.IO.Path.Combine(Program.filepathSend, fileName);

            string text = File.ReadAllText(sourceFile, Encoding.UTF8);
            text = text.Replace("%uid%", Program.UID);
            File.WriteAllText(targetFile, text);
            Protokoll.SaldoData();

            double s = 0;
            string[] lines =
                File.ReadAllLines(Program.filepathResponse + "responsesaldo.txt",
                    Encoding.UTF8); //trennen in die einzelnen zeilen
            string[] help_1 = lines[3].Split('>');
            string[] help_2 = help_1[1].Split('<');

            double.TryParse(help_2[0], out s);

            return s / 100; //Anzeigefehler . und ,
        }

        private double readLimit()
        {
            double l = 0;
            string text =
                File.ReadAllText(Program.filepathResponse + "responsesaldo.txt",
                    Encoding.UTF8); //einlesen der datenbank(produktliste
            string[] lines =
                File.ReadAllLines(Program.filepathResponse + "responsesaldo.txt",
                    Encoding.UTF8); //trennen in die einzelnen zeilen
            string[] help_1 = lines[4].Split('>');
            string[] help_2 = help_1[1].Split('<');

            double.TryParse(help_2[0], out l);
            return l / 100;
        }

        private void getnameHelper()
        {
            string fileName = "getname.txt";

			string sourceFile = Program.filepathSource + fileName;
            string targetFile = Program.filepathSend + fileName;

            string text = File.ReadAllText(sourceFile);
            text = text.Replace("%uid%", Program.UID);
            File.WriteAllText(targetFile, text);

            Protokoll.getNameData();
        }
    }
}