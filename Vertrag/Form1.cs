using System;
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
using System.Diagnostics;

namespace Prototype
{
    public partial class Form1 : Form
    {
        private string product_id = Program.paintball;
		static int age_requirement = 18;
        string product = null;

		public Form1()
        {
            InitializeComponent();
			Thread nfc = new Thread(NFC_in);
			nfc.Start();
        }
		
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_paintball_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "Haftungsausschuss Paintball";
            product_id = Program.paintball;
            age_requirement = 18;
            product = "Paintball";
        }

        private void btn_splatmaster_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "Haftungsausschuss Splat Master";
            product_id = Program.splatMaster;
            age_requirement = 12;
            product = "Splat Master";
        }

        private void btn_bubble_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "Haftungsausschuss Bubble Bounce";
            product_id = Program.bubble;
            age_requirement = 12;
            product = "Bubble Bounce";
        }

        private void btn_archery_Click(object sender, EventArgs e)
        {
            lbl_display.Text = "Haftungsausschuss Archery";
            product_id = Program.archery;
            age_requirement = 12;
            product = "Archery";
        }

        private void writeData()
        {
            string fileName = "cmdbook.txt";

            string sourceFile = System.IO.Path.Combine(Program.filepathSource, fileName);
            string targetFile = System.IO.Path.Combine(Program.filepathSend, fileName);

            string text = File.ReadAllText(sourceFile);
            text = text.Replace("%uid%", Program.UID);
            text = text.Replace("%nr%", product_id);
            File.WriteAllText(targetFile, text);
        }

        private void check()
        {
            string fileName = "getname.txt";

            string sourceFile = System.IO.Path.Combine(Program.filepathSource, fileName);
            string targetFile = System.IO.Path.Combine(Program.filepathSend, fileName);

            string text = File.ReadAllText(sourceFile);
            text = text.Replace("%uid%", Program.UID);
            File.WriteAllText(targetFile, text);

            Protokoll.getNameData();

            Program.name = readName();
            Program.surname = readSurname();
            Program.age = readAge();
            //if (File.Exists(Program.filepath + "responsegetname.txt"))
            //	File.Delete(Program.filepath + "responsegetname.txt");
            Form2 frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;

            if (Program.age < age_requirement)
            {
                this.TopMost = false;
                frm.ShowDialog();
            }
            else
            {
                writeData();
                Protokoll.BookData();
                //if (File.Exists(Program.filepath + "SendData/cmdbook.txt"))
                //	File.Delete(Program.filepath + "SendData/cmdbook.txt");
                if (lbl_confirm.InvokeRequired)
                    lbl_confirm.Invoke(new MethodInvoker(delegate
                    {
                        lbl_confirm.Text = Program.name + " " + Program.surname + " hat Haftungsausschuss für " +
                                           product + " abgeschlossen";
                    }));
                else
                {
                    lbl_confirm.Text = Program.name + " " + Program.surname + " hat Haftungsausschuss für " + product +
                                       " abgeschlossen";
                }
                
                Thread.Sleep(2000);
                if (lbl_confirm.InvokeRequired)
                    lbl_confirm.Invoke(new MethodInvoker(delegate { lbl_confirm.Text = ""; }));
                else
                {
                    lbl_confirm.Text = "";
                }

            }
        }

        private static string readName()
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

        private static string readSurname()
        {
            string surname = "";
 
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

        private static int readAge()
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

        private static void wait(int min) //wait funktion
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

        public void NFC_in()
        {
            while (true)
            {
                Thread.Sleep(2000); //ms
                Program.UID = null;
                string id = "s000000000000";

                while (id == "s000000000000")
                {
                    Process process1 = Process.Start("/bin/bash", "-c \"sudo /home/pi/Clientvertrag/Scanner.out\"");
                    process1.WaitForExit();

                    string[] lines = File.ReadAllLines(Program.filepath + "UID.txt", Encoding.UTF8);
                    id = lines[0];
                    Program.UID = id;
                }
				
                check();
            }
        }
	}
}